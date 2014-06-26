using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderNew : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RequireCustomer();
        
        if (currentUser == null)  // TODO: 管理员不能下订单
        {
            Response.Redirect("~/Login.aspx");
            return;
        }

        var itemID = Util.TryToInt(Request["ItemID"]);
        // 检测无效 Item ID

        var order = new Order();
        order.UserID = currentUser.ID;
        order.ComputerID = itemID;
        order.Date = DateTime.Now;

        database.Orders.Add(order);

        Response.Redirect("~/Order.aspx");
    }
}