using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Youziku.Param.Batch
{
    /// <summary>
    /// 传递多个自定义路径和内容 请求参数
    /// @author:jamesbing
    /// </summary>
    public class BatchCustomPathWoffFontFaceParam
    {
        /// <summary>
        /// 标签内容的集合
        /// </summary>
        public IList<CustomPathFontFaceParam> Datas = new List<CustomPathFontFaceParam>();
    }
}
