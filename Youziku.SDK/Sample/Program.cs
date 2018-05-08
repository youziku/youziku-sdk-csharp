using System;
using Youziku.Test.Util;
using Youziku.Test.Util.Impl.CustomPath;
using Youziku.Test.Util.Impl.Single;

namespace V45Test.Sample
{
    class Program
    {

        static void Main(string[] args)
        {

            //Sync同步测试
            IInterfaceTest test = new SingleTestImpl();
            test.Run();

            //Async 异步测试
            IInterfaceTestAsync asyncTest = new CustomPathTestImplAsync();
            asyncTest.Run().Wait();


            Console.ReadLine();
        }
    }
}
