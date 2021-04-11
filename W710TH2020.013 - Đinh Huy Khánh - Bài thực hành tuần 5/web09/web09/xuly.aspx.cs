using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web09
{
    public partial class xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "text/xml";
            var vxl = "<vxl>" + Request.Form["vxl"] + "</vxl>";
            var hang = "<hang>" + Request.Form["hang"] + "</hang>";
            var ngayRaMat = "<ngayRaMat>" + Request.Form["ngayRaMat"] + "</ngayRaMat>";
            var gia = "<gia>" + Request.Form["gia"] + "</gia>";
    
            Response.Clear();
            Response.ContentType = "text/xml; charset=utf-8";
            Response.Write("<main>"+ vxl + hang + ngayRaMat + gia+"</main>");
            Response.End();

        }
    }
}