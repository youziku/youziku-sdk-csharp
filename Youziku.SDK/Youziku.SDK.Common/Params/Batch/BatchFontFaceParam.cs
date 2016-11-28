using System.Collections.Generic;

namespace Youziku.Param.Batch
{
    /// <summary>
    /// 多标签生成模式 请求参数
    /// @author:jamesbing
    /// </summary>
    public class BatchFontFaceParam
    {
        /// <summary>
        /// 标签+内容的集合
        /// </summary>
        public IList<FontFaceParam> Tags = new List<FontFaceParam>();

    }
}
