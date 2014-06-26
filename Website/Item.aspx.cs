using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Item : BasePage
{
    protected Computer item;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        var id = Util.TryToInt(Request["ID"]);
        item = database.Computers.Where(c => c.ID == id).SingleOrDefault();
        item = item ?? new Computer();

        ctOperateUser.Visible = !item.IsDeleted && !isStaff;
        ctOperateAdmin.Visible = !item.IsDeleted && isStaff;
        ctDeleted.Visible = item.IsDeleted;
    }
}