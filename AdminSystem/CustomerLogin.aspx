<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblLogin" runat="server" Text="Customer Login Page" Font-Size="X-Large"></asp:Label>

            <br />
            <br />

            <asp:Label ID="lblUserName" runat="server" Text="Enter Username"></asp:Label>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>

            <br />
            <br />

            <asp:Label ID="lblPassword" runat="server" Text="Enter Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

            <br />
            <br />

            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/>

            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />

            <br />
            <br />

            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
