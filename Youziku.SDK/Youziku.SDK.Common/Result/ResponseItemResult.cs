 

namespace Youziku.Result
{

    /// <summary>
    /// 通用响应结果
    /// @author:jamesbing
    /// </summary>
    public class ResponseItemResult
    {
        /// <summary>
        /// 系统生成的FontFamily
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// 标签(与提交的参数对应)
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 标签对应的@fontface语句
        /// </summary>
        public string FontFace { get; set; }
    }
}
