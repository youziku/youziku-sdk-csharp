
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

        /// <summary>
        /// 配置发送请求时所使用的类库;
        /// [异步]请求可支持两种方式发起Http请求 [HttpWebRequest , HttpClient];
        /// [同步]请求则只能使用HttpWebRequest类;
        /// 默认使用：HttpClient
        /// </summary>
        public RequestBehaviorEnum RequestBehavior { get; set; }
    }

    /// <summary>
    /// 请求可选的api方式
    /// @author:jamesbing
    /// </summary>
    public enum RequestBehaviorEnum
    {
        /// <summary>
        /// HttpWebRequest api
        /// </summary>
        HttpWebRequest,
        /// <summary>
        /// HttpClient api
        /// </summary>
        HttpClient
    }
}
