using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youziku.Core
{
    /// <summary>
    /// 请求接口
    /// </summary>
    public abstract class HttpRequestClient
    {
        #region +Request 同步请求
        /// <summary>
        /// 同步请求
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="method">GET、POST</param>
        /// <param name="param">参数</param>
        /// <param name="timeout">超时时间；单位：分钟</param>
        /// <returns></returns>
        public virtual string Request(string url, string method, IDictionary<string, string> param, int timeout) { throw new NotImplementedException(); }

        #endregion

        #region +RequestAsync 异步请求
        /// <summary>
        /// 异步请求
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="method">GET、POST</param>
        /// <param name="param">参数</param>
        /// <param name="timeout">超时时间；单位：分钟</param>
        /// <returns></returns>
        public abstract Task<string> RequestAsync(string url, string method, IDictionary<string, string> param, int timeout);
        #endregion
    }
}
