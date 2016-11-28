using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using Youziku.Core;
using Youziku.Settings;


namespace Youziku.Client
{
    public class BaseServiceClient
    {

        /// <summary>
        /// 发起Http请求类库
        /// </summary>
        public HttpRequestClient HttpRequestClient { get; set; }

        #region +CommonGetFontFace 通用请求GetFontFace
        /// <summary>
        /// 通用请求GetFontFace
        /// </summary>
        /// <param name="paramDic">请求参数</param>
        /// <param name="url">接口路径</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        protected TResult CommonGetFontFace<TResult>(IDictionary<string, string> paramDic, string url, YouzikuConfig config) where TResult : class, new()
        {
            try
            {
             
                var jsonResult = HttpRequestClient.Request(url, THttpMethod.Post, paramDic, config.TimeOut);
                if (string.IsNullOrEmpty(jsonResult)) throw new ArgumentException("接口响应null或Empty!");
                return new JavaScriptSerializer().Deserialize<TResult>(jsonResult);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        
    }
}
