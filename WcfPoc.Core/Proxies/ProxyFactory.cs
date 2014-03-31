using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfPoc.Core.Proxies
{
    public static class ProxyFactory
    {
        public static FacadeServiceProxy GetServiceProxy()
        {
            //BasicHttpBinding binding = new BasicHttpBinding();
            //EndpointAddress endPointAddress = new EndpointAddress("http://localhost:8733/Design_Time_Addresses/WcfPoc.Services/FacadeService/");

            //return new FacadeServiceProxy(binding, endPointAddress);

            return new FacadeServiceProxy();
        }
    }
}
