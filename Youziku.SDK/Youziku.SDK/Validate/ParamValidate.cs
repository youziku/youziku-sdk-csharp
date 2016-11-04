using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Param;
using Youziku.Param.Batch;

namespace Youziku.Validate
{
    public static class ParamValidate
    {
        #region  + static GetFontface
        /// <summary>
        /// 验证GetFontface接口
        /// </summary>
        /// <param name="param">请求参数</param>
        public static void GetFontface(FontFaceParam param)
        {
            if (param == null) throw new ArgumentException(nameof(FontFaceParam) + " instance is null!");
            if (string.IsNullOrWhiteSpace(param.AccessKey)) throw new ArgumentException(nameof(FontFaceParam) + " field AccessKey is null or Empty!");
            if (string.IsNullOrWhiteSpace(param.Content)) throw new ArgumentException(nameof(FontFaceParam) + " field Content is null or Empty!");
        }
        #endregion

        #region  + static GetBatchFontFace 
        /// <summary>
        /// 验证GetBatchFontFace接口
        /// </summary>
        /// <param name="param">请求参数</param>
        public static void GetBatchFontFace(BatchFontFaceParam param)
        {
            if (param == null) throw new ArgumentException(nameof(BatchFontFaceParam) + " instance is null!");
            if (param.Tags.Count<=0) throw new ArgumentException(nameof(BatchFontFaceParam) + " field Tags.Count<=0!");
        }
        #endregion

        #region  + static CreateCustomPathBatchWoffWebFont  
        /// <summary>
        /// 验证CreateBatchWoffWebFontAsync 自定义路径接口
        /// </summary>
        /// <param name="param">请求参数</param>
        public static void CreateCustomPathBatchWoffWebFont(BatchCustomPathWoffFontFaceParam param)
        {
            if (param == null) throw new ArgumentException(nameof(BatchCustomPathWoffFontFaceParam) + " instance is null!");
            if (param.Datas.Count <= 0) throw new ArgumentException(nameof(BatchCustomPathWoffFontFaceParam) + " field Datas.Count<=0!");
        }
        #endregion
    }
}
