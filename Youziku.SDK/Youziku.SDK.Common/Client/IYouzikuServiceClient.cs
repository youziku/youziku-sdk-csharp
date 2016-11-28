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
        #region GetFontFace

        #region +GetFontFace 请求GetFontFace接口
        /// <summary>
        /// 请求GetFontFace接口
        /// </summary>
        /// <param name="param">请求接口参数</param>
        /// <returns></returns>
        FontFaceResult GetFontFace(FontFaceParam param);
        #endregion
         
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

        #endregion

        #region GetBatchFontFace

        #region +GetBatchFontFace 多标签生成式,可传递多个标签和内容一次生成多个@fontface
        /// <summary>
        /// 多标签生成模式,可传递多个标签和内容一次生成多个@fontface
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        BatchFontFaceResult GetBatchFontFace(BatchFontFaceParam param);
        #endregion

        #region +GetBatchWoffFontFace 多标签生成式,可传递多个标签和内容一次生成多个@fontface
        /// <summary>
        /// 多标签生成模式,直接返回仅woff格式的@fontface
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        BatchFontFaceResult GetBatchWoffFontFace(BatchFontFaceParam param);
        #endregion

        #endregion

        #region GetCustomPathBatchWoffWebFont

        #region +GetCustomPathBatchWoffWebFont 请求 自定义路径接口；该接口底层实现为异步
        /// <summary>
        ///请求 自定义路径接口；该接口底层实现为异步
        /// </summary>
        /// <param name="param">请求参数</param>
        /// <returns></returns>
        BatchCustomPathWoffFontFaceResult GetCustomPathBatchWoffWebFont(BatchCustomPathWoffFontFaceParam param);

        #endregion

        #endregion
    }
}
