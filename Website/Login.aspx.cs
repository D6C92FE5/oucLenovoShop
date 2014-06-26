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
        if (Request.HttpMethod == "POST")
        {
            var username = Request["username"];
            var password = Request["password"];

            var user = database.Users.Where(u => u.Username == username).SingleOrDefault();
            if (user == null || !Crypter.CheckPassword(password, user.Password))
            {
                ShowMessage("用户名或密码错误");
            }

            Login(user);
            Response.Redirect("~/Index.aspx");
        }
        else
        {
            if (currentUser != null)
            {
                Response.Redirect("~/Index.aspx");
            }
        }

    }
}