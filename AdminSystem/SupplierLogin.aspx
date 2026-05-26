<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Supplier Login Page</div>
        <asp:Label ID="lblUsername" runat="server" style="z-index: 1; left: 66px; top: 72px; position: absolute" Text="Username:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 67px; top: 102px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 164px; top: 71px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 164px; top: 106px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" style="z-index: 1; left: 127px; top: 159px; position: absolute" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 223px; top: 159px; position: absolute" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" style="z-index: 1; left: 379px; top: 88px; position: absolute" Text=""></asp:Label>
    </form>
</body>
</html>
