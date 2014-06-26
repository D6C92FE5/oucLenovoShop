using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ItemEdit : BasePage
{
    protected Computer item;

    protected void Page_Load(object sender, EventArgs e)
    {
        RequireLogin();
        
        var id = Util.TryToInt(Request["ID"]);
        item = database.Computers.Where(c => c.ID == id).SingleOrDefault();
        item = item ?? new Computer();

        if (Request.HttpMethod == "POST")
        {
            var listPicture = Request.Files["list-picture"];
            if (listPicture.ContentLength > 0)
            {
                item.ListPicture = Util.GetNewUploadFilePath() + ".jpg";
                listPicture.SaveAs(Server.MapPath(item.ListPicture));
            }
            var deatilPicture = Request.Files["detail-picture"];
            if (deatilPicture.ContentLength > 0)
            {
                item.DetailPicture = Util.GetNewUploadFilePath() + ".jpg";
                deatilPicture.SaveAs(Server.MapPath(item.DetailPicture));
            }

            item.Name = Request["name"];
            item.Price = Request["price"];
            item.Model = Request["modal"];
            item.ScreenSize = Request["screen-size"];
            item.Processor = Request["processor"];
            item.Intro = "";

            if (item.ID == 0)
            {
                database.Computers.Add(item);
            }
            database.SaveChanges();

            Response.Redirect("~/Item.aspx?ID=" + item.ID);
        }
    }
}