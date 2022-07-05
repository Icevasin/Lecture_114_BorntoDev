<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Login.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Password1 {
            margin-top: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 80px">
            เข้าสู่ระบบ<br />
            <br />
            Username<br />
            <br />
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<p>
                <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="ยืนยัน" Width="118px" />
            </p>
        </div>
    </form>
</body>
</html>
