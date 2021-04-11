using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebChat.frontend
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                            //< p style = "color: blue" > +name + (time) + message + </ p >
            List<message> messages = (List<message>)Application["message"];
            List<Member> members = (List<Member>)Application["members"];
            
            foreach(message message in messages)
            {
                foreach (Member member in members)
                {
                    if(member.getNickName() == message.getNickname())
                    {
                        tbody.InnerHtml += "<p style=" + "color:" + member.getColor() + ">" + "(" + message.getTimetamp() + ")" + member.getNickName() +
                                        " : " + message.getMessage()+ "</p>";
 
                        break;
                    }
                }
            }
            Response.AppendHeader("Refresh", 5 + "; URL=MessageList.aspx");
        }
    }
}