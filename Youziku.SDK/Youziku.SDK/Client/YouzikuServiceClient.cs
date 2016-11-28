using System;
using System.Threading.Tasks;
using Youziku.Builder;
using Youziku.Common;
using Youziku.Core;
using Youziku.Param;
using Youziku.Param.Batch;
using Youziku.Result;
using Youziku.Settings;
namespace Youziku.Client
{
    /// <summary>
    ///有字库service接口客户端
    /// @author:jamesbing
    /// </summary>
    public class YouzikuServiceClient : BaseServiceClient, IYouzikuServiceClient
    {
        #region YouzikuConfig

        /// <summary>
        /// YouzikuConfig
        /// </summary>
        private YouzikuConfig _config;
        #endregion

        #region 初始化请求类库实例
        /// <summary>
        /// 初始化请求类库实例
        /// </summary>
        /// <param name="config">config</param>
        private void InitRequestInstance(YouzikuConfig config)
        {
            switch (config.RequestBehavior)
            {
                case RequestBehaviorEnum.HttpClient:
                    HttpRequestClient = new THttpClient();
                    break;
                case RequestBehaviorEnum.HttpWebRequest:
                    HttpRequestClient = new TWebRequest();
                    break;
                default:
                    HttpRequestClient = new TWebRequest();
                    break;
            }
        } 
        #endregion

        #region 构造一个YouzikuClient
        /// <summary>
        /// 构造一个YouzikuClient
        /// </summary>
        /// <param name="config">config</param>
        public YouzikuServiceClient(YouzikuConfig config)
        {
            if (config == null) throw new ArgumentException(nameof(YouzikuConfig) + " instance is null!");
            if (string.IsNullOrWhiteSpace(config.Host)) throw new ArgumentException(nameof(YouzikuConfig) + " field Url is null or Empty!");
            if (string.IsNullOrWhiteSpace(config.ApiKey)) throw new ArgumentException(nameof(YouzikuConfig) + " field ApiKey is null or Empty!");
            this._config = config;
            InitRequestInstance(config);
        }
        #endregion

        #region 构造一个YouzikuClient
        /// <summary>
        /// 构造一个YouzikuClient
        /// </summary>
        /// <param name="apiKey">apiKey</param>
        /// <param name="host">host</param>
        public YouzikuServiceClient(string apiKey,string host= "http://service.youziku.com")
        {
            if (string.IsNullOrWhiteSpace(host)) throw new ArgumentException(nameof(YouzikuConfig) + " field host is null or Empty!");
            if (string.IsNullOrWhiteSpace(apiKey)) throw new ArgumentException(nameof(YouzikuConfig) + " field ApiKey is null or Empty!");
            this._config = new YouzikuConfig { Host = host.Trim(), ApiKey = apiKey.Trim() };
            InitRequestInstance(this._config);
        }
        #endregion

        #region GetFontFace

        #region +GetFontFace 请求GetFontFace接口
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public FontFaceResult GetFontFace(FontFaceParam param)
        {
            var paramDic = ParamBuilder.GetFontface(param, _config);
            return CommonGetFontFace<FontFaceResult>(paramDic, _config.Host + ServiceMethod.WebFont.GetFontface, _config);
        }
        #endregion

        #region +GetFontFace 请求GetFontFace接口[Async]
        /// <summary>
        ///异步请求GetFontFace接口 [Async]
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public Task<FontFaceResult> GetFontFaceAsync(FontFaceParam param)
        {
            var paramDic = ParamBuilder.GetFontface(param, _config);
            return CommonGetFontFaceAsync<FontFaceResult>(paramDic, _config.Host + ServiceMethod.WebFont.GetFontface, _config);
        }

        #endregion

        #endregion

        #region GetWoffBase64StringFontFace

        #region +GetWoffBase64StringFontFace 请求GetWoffBase64StringFontFace接口
        /// <summary>
        /// 请求GetWoffBase64StringFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public FontFaceResult GetWoffBase64StringFontFace(FontFaceParam param)
        {
            var paramDic = ParamBuilder.GetFontface(param, _config);
            return CommonGetFontFace<FontFaceResult>(paramDic, _config.Host + ServiceMethod.WebFont.GetWoffBase64StringFontFace, _config);
        }
        #endregion

        #region +GetWoffBase64StringFontFaceAsync 请求GetWoffBase64StringFontFace接口[Async]
        /// <summary>
        /// 异步请求GetWoffBase64StringFontFace接口 [Async]
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        public Task<FontFaceResult> GetWoffBase64StringFontFaceAsync(FontFaceParam param)
        {
            var paramDic = ParamBuilder.GetFontface(param, _config);
            return CommonGetFontFaceAsync<FontFaceResult>(paramDic, _config.Host + ServiceMethod.WebFont.GetWoffBase64StringFontFace, _config);
        }

        #endregion

        #endregion

        #region GetBatchFontFace

        #region +GetBatchFontFace 多标签生成式,可传递多个标签和内容一次生成多个@fontface
        /// <summary>
        /// 多标签生成模式,可传递多个标签和内容一次生成多个@fontface
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public BatchFontFaceResult GetBatchFontFace(BatchFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetBatchFontFace(param, _config);
            return CommonGetFontFace<BatchFontFaceResult>(paramDic, _config.Host + ServiceMethod.BatchWebFont.GetBatchFontFace, _config);
        }
        #endregion

        #region +GetBatchFontFaceAsync 多标签生成式,可传递多个标签和内容一次生成多个@fontface [Async]
        /// <summary>
        /// 异步请求多标签生成模式,可传递多个标签和内容一次生成多个@fontface [Async]
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public Task<BatchFontFaceResult> GetBatchFontFaceAsync(BatchFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetBatchFontFace(param, _config);
            return CommonGetFontFaceAsync<BatchFontFaceResult>(paramDic, _config.Host + ServiceMethod.BatchWebFont.GetBatchFontFace, _config);
        }


        #endregion

        #region +GetBatchWoffFontFace 多标签生成式,可传递多个标签和内容一次生成多个@fontface

        /// <summary>
        /// 多标签生成模式,直接返回仅woff格式的@fontface
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public BatchFontFaceResult GetBatchWoffFontFace(BatchFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetBatchFontFace(param, _config);
            return CommonGetFontFace<BatchFontFaceResult>(paramDic, _config.Host + ServiceMethod.BatchWebFont.GetBatchWoffFontFace, _config);
        }
        #endregion

        #region +GetBatchWoffFontFaceAsync 多标签生成式,可传递多个标签和内容一次生成多个@fontface [Async]

        /// <summary>
        /// 异步多标签生成模式,直接返回仅woff格式的@fontface [Async]
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public Task<BatchFontFaceResult> GetBatchWoffFontFaceAsync(BatchFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetBatchFontFace(param, _config);
            return CommonGetFontFaceAsync<BatchFontFaceResult>(paramDic, _config.Host + ServiceMethod.BatchWebFont.GetBatchWoffFontFace, _config);
        }
        #endregion

        #endregion

        #region GetCustomPathBatchWoffWebFont

        #region +GetCustomPathBatchWoffWebFont 请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public BatchCustomPathWoffFontFaceResult GetCustomPathBatchWoffWebFont(BatchCustomPathWoffFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetCustomPathBatchWoffWebFont(param, _config);
            return CommonGetFontFace<BatchCustomPathWoffFontFaceResult>(paramDic, _config.Host + ServiceMethod.CustomPath.CreateBatchWoffWebFont, _config);
        }

        #endregion

        #region +GetCustomPathBatchWoffWebFontAsync 异步请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///异步请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>

        public Task<BatchCustomPathWoffFontFaceResult> GetCustomPathBatchWoffWebFontAsync(BatchCustomPathWoffFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetCustomPathBatchWoffWebFont(param, _config);
            return CommonGetFontFaceAsync<BatchCustomPathWoffFontFaceResult>(paramDic, _config.Host + ServiceMethod.CustomPath.CreateBatchWoffWebFont, _config);
        }

        #endregion

        #endregion
    }
}
