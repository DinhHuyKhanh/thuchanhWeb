using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebChat.frontend
{
    public partial class members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.AppendHeader("Refresh", 5 + "; URL=members.aspx");

            List<Member> members = (List<Member>)Application["members"];

            int stt = 0;
            foreach (Member mb in members)
            {
                tbody.InnerHtml += "<span>" + ++stt + " " + mb.getNickName() + " </span> <br>";
            }



        }
    }
}