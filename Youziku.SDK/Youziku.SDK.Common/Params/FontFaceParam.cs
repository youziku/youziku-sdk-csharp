

namespace Youziku.Param
{
    /// <summary>
    /// 单标签模式 请求参数
    /// @author:jamesbing
    /// </summary>
    public class FontFaceParam 
    {
        /// <summary>
        /// 系统规定参数，从有字库字体使用页中"卢教"模式中获取，$youziku.load 语句中第2个参数即为AccessKey。
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// 生成内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        public string Tag { get; set; }
    }
}
