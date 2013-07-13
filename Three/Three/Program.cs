using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Three
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Service2Client client = new ServiceReference1.Service2Client();
            

        

            int add = client.Sum(30,20);

            int sub = client.Sub(45,20);
            //added comment
            System.Console.WriteLine(add);

            System.Console.WriteLine(sub);

            System.Console.ReadLine();
        }
    }
}
