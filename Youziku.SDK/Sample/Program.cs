using System;
using Youziku.Test.Util;
using Youziku.Test.Util.Impl.CustomPath;
using Youziku.Test.Util.Impl.Single;

namespace V45Test.Sample
{
    class Program
    {
        //初始化方式1
        //static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(new YouzikuConfig()
        //{ 
        //    Host = "http://service.youziku.com",
        //    ApiKey = "xxx"
        //});


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
