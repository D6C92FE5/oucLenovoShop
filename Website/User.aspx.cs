using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_ : BasePage
{
    protected User user;

    protected void Page_Load(object sender, EventArgs e)
    {
        RequireStaff();
        
        var id = Util.TryToInt(Request["ID"]);
        user = database.Users.Where(c => c.ID == id).SingleOrDefault();
        user = user ?? new User();
    }
}