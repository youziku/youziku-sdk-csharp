using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Youziku.Client;

namespace Youziku.Test.Util
{
    class BaseTestImpl
    {
        protected static readonly IYouzikuServiceClient YouzikuClient =
            new YouzikuServiceClient(
                apiKey: "xxx "
               );
    }
}
