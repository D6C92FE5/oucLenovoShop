using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ItemDelete : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var id = Util.TryToInt(Request["ID"]);
        var item = database.Computers.Where(c => c.ID == id).SingleOrDefault();
        if (item != null)
        {
            item.IsDeleted = true;
        }

        Response.Redirect("~/Index.aspx");
    }
}