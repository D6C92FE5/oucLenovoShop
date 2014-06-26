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
        ctNavCustomer.Visible = currentUser != null && !currentUser.IsAdmin;
        ctNavStaff.Visible = currentUser != null && currentUser.IsAdmin;
        ctCurrentUser.Visible = currentUser != null;
        ctAuth.Visible = currentUser == null;
        if (currentUser != null)
        {
            ctUsername.Text = currentUser.Username;
        }
    }
}
