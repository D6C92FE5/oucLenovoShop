using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserInfoEdit : BasePage
{
    protected User user;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RequireLogin();

        user = database.Users.Where(c => c.ID == currentUser.ID).SingleOrDefault();

        if (Request.HttpMethod == "POST")
        {
            user.Email = Request["email"];
            user.Phone = Request["phone"];
            user.Address = Request["address"];
            user.ZipCode = Request["zip-code"];

            ShowMessage("修改成功");
        }
    }
}