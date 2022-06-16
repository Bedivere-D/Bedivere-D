using Killy.K3.Demo.Constracts;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;

namespace Killy.K3.Demo.App.Core
{
    public class SaleService:ISaleService
    {
        public string CheckOutStock(Context ctx,List<long> orgId)
        {
            return "Hello World!";
        }
    }
}
