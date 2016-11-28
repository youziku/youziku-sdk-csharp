using System;
using System.Collections.Generic;

using Youziku.Param;
using Youziku.Param.Batch;
using Youziku.Settings;
using Youziku.Validate;

namespace Youziku.Builder
{
    /// <summary>
    /// 请求参数构造器
    /// @author:jamesbing
    /// </summary>
    public class ParamBuilder
    {
        #region + GetFontface 
        /// <summary>
        /// GetFontface接口
        /// </summary>
        /// <param name="param">param</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        public static IDictionary<string, string> GetFontface(FontFaceParam param, YouzikuConfig config)
        {
            ParamValidate.GetFontface(param);
            var paramDic = new Dictionary<string, string>
                {
                    {"ApiKey", config.ApiKey},
                    {"AccessKey", param.AccessKey},
                    {"Content", param.Content},
                    {"Tag", param.Tag}
                };
            return paramDic;
        }
        #endregion

        #region + GetBatchFontFace 
        /// <summary>
        /// GetBatchFontFace接口
        /// </summary>
        /// <param name="param">param</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        public static IDictionary<string, string> GetBatchFontFace(BatchFontFaceParam param, YouzikuConfig config)
        {
            ParamValidate.GetBatchFontFace(param);
            //builder batch param
            var paramDic = new Dictionary<string, string>
                {
                    {"ApiKey", config.ApiKey}
                };

            for (var i = 0; i < param.Tags.Count; i++)
            {
                paramDic.Add($"Tags[{i}][AccessKey]", param.Tags[i].AccessKey);
                paramDic.Add($"Tags[{i}][Tag]", param.Tags[i].Tag);
                paramDic.Add($"Tags[{i}][Content]", param.Tags[i].Content);
            }

            return paramDic;
        }
        #endregion

        #region + GetCustomPathBatchWoffWebFont
        /// <summary>
        /// CreateBatchWoffWebFontAsync 自定义路径接口
        /// </summary>
        /// <param name="param">param</param>
        /// <param name="config">config</param>
        /// <returns></returns>
        public static IDictionary<string, string> GetCustomPathBatchWoffWebFont(BatchCustomPathWoffFontFaceParam param, YouzikuConfig config)
        {
            ParamValidate.CreateCustomPathBatchWoffWebFont(param);
            //builder batch param
            var paramDic = new Dictionary<string, string>
                {
                    {"ApiKey", config.ApiKey}
                };

            for (var i = 0; i < param.Datas.Count; i++)
            {
                paramDic.Add($"Datas[{i}][AccessKey]", param.Datas[i].AccessKey);
                paramDic.Add($"Datas[{i}][Url]", param.Datas[i].Url);
                paramDic.Add($"Datas[{i}][Content]", param.Datas[i].Content);
            }

            return paramDic;
        }
        #endregion
    }
}
