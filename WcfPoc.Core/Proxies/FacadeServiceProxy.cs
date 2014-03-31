using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Web;
using WcfPoc.Core;

namespace WcfPoc.Core.Proxies
{
    public class FacadeServiceProxy : ClientBase<IFacade>, IFacade
    {
        public FacadeServiceProxy()
            : base()
        {
            string applicationName = "test";
            MessageHeader<string> applicationNameHeader = new MessageHeader<string>(applicationName);

            OperationContextScope contextScope = new OperationContextScope(InnerChannel);
            OperationContext.Current.OutgoingMessageHeaders.Add(applicationNameHeader.GetUntypedHeader("application-name", "ns"));
        }
       public FacadeServiceProxy(Binding binding, EndpointAddress endPointAddress)
            : base(binding, endPointAddress)
        {
            string applicationName = "test";
            MessageHeader<string> applicationNameHeader = new MessageHeader<string>(applicationName);

            OperationContextScope contextScope = new OperationContextScope(InnerChannel);
            OperationContext.Current.OutgoingMessageHeaders.Add(applicationNameHeader.GetUntypedHeader("application-name", "ns"));
        }

        public int Add(int num1, int num2)
        {
            return Channel.Add(num1, num2);
        }

        public string GetApplicationName()
        {
            return Channel.GetApplicationName();
        }
    }
}