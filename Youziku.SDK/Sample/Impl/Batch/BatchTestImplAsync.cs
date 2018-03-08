using System.Threading.Tasks;
using Youziku.Param;
using Youziku.Param.Batch;

namespace Youziku.Test.Util.Impl.Batch
{
    class BatchTestImplAsync : BaseTestImpl, IInterfaceTestAsync
    {
        public async Task<dynamic> Run(dynamic p = null)
        {
            //构建一个请求参数
            var param = new BatchFontFaceParam();

            //开始构建生成项,Tag必填
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！异步",
                Tag = "#batch-async-id1",
                UseRanFontFamily = true
            });
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "e8e8a75c24aa4ac3a9fd5995abe624a8",
                Content = "有字库，让中文跃上云端！异步",
                Tag = "#batch-async-id2",
            });


            //1.全格式
            var response3 = await YouzikuClient.GetBatchFontFaceAsync(param);

            //2.WOFF格式
            var response4 = await YouzikuClient.GetBatchWoffFontFaceAsync(param);

            return null;
        }
    }
}
