<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostMsg.aspx.cs" Inherits="WebChat.frontend.MessageSender" ValidateRequest="false" %>

<!DOCTYPE html>
/** 
@author: Đinh Huy Khánh
@Class: 1910A05;

*/
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #txtmess{
            width:80%;
            height: 50px;
        }
        #btnsbm{
            width:15%;
            height:50px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" action="PostMsg.aspx">
        <div>
            <input  type="text" id ="txtuser" placeholder="username" runat="server"/>
            <strong>Message Sender</strong><br />
            <input type="text" id ="txtmess" runat="server" autocomplete="off"/>
            <button id="btnsbm" runat="server" >Send</button>

            <div id="tbody" runat="server" onclick="PostMsg.aspx"></div>
        </div>
    </form>
</body>
    
</html>
