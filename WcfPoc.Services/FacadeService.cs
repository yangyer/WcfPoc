using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfPoc.Core;

namespace WcfPoc.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class FacadeService : IFacade
    {
        private string _applicaitonName;

        public FacadeService()
        {
            OperationContext context = OperationContext.Current;

            if(context != null)
            {
                try
                {
                    _applicaitonName = context.IncomingMessageHeaders.GetHeader<string>("application-name", "ns");
                }
                catch
                {
                    _applicaitonName = "it did not work";
                }
            }
        }

        public string GetApplicationName()
        {
            return _applicaitonName;
        }

        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
