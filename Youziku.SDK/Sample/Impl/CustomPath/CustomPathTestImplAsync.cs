using System.Threading.Tasks;
using Youziku.Param;
using Youziku.Param.Batch;

namespace Youziku.Test.Util.Impl.CustomPath
{
    class CustomPathTestImplAsync : BaseTestImpl, IInterfaceTestAsync
    {
        public async Task<dynamic> Run(dynamic param = null)
        {
            var cusParam = new BatchCustomPathWoffFontFaceParam();

            //开始构建生成项
            cusParam.Datas.Add(new CustomPathFontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！异步",
                Url = "youziku/async/test-1"
            });
            cusParam.Datas.Add(new CustomPathFontFaceParam
            {
                AccessKey = "9a81f34c66f54248925999c330feec51 ",
                Content = "有字库，让中文跃上云端！异步",
                Url = "youziku/async/test-2"
            });

            //全格式
            var response1 = await YouzikuClient.GetCustomPathBatchWebFontAsync(cusParam);

            //2.Woff格式
            var response2 = await YouzikuClient.GetCustomPathBatchWoffWebFontAsync(cusParam);


            return null;
        }
    }
}
