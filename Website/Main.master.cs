using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var currentUser = Session["user"] as User;
        var isStaff = currentUser != null && currentUser.IsAdmin;
        var isCustomer = currentUser != null && !currentUser.IsAdmin;

        ctNavCustomer.Visible = isCustomer;
        ctNavStaff.Visible = isStaff;
        ctStaffNew.Visible = isStaff;
        ctCurrentUser.Visible = currentUser != null;
        ctUserInfo.Visible = isCustomer;
        ctAuth.Visible = currentUser == null;
        if (currentUser != null)
        {
            ctUsername.Text = currentUser.Username;
        }
    }
}
