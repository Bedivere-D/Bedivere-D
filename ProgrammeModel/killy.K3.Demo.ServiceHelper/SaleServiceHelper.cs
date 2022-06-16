using Killy.K3.Demo.Constracts;
using Kingdee.BOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace killy.K3.Demo.ServiceHelper
{
    public class SaleServiceHelper
    {
        public static string CheckOutStock(Context ctx,List<long> orgId)
        {
            ISaleService service = ServiceFactory.GetService<ISaleService>(ctx);
            string result = "";
            try
            {
                result = service.CheckOutStock(ctx,orgId);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                ServiceFactory.CloseService(service);
            }
            return result;
        }
    }
}
