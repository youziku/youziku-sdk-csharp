using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Youziku.Core
{
    /// <summary>
    /// WebRequest模式 请求Http
    /// @author:Jamesbing
    /// </summary>
    public class TWebRequest : HttpRequestClient
    {
        #region+Request 发送一个普通的web请求，带解压Gzip [同步]

        /// <summary>
        /// 发送一个普通的web请求，带解压Gzip [同步]
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="method">GET、POST</param>
        /// <param name="param">参数集合,传null表示没有参数</param>
        /// <param name="timeout">请求超时时间</param>
        /// <returns>结果</returns>
        public override string Request(string url, string method, IDictionary<string, string> param, int timeout)
        {
            var r = System.Net.WebRequest.Create(url);
            r.Timeout = timeout * 1000 * 60;
            r.Method = method;
            r.Headers.Add("Accept-Encoding", "gzip, deflate");
            if (method == THttpMethod.Post)
            {
                r.ContentType = "application/x-www-form-urlencoded";
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
                using (var reqs = r.GetRequestStream())
                {
                    if (param != null)
                    {
                        var bytes2 = Encoding.UTF8.GetBytes(sb.ToString());
                        reqs.Write(bytes2, 0, bytes2.Length);
                    }

                }
                sb.Clear();
                sb = null;
            }
            var res = (HttpWebResponse)r.GetResponse();
            var charset = res.CharacterSet;
            if (charset == null)
            {
                charset = "utf-8";
            }

            var reEncode = Encoding.GetEncoding(charset);
            //jsonresult
            var jsonresult = string.Empty;
            using (var s = res.GetResponseStream())
            {
                if (string.IsNullOrWhiteSpace(res.ContentEncoding))
                {
                    jsonresult = GetData(s, reEncode);

                }
                else if (res.ContentEncoding == "gzip")
                {

                    //Gzip解压
                    var gzip = new GZipStream(s, CompressionMode.Decompress);
                    jsonresult = GetData(gzip, reEncode);
                }
                else if (res.ContentEncoding == "deflate")
                {

                    //Deflate解压
                    var gzip = new DeflateStream(s, CompressionMode.Decompress);
                    jsonresult = GetData(gzip, reEncode);
                }

            }
            res?.Dispose();
            param?.Clear();
            param = null;
            return jsonresult;
        }


        #endregion

        #region+RequestAsync 发送一个普通的web请求，带解压Gzip [异步]

        /// <summary>
        /// 发送一个普通的web请求，带解压Gzip [异步]
        /// </summary>
        /// <param name="url">url</param>
        /// <param name="method">GET、POST</param>
        /// <param name="param">参数集合,传null表示没有参数</param>
        /// <param name="timeout">请求超时时间</param>
        /// <returns>结果</returns>
        public override async Task<string> RequestAsync(string url, string method, IDictionary<string, string> param, int timeout)
        {
            var r = System.Net.WebRequest.Create(url);
            r.Timeout = timeout * 1000 * 60;
            r.Method = method;
            r.Headers.Add("Accept-Encoding", "gzip, deflate");
            if (method == THttpMethod.Post)
            {
                r.ContentType = "application/x-www-form-urlencoded";
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

                using (var reqs = await r.GetRequestStreamAsync())
                {
                    if (param != null)
                    {
                        var bytes2 = Encoding.UTF8.GetBytes(sb.ToString());
                        reqs.Write(bytes2, 0, bytes2.Length);
                    }
                }
                sb.Clear();
                sb = null;
            }

            var res = (HttpWebResponse)await r.GetResponseAsync();
            var charset = res.CharacterSet;
            if (charset == null)
            {
                charset = "utf-8";
            }

            var reEncode = Encoding.GetEncoding(charset);
            //jsonresult
            var jsonresult = string.Empty;
            using (var s = res.GetResponseStream())
            {
                if (string.IsNullOrWhiteSpace(res.ContentEncoding))
                {
                    jsonresult = GetData(s, reEncode);

                }
                else if (res.ContentEncoding == "gzip")
                {

                    //Gzip解压
                    var gzip = new GZipStream(s, CompressionMode.Decompress);
                    jsonresult = GetData(gzip, reEncode);
                }
                else if (res.ContentEncoding == "deflate")
                {

                    //Deflate解压
                    var gzip = new DeflateStream(s, CompressionMode.Decompress);
                    jsonresult = GetData(gzip, reEncode);
                }

            }
            res?.Dispose();
            param?.Clear();
            param = null;
            return jsonresult;
        }


        #endregion

        #region 响应解析数据流
        /// <summary>
        /// 响应解析数据流
        /// </summary>
        /// <param name="s">响应流</param>
        /// <param name="reEncode">编码</param>
        /// <returns></returns>
        private static string GetData(Stream s, Encoding reEncode)
        {
            if (s == null) return string.Empty;
            using (var sw = new StreamReader(s, reEncode))
            {
                var json = sw.ReadToEnd();
                s.Flush();
                s.Dispose();
                return json;
            }
        }
        #endregion
    }
}
