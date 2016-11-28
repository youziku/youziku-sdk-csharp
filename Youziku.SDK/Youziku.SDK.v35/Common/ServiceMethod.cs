

namespace Youziku.Common
{
    /// <summary>
    /// 接口方法
    /// </summary>
    public static class ServiceMethod
    {


        /// <summary>
        /// WebFont,单标签生成方法名
        /// @author:jamesbing
        /// </summary>
        public class WebFont
        {
            /// <summary>
            /// 接口方法GetFontFace()
            /// </summary>
            public const string GetFontface = "/webFont/getFontFace";


            /// <summary>
            /// 接口方法GetWoffBase64StringFontFace()
            /// </summary>
            public const string GetWoffBase64StringFontFace = "/webFont/getWoffBase64StringFontFace";
        }



        /// <summary>
        /// batchWebFont,多标签生成方法名
        /// @author:jamesbing
        /// </summary>
        public class BatchWebFont
        {
            /// <summary>
            /// 接口方法GetBatchFontFace()
            /// </summary>
            public const string GetBatchFontFace = "/batchWebFont/getBatchFontFace";


            /// <summary>
            /// 接口方法GetBatchWoffFontFace()
            /// </summary>
            public const string GetBatchWoffFontFace = "/batchWebFont/getBatchWoffFontFace";
        }



        /// <summary>
        ///CustomPath 自定义路径接口
        /// @author:jamesbing
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
