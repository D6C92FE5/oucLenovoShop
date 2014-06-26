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

        var isAdmin = currentUser != null && currentUser.IsAdmin;
        ctOperateUser.Visible = !item.IsDeleted && !isAdmin;
        ctOperateAdmin.Visible = !item.IsDeleted && isAdmin;
        ctDeleted.Visible = item.IsDeleted;
    }
}