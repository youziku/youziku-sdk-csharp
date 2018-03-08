using System;
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

        /// <summary>
        /// 初始化请求类库实例
        /// </summary>
        private void InitRequestInstance()
        {
            HttpRequestClient = new TWebRequest();
        }

        #region 构造一个YouzikuClient
        /// <summary>
        /// 构造一个YouzikuClient
        /// </summary>
        /// <param name="config">config</param>
        public YouzikuServiceClient(YouzikuConfig config)
        {
            if (config == null) throw new ArgumentException(nameof(YouzikuConfig) + " instance is null!");
            if (string.IsNullOrEmpty(config.Host)) throw new ArgumentException(nameof(YouzikuConfig) + " field Url is null or Empty!");
            if (string.IsNullOrEmpty(config.ApiKey)) throw new ArgumentException(nameof(YouzikuConfig) + " field ApiKey is null or Empty!");
            this._config = config;
            InitRequestInstance();
        }
        #endregion

        #region 构造一个YouzikuClient
        /// <summary>
        /// 构造一个YouzikuClient
        /// </summary>
        /// <param name="apiKey">apiKey</param>
        /// <param name="host">host</param>
        public YouzikuServiceClient(string apiKey, string host = "http://service.youziku.com")
        {
            if (string.IsNullOrEmpty(host)) throw new ArgumentException(nameof(YouzikuConfig) + " field host is null or Empty!");
            if (string.IsNullOrEmpty(apiKey)) throw new ArgumentException(nameof(YouzikuConfig) + " field ApiKey is null or Empty!");
            this._config = new YouzikuConfig { Host = host.Trim(), ApiKey = apiKey.Trim() };
            InitRequestInstance();
        }
        #endregion

        #region Single

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

        #endregion

        #endregion

        #region Batch

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

        #endregion

        #region CustomPath

        #region +GetCustomPathBatchWoffWebFont 请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public BatchCustomPathFontFaceResult GetCustomPathBatchWoffWebFont(BatchCustomPathWoffFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetCustomPathFontFace(param, _config);
            return CommonGetFontFace<BatchCustomPathFontFaceResult>(paramDic, _config.Host + ServiceMethod.CustomPath.CreateBatchWoffWebFont, _config);
        }

        #endregion

        #region +GetCustomPathBatchWebFont 请求 自定义路径接口；该接口底层实现为异步

        /// <summary>
        ///请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        public BatchCustomPathFontFaceResult GetCustomPathBatchWebFont(BatchCustomPathWoffFontFaceParam param)
        {
            var paramDic = ParamBuilder.GetCustomPathFontFace(param, _config);
            return CommonGetFontFace<BatchCustomPathFontFaceResult>(paramDic, _config.Host + ServiceMethod.CustomPath.CreateBatchWebFont, _config);
        }

        #endregion

        #endregion
    }
}
