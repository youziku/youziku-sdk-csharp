using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youziku.Result
{
    /// <summary>
    /// 多标签生成模式 响应参数
    /// @author:jamesbing
    /// </summary>
    public class BatchFontFaceResult
    {

        /// <summary>
        /// 状态码
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 标签和对应的@fontface语句集合
        /// </summary>
        public IList<ResponseItemResult> FontfaceList { get; set; }

    }
}
