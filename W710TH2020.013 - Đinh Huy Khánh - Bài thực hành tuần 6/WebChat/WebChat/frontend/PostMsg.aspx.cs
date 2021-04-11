using System;
using System.Collections.Generic;
using System.Web;

namespace WebChat.frontend
{
    public partial class MessageSender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<message> messages = (List<message>)Application["message"];
            DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
            List<Member> members = (List<Member>)Application["members"];

            string username = Request.Form["txtuser"];
            string mess = HttpUtility.HtmlEncode(Request.Form["txtmess"]);
            string color = "";

            if (!(username == "") && !(username == null))
            {           
                foreach(Member member in members)
                {
                   if (member.getNickName() == username)
                   {     
                       color = member.getColor();
                       break;
                   }
                }
                if (color == "")
                {
                    color = "black";
                    members.Add(new Member(username, color));
                    Application["members"] = members;
                }
                
                messages.Add(new message(username, mess, now));
                Application["message"] = messages;
                Response.Redirect("PostMsg.aspx");
            }
          
           
          


        }

    }
}