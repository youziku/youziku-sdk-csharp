using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Client;
using Youziku.Param;

namespace V35Test.Sample
{
    class Program
    {
        static readonly IYouzikuServiceClient youzikuClient = new YouzikuServiceClient(apiKey: "xxx");

        static void Main()
        {
            var response = youzikuClient.GetFontFace(new FontFaceParam
                {
                    AccessKey = "xxx ",
                    Content = "有字库，让中文跃上云端！",
                    Tag = "#id1",
                    FontFamily = "jamesbing-1"
                }
            );

            //2.GetWoffBase64StringFontFace()接口
            var response2 = youzikuClient.GetWoffBase64StringFontFace(new FontFaceParam
                {
                    AccessKey = "xxx",
                    Content = "有字库，让中文跃上云端！",
                    Tag = "#id1",
                    FontFamily = "test-2"
                }
            );
        }
    }
}
