using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfPoc.Core
{
    [ServiceContract]
    public interface IFacade
    {
        [OperationContract]
        string GetApplicationName();

        [OperationContract]
        int Add(int num1, int num2);
    }
}
