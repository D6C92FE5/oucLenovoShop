﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Logout : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["user"] = null;
        Response.Cookies["User"].Expires = new DateTime(1970, 1, 2);
        Response.Redirect("~/Index.aspx");
    }
}