﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ctOrders.DataSource = database.Orders.ToArray();
        ctOrders.DataBind();
    }
}