using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Youziku.SDK.Config
{
    public class YouzikuGlobal
    {
        private YouzikuGlobal()
        {

        }
        public static readonly YouzikuGlobal Config = new YouzikuGlobal();

        #region+UseHttps  启动Https
        /// <summary>
        /// 启动Https
        /// </summary>
        public YouzikuGlobal UseHttps()
        {
            //https配置
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            ServicePointManager.ServerCertificateValidationCallback =
                (sender, certificate, chain, errors) => true;
            return this;
        }
        #endregion
    }
}
