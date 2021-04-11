using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web09
{
    public partial class xuly2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.ContentType = "text/xml";
            
            var vxl = "<vxl>" + Request.QueryString["vxl"]+ "</vxl>";
            var hang = "<hang>" + Request.QueryString["hang"] + "</hang>";
            var ngayRaMat = "<ngayRaMat>" + Request.QueryString["ngayRaMat"] + "</ngayRaMat>";
            var gia = "<gia>" + Request.QueryString["gia"] + "</gia>";
           

            Response.Clear();
            Response.ContentType = "text/xml; charset=utf-8";
            Response.Write("<main>" + vxl + hang + ngayRaMat + gia + "</main>");
            Response.End();
        }
    }
}