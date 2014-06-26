using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CryptSharp;

public partial class Password : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RequireLogin();

        if (Request.HttpMethod == "POST")
        {
            var password0 = Request["password0"];
            var password = Request["password"];
            var password2 = Request["password2"];

            if (!Crypter.CheckPassword(password0, currentUser.Password))
            {
                ShowMessage("原密码错误");
            }
            if (password != password2)
            {
                ShowMessage("两次密码输入不一致");
            }

            var user = database.Users.Where(u => u.ID == currentUser.ID).Single();
            user.Password = Crypter.Blowfish.Crypt(password);

            Login(user);

            ShowMessage("密码修改成功");
        }
    }
}