using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CryptSharp;

public partial class StaffNew : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RequireStaff();

        if (Request.HttpMethod == "POST")
        {
            var user = new User();

            var username = Request["username"];
            var password = Request["password"];
            var password2 = Request["password2"];

            if (database.Users.Where(u => u.Username == username).Count() > 0)
            {
                ShowMessage("用户名已被使用");
            }
            if (password != password2)
            {
                ShowMessage("两次密码输入不一致");
            }

            password = Crypter.Blowfish.Crypt(password);
            
            user.Username = username;
            user.Password = password;
            user.Email = "";
            user.Phone = "";
            user.Address = "";
            user.ZipCode = "";
            user.IsAdmin = true;

            database.Users.Add(user);

            ShowMessage("添加成功");
        }
    }
}