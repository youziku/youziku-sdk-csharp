using System.Threading.Tasks;
using Youziku.Param;

namespace Youziku.Test.Util.Impl.Single
{
    class SingleTestImplAsync : BaseTestImpl, IInterfaceTestAsync
    {
        public async Task<dynamic> Run(dynamic param = null)
        {
            //1.全格式，（Tag可选）
            var response = await YouzikuClient.GetFontFaceAsync(new FontFaceParam
            {
                AccessKey = "xxx ",
                Content = "有字库，让中文跃上云端！异步",
                Tag = "#single-async-id1",
            }
            );

            //2.WOFF Base64格式（Tag可选）
            var response2 = await YouzikuClient.GetWoffBase64StringFontFaceAsync(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！异步",
                Tag = ".single-async-class1",
                UseRanFontFamily = true
            }
            );

            return null;
        }
    }
}
