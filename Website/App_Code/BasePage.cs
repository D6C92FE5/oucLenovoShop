using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class BasePage : System.Web.UI.Page
{
    protected Entities database = new Entities();

    protected User currentUser;
    protected int currentUserID;
    protected bool isStaff;
    protected bool isCustomer;

    protected void ShowMessage(string message)
    {
        Context.Items["Message"] = message;
        Server.Transfer("~/Message.aspx");
    }
    
    protected void Login(User user)
    {
        Session["user"] = user;
        var cookie = Response.Cookies["User"];
        cookie["ID"] = user.ID.ToString();
        cookie["Key"] = user.Password;
    }

    protected void RequireLogin()
    {
        if (currentUser == null)
        {
            Response.Redirect("~/Login.aspx", true);
        }
    }
    protected void RequireStaff()
    {
        RequireLogin();
        if (!isStaff)
        {
            ShowMessage("您已经登录，但没有访问这里的权限");
        }
    }
    protected void RequireCustomer()
    {
        RequireLogin();
        if (!isCustomer)
        {
            ShowMessage("您已经登录，但没有访问这里的权限");
        }
    }

    protected void Page_Init(object sender, EventArgs e)
    {
        // 从 Session 和 Cookie 登录
        currentUser = Session["user"] as User;
        if (currentUser == null)
        {
            var cookie = Request.Cookies["User"];
            if (cookie != null)
            {
                var userID = Util.TryToInt(cookie["ID"]);
                var password = cookie["Key"];
                currentUser = database.Users.Where(u => u.ID == userID && u.Password == password)
                    .SingleOrDefault();
                Session["user"] = currentUser;
            }
        }

        // 当前用户状态
        currentUserID = currentUser != null ? currentUser.ID : -1;
        isStaff = currentUser != null && currentUser.IsAdmin;
        isCustomer = currentUser != null && !currentUser.IsAdmin;
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        database.SaveChanges();
    }
}