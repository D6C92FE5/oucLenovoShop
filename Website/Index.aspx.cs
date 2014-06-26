using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Index : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var items = database.Computers.ToArray();
        
        var screenSizes = items.Select(i => i.ScreenSize).Distinct().OrderBy(s => s);
        ctScreenSizes.DataSource = screenSizes;
        ctScreenSizes.DataBind();

        var processors = items.Select(i => i.Processor).Distinct().OrderBy(s => s);
        ctProcessors.DataSource = processors;
        ctProcessors.DataBind();

        var screenSize = Request["ScreenSize"];
        if (!string.IsNullOrEmpty(screenSize))
        {
            items = items.Where(i => i.ScreenSize == screenSize).ToArray();
        }
        var processor = Request["Processor"];
        if (!string.IsNullOrEmpty(processor))
        {
            items = items.Where(i => i.Processor == processor).ToArray();
        }

        ctItems.DataSource = items;
        ctItems.DataBind();
    }
}