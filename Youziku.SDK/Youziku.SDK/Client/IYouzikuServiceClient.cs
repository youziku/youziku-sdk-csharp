﻿
using System.Threading.Tasks;
using Youziku.Param;
using Youziku.Param.Batch;
using Youziku.Result;

namespace Youziku.Client
{
    /// <summary>
    /// 有字库service接口客户端
    /// @author:jamesbing
    /// </summary>
    public interface IYouzikuServiceClient
    {
        #region Single

        #region +GetFontFace 请求GetFontFace接口
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        FontFaceResult GetFontFace(FontFaceParam param);
        #endregion

        #region +GetFontFaceAsync 请求GetFontFace接口[Async]
        /// <summary>
        ///异步请求GetFontFace接口 [Async]
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        Task<FontFaceResult> GetFontFaceAsync(FontFaceParam param);
        #endregion

        #region GetWoffBase64StringFontFace

        #region +GetWoffBase64StringFontFace 请求GetWoffBase64StringFontFace接口
        /// <summary>
        /// 请求GetWoffBase64StringFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        FontFaceResult GetWoffBase64StringFontFace(FontFaceParam param);
        #endregion

        #region +GetWoffBase64StringFontFaceAsync 请求GetWoffBase64StringFontFace接口[Async]
        /// <summary>
        /// 异步请求GetWoffBase64StringFontFace接口 [Async]
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        Task<FontFaceResult> GetWoffBase64StringFontFaceAsync(FontFaceParam param);
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
        BatchFontFaceResult GetBatchFontFace(BatchFontFaceParam param);
        #endregion

        #region +GetBatchFontFaceAsync 多标签生成式,可传递多个标签和内容一次生成多个@fontface [Async]
        /// <summary>
        /// 异步多标签生成模式,可传递多个标签和内容一次生成多个@fontface [Async]
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        Task<BatchFontFaceResult> GetBatchFontFaceAsync(BatchFontFaceParam param);
        #endregion

        #region +GetBatchWoffFontFace 多标签生成式,可传递多个标签和内容一次生成多个@fontface
        /// <summary>
        /// 多标签生成模式,直接返回仅woff格式的@fontface
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        BatchFontFaceResult GetBatchWoffFontFace(BatchFontFaceParam param);
        #endregion

        #region +GetBatchWoffFontFaceAsync 多标签生成式,可传递多个标签和内容一次生成多个@fontface [Async]
        /// <summary>
        /// 异步多标签生成模式,直接返回仅woff格式的@fontface [Async]
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        Task<BatchFontFaceResult> GetBatchWoffFontFaceAsync(BatchFontFaceParam param);
        #endregion

        #endregion

        #region CustomPath

        #region +GetCustomPathBatchWoffWebFont 请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        BatchCustomPathFontFaceResult GetCustomPathBatchWoffWebFont(BatchCustomPathWoffFontFaceParam param);

        #endregion

        #region +GetCustomPathBatchWoffWebFont 异步请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///异步请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        Task<BatchCustomPathFontFaceResult> GetCustomPathBatchWoffWebFontAsync(BatchCustomPathWoffFontFaceParam param);

        #endregion

        #region +GetCustomPathBatchWebFont 请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        BatchCustomPathFontFaceResult GetCustomPathBatchWebFont(BatchCustomPathWoffFontFaceParam param);

        #endregion

        #region +GetCustomPathBatchWebFontAsync 异步请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///异步请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        Task<BatchCustomPathFontFaceResult> GetCustomPathBatchWebFontAsync(BatchCustomPathWoffFontFaceParam param);

        #endregion

        #endregion
    }
}
