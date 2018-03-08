using System;
using Youziku.Test.Util;
using Youziku.Test.Util.Impl.CustomPath;

namespace V35Test.Sample
{
    class Program
    {

        static void Main()
        {
            IInterfaceTest test = new CustomPathTestImpl();
            test.Run();
            Console.ReadLine();
        }
    }
}
