using Youziku.Param;
using Youziku.Param.Batch;

namespace Youziku.Test.Util.Impl.CustomPath
{
    class CustomPathTestImpl : BaseTestImpl, IInterfaceTest
    {
        public object Run()
        {
            var cusParam = new BatchCustomPathWoffFontFaceParam();

            //开始构建生成项
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

            //全格式
            var response1 = YouzikuClient.GetCustomPathBatchWebFont(cusParam);

            //2.Woff格式
            var response2 = YouzikuClient.GetCustomPathBatchWoffWebFont(cusParam);


            return null;
        }
    }
}
