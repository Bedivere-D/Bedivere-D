using Kingdee.BOS.Core.Bill.PlugIn;
using Kingdee.BOS.Core.DynamicForm.PlugIn.Args;

namespace Killy.K3.Demo.BusinessPlugIn
{
    public class SaleOrderEdit:AbstractBillPlugIn
    {
        public override void ButtonClick(ButtonClickEventArgs e)
        {
            base.ButtonClick(e);

            // 调用服务
            string strRes = killy.K3.Demo.ServiceHelper.SaleServiceHelper.CheckOutStock(this.Context,null);
        }
    }
}
