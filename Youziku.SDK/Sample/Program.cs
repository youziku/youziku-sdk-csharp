using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youziku.Client;
using Youziku.Param;
using Youziku.Param.Batch;
using Youziku.Settings;

namespace Sample
{
    class Program
    {
        //初始化方式1
        //static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(new YouzikuConfig()
        //{ 
        //    Host = "http://service.youziku.com",
        //    ApiKey = "xxx"
        //});


        //初始化方式2
        static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(apiKey: "xxx");


        internal static async Task Test()
        {
            //1.GetFontface()接口
            var response = await youzikuClient.GetFontFaceAsync(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = "#id1"
            }
            );

            //2.GetWoffBase64StringFontFace()接口
            var response2 = await youzikuClient.GetWoffBase64StringFontFaceAsync(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = "#id1"
            }
           );


            //3.GetBatchFontFace()接口
            var param = new BatchFontFaceParam();
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = "#id1"
            });
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = ".class1"
            });

            var response3 = await youzikuClient.GetBatchFontFaceAsync(param);

            //4.GetBatchWoffFontFace()接口
            var param2 = new BatchFontFaceParam();
            param2.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = "#id1"
            });
            param2.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = ".class1"
            });

            var response4 = await youzikuClient.GetBatchWoffFontFaceAsync(param2);

            //5.批量自定义路径 CreateBatchWoffWebFontAsync接口 
            var cusParam = new BatchCustomPathWoffFontFaceParam();
            cusParam.Datas.Add(new CustomPathFontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Url = "youziku/test-1"
            });
            cusParam.Datas.Add(new CustomPathFontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Url = "youziku/test-2"
            });

            var response5 = await youzikuClient.GetCustomPathBatchWoffWebFontAsync(cusParam);


        }


        static void Main(string[] args)
        {

            Test();
            Console.Read();
        }
    }
}
