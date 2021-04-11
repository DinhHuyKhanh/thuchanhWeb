using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web10
{
    public partial class bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void uploadFile_click(object sender, EventArgs e)
        {
            String xml = Request.Form["txtNoidung"];
            Response.Write("txtNoidung: "+xml);
            try
            {
                if (Page.IsValid && FileUpload1.HasFile)
                {
                    string sFolderPath = Server.MapPath(@"App-Data");
                    HttpPostedFile myFile = FileUpload1.PostedFile;
                    string sFileName = myFile.FileName;
                    myFile.SaveAs(
                        string.Format(@"{0}\{1}", sFolderPath, sFileName));
                    Response.Write("</br>Status: Success!");
                }
                else
                {
                    Response.Write("</br>Status: file chưa được tải lên!");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
                
            
            
        }
    }
}