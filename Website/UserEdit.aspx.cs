using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CryptSharp;

public partial class UserEdit : BasePage
{
    protected User user;

    protected bool signup;
    protected bool staff;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        bool signup = Request.Url.AbsolutePath.EndsWith("Signup.aspx");
        bool staff = Request.Url.AbsolutePath.EndsWith("StaffNew.aspx");

        if (!signup)
        {
            RequireLogin();
        }

        ctExtraInfo.Visible = !staff;

        var id = Util.TryToInt(Request["ID"]);
        user = database.Users.Where(c => c.ID == id).SingleOrDefault();
        user = user ?? new User();

        if (Request.HttpMethod == "POST")
        {
            var password = Request["password"];
            var password2 = Request["password2"];
            // TODO: 检查用户名是否已存在，检查两次密码输入是否一致

            password = Crypter.Blowfish.Crypt(password);
            user.Username = Request["username"];
            user.Password = password;
            user.Email = Request["email"] ?? "";
            user.Phone = Request["phone"] ?? "";
            user.Address = Request["address"] ?? "";
            user.ZipCode = Request["zip-code"] ?? "";
            user.IsAdmin = staff;

            if (user.ID == 0)
            {
                database.Users.Add(user);
                database.SaveChanges();
            }

            if (signup)
            {
                Login(user);
                Response.Redirect("~/Index.aspx");
            }
            else if (staff)
            {
                Response.Redirect("~/Index.aspx");
            }
            else
            {
                Response.Redirect("~/User.aspx?ID=" + user.ID.ToString());
            }
        }
    }
}