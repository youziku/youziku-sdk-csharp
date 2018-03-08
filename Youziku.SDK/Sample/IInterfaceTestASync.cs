using System.Threading.Tasks;

namespace Youziku.Test.Util
{
    interface IInterfaceTestAsync
    {
        Task<dynamic> Run(dynamic param = null);
    }
}
