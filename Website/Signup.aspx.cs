using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CryptSharp;

public partial class Signup : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var username = Request["username"];
        var password = Request["password"];
        var password2 = Request["password2"];

        if (username == null)
        {
            return;
        }

        // TODO: 检查用户名是否已存在，检查两次密码输入是否一致

        password = Crypter.Blowfish.Crypt(password);
        var user = new User();
        user.Username = username;
        user.Password = password;
        user.Email = "";
        user.Phone = "";
        user.Address = "";
        user.ZipCode = "";
        user.IsAdmin = false;

        database.Users.Add(user);

        Login(user);
        Response.Redirect("~/Index.aspx");
    }
}