using Killy.K3.Demo.Constracts;
using Kingdee.BOS;
using System.Collections.Generic;

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
