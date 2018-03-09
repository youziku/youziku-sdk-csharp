using System;
using Youziku.Param;

namespace Youziku.Test.Util.Impl.Single
{
    class SingleTestImpl : BaseTestImpl, IInterfaceTest
    {

        public object Run()
        {
            //1.全格式，（Tag可选）
            var response = YouzikuClient.GetFontFace(new FontFaceParam
            {
                AccessKey = "xxx ",
                Content = "有字库，让中文跃上云端！",
                Tag = "#single-id1",
                UseRanFontFamily = true
            }
            );
            //2.WOFF Base64格式（Tag可选）
            var response2 = YouzikuClient.GetWoffBase64StringFontFace(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = ".single-class1",
                
            }
            );

            return null;
        }
    }
}
