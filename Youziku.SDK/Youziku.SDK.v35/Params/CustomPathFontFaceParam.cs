 

namespace Youziku.Param
{
    public class CustomPathFontFaceParam
    {
        /// <summary>
        /// 自定义存储目录路径。不允许传递文件扩展名,格式：root/dir/filename，重复将被覆盖，用户需要自己确认唯一性
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 要生成字体的文字内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 系统规定参数，从有字库字体使用页中"卢教"模式中获取，$youziku.load 语句中第2个参数即为AccessKey。
        /// </summary>
        public string AccessKey { get; set; }
    }
}
