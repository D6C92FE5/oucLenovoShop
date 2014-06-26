using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class BasePage : System.Web.UI.Page
{
    protected Entities database = new Entities();

    protected User currentUser;

    protected void Login(User user)
    {
        Session["user"] = user;
        var cookie = Response.Cookies["User"];
        cookie["ID"] = user.ID.ToString();
        cookie["Key"] = user.Password;
    }

    protected void Page_Init(object sender, EventArgs e)
    {
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
    }

    protected void Page_Unload(object sender, EventArgs e)
    {
        database.SaveChanges();
    }
}