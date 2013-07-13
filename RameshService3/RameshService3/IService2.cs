using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RameshService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService2" in both code and config file together.
    [ServiceContract]
    public interface IService2
    {
        // contracted created by the user
        [OperationContract]
        int Sum(int x, int y);

        [OperationContract]
        int Sub(int x,int y);
    }
}
