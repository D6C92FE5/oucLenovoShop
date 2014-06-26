using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CryptSharp;

public partial class Login : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var username = Request["username"];
        var password = Request["password"];

        if (username == null)
        {
            if (currentUser != null)
            {
                Response.Redirect("~/Index.aspx");
                return;
            }
            
            return;
        }

        var user = database.Users.Where(u => u.Username == username).SingleOrDefault();
        if (user == null || !Crypter.CheckPassword(password, user.Password))
        {
            ctMessage.Text = "用户名或密码错误";
            return;
        }

        Login(user);
        Response.Redirect("~/Index.aspx");
    }
}