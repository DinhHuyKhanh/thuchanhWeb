<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Xuly.aspx.cs" Inherits="Web11.Xuly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .tbl{
            border-top-right-radius: 1px;

        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
            <asp:Table id="tablenv" runat="server">

                <asp:TableRow>
                    <asp:TableHeaderCell>STT</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Họ và tên</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Năm sinh</asp:TableHeaderCell>

                </asp:TableRow>

            </asp:Table>
        </div>
        <linkbutton runat="server" OnClick="myButton_click"><a href="MyFrom.htm"> click me </a></linkbutton>
        

    </form>
</body>
</html>
