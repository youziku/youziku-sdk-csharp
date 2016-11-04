

namespace Youziku.Common
{
    /// <summary>
    /// 接口方法
    /// </summary>
    public static class ServiceMethod
    {
        /// <summary>
        /// 接口方法GetFontFace()
        /// </summary>
        public const string GetFontface = "/webFont/getFontFace";


        /// <summary>
        /// 接口方法GetWoffBase64StringFontFace()
        /// </summary>
        public const string GetWoffBase64StringFontFace = "/webFont/getWoffBase64StringFontFace";


        /// <summary>
        /// 接口方法GetBatchFontFace()
        /// </summary>
        public const string GetBatchFontFace = "/batchWebFont/getBatchFontFace";


        /// <summary>
        /// 自定义路径接口
        /// </summary>
        public class CustomPath
        {
            /// <summary>
            /// 接口方法CreateBatchWoffWebFontAsync()
            /// </summary>
            public const string CreateBatchWoffWebFont = "/batchCustomWebFont/createBatchWoffWebFontAsync";
        }
    }
}
