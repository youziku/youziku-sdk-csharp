using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Youziku.Client;

namespace Youziku.Test.Util.Impl
{
    class BaseTestImpl
    {
        protected static readonly IYouzikuServiceClient YouzikuClient = 
            new YouzikuServiceClient(
                apiKey: "xxx "
             );
    }
}
