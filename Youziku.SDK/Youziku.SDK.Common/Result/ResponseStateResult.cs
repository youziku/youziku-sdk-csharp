

namespace Youziku.Result
{
    /// <summary>
    /// 通用响应状态结果
    /// @author:jamesbing
    /// </summary>
    public class ResponseStateResult
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
