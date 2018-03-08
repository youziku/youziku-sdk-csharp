using Youziku.Param;
using Youziku.Param.Batch;

namespace Youziku.Test.Util.Impl.Batch
{
    class BatchTestImpl : BaseTestImpl, IInterfaceTest
    {
        public object Run()
        {
            //构建一个请求参数
            var param = new BatchFontFaceParam();

            //开始构建生成项,Tag必填
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = "#batch-id1",
                UseRanFontFamily = true
            });
            param.Tags.Add(new FontFaceParam
            {
                AccessKey = "xxx",
                Content = "有字库，让中文跃上云端！",
                Tag = ".batch-class1"
            });


            //1.全格式
           var response3 = YouzikuClient.GetBatchFontFace(param);

            //2.WOFF格式
            var response4 = YouzikuClient.GetBatchWoffFontFace(param);

            return null;
        }
    }
}
