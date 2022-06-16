using Kingdee.BOS;
using Kingdee.BOS.Rpc;
using Kingdee.BOS.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Killy.K3.Demo.Constracts
{
    [RpcServiceError]
    [ServiceContract]
    [Description("龙腾米业地磅单接口"), HotUpdate]
    public interface ISaleService
    {
        [OperationContract]
        [FaultContract(typeof(ServiceFault))]
        string CheckOutStock(Context ctx, List<long> orgId);
    }
}
