

namespace Youziku.Result
{
    /// <summary>
    /// 单标签模式 响应参数
    /// @author:jamesbing
    /// </summary>
    public class FontFaceResult : ResponseItemResult
    {

        /// <summary>
        /// 状态码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string ErrorMessage { get; set; }

    }
}
