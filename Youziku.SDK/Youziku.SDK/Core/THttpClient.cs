using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
 

namespace Youziku.Core
{
    /// <summary>
    ///HttpClient方式 请求Http
    /// @author:Jamesbing
    /// </summary>
    public   class THttpClient: HttpRequestClient
    {

        #region+RequestAsync 异步发送一个普通的web请求，带解压Gzip [使用HttpClient请求]

        /// <summary>
        /// 异步发送一个普通的web请求，带解压Gzip [使用HttpClient请求]
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="method">GET、POST</param>
        /// <param name="param">参数集合,传null表示没有参数</param>
        /// <param name="timeout">请求超时时间（分钟）</param>
        /// <returns>结果</returns>
        public  override async Task<string> RequestAsync(string url, string method, IDictionary<string, string> param, int timeout)
        {

            HttpClient hc = new HttpClient(new HttpClientHandler {AutomaticDecompression = DecompressionMethods.GZip})
            {
                Timeout = new TimeSpan(0, 0, 0, 0, 1000*60*timeout)
            };
            hc.DefaultRequestHeaders.Connection.Add("keep-alive");
            HttpResponseMessage res = null;
            if (method == THttpMethod.Post)
            {
                res = await hc.PostAsync(url, new FormUrlEncodedContent(param));

            }
            else
            {
                var sb = new StringBuilder();
                if (param != null)
                {

                    var index = 0;
                    foreach (var key in param.Keys)
                    {
                        var value = param[key];
                        if (index >= param.Count - 1)
                        {
                            sb.Append(key + "=" + value);

                        }
                        else
                        {
                            sb.Append(key + "=" + value + "&");
                        }
                        index++;
                    }

                }
                res = await hc.GetAsync(url + "?" + sb);
                sb.Clear();
            }

            //jsonresult
            var jsonresult = await res.Content.ReadAsStringAsync();
            res.Dispose();
            hc.Dispose();
            param?.Clear();
            param = null;
            return jsonresult;
        }


        #endregion
    }
}
