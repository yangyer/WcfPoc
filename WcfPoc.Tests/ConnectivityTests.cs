using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfPoc.Core.Proxies;
using System.ServiceModel;
using WcfPoc.Core;
using WcfPoc.Services;
using System.ServiceModel.Description;

namespace WcfPoc.Tests
{
    [TestClass]
    public class ConnectivityTests
    {
        [TestMethod]
        public void Connectivity_Test()
        {
            var proxy = ProxyFactory.GetServiceProxy();
            
            var result = proxy.Add(1, 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Connectivity_Test2()
        {
            var proxy = ProxyFactory.GetServiceProxy();

            var result = proxy.GetApplicationName();

            Assert.AreEqual("test", result);
        }
    }
}
