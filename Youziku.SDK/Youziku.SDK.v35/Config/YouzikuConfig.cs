
using Youziku.Common;

namespace Youziku.Settings
{
    /// <summary>
    /// YouzikuConfig
    /// @author:jamesbing
    /// </summary>
    public class YouzikuConfig : RequestBaseParam
    {
        /// <summary>
        /// 配置接口地址
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// 配置发送请求超时时间[单位：分钟]，默认5分钟
        /// </summary>
        public int TimeOut { get; set; } = 5;

    }

}
