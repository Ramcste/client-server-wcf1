using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RameshService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service2" in code, svc and config file together.
    public class Service2 : IService2
    {
        // contract definitions
        public int Sum(int x,int y) {
            return x + y;

        }

        // contract definitions
         public int Sub(int x,int y) {
            return x - y;

        }
    }
}
