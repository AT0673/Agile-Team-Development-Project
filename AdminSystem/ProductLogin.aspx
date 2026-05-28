<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductLogin.aspx.cs" Inherits="ProductLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblLoginPage" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute" Text="Product Login Page"></asp:Label>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 66px; top: 90px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 63px; top: 127px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 162px; top: 91px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 161px; top: 133px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 355px; top: 103px; position: absolute" Text="[lblError]"></asp:Label>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 119px; top: 192px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 220px; top: 194px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
