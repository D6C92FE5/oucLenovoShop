﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order_ : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RequireLogin();

        ctOrders.DataSource = (isStaff ? database.Orders : database.Orders
            .Where(o => o.User.ID == currentUser.ID)).ToArray();
        ctOrders.DataBind();
    }
}