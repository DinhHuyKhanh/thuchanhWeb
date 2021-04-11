 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bai10.aspx.cs" Inherits="Web10.bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>

    </title>
</head>
<body>
    <form id="form1" action="bai10.aspx" runat="server">
        <div class="boder-body">
            
        <table style="width:40%;">
            <tr>
                <td>
                     <span>Nhập nội dung upload:</span>
                </td>
                <td>
                     <input type="text" runat="server" id="txtNoidung" name="txtNoidung"/>
                </td>
                
            </tr>
            <tr>
                <td>
                     <span>Chọn fileUpload </span>
                </td>
                <td>
                    <asp:FileUpload runat="server" ID="FileUpload1" />
                </td>
            </tr>
               
        </table>
              <asp:Button ID="btnUpload" runat="server" onclick="uploadFile_click"  Text="Upload" />
        </div>
    </form>
</body>
</html>
