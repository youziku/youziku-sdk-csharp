using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youziku.Client;
using Youziku.Param;
using Youziku.Param.Batch;

namespace Sample
{
    class Program
    {
        //初始化方式1
        //internal static IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(new YouzikuConfig()
        //{ 
        //    Host = "http://service.youziku.com",
        //    ApiKey = "xxx" 
        //});


        //初始化方式2
        internal static IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(host: "http://service.youziku.com", apiKey: "xxx");


        internal static async Task Test()
        {
            //1.GetFontface()接口
            var response = await youzikuClient.GetFontFaceAsync(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "jamesbing Inc.",
                Tag = "#gg"
            }
            );

            //2.GetWoffBase64StringFontFace()接口
            var response2 = await youzikuClient.GetWoffBase64StringFontFaceAsync(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "jamesbingbing Inc.",
                Tag = "#gg"
            }
           );


            //3.GetBatchFontFace()接口
            var param = new BatchFontFaceParam();
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "jamesbingbing1 Inc.",
                Tag = "#gg1"
            });
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "jamesbingbing2 Inc.",
                Tag = "#gg2"
            });

            var response3 = await youzikuClient.GetBatchFontFaceAsync(param);


            //4.批量自定义路径 CreateBatchWoffWebFontAsync接口 
            var cusParam = new BatchCustomPathWoffFontFaceParam();
            cusParam.Datas.Add(new CustomPathFontFaceParam
            {
                AccessKey = "xxx",
                Content = "jamesbingbing1 Inc.",
                Url = "jamesbing/test-1"
            });
            cusParam.Datas.Add(new CustomPathFontFaceParam
            {
                AccessKey = "xxx",
                Content = "jamesbingbing2 Inc.",
                Url = "jamesbing/test-2"
            });

            var response4 = await youzikuClient.GetCustomPathBatchWoffWebFontAsync(cusParam);


        }


        static void Main(string[] args)
        {

            Test();
            Console.Read();
        }
    }
}
