<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?" width="145px"></asp:Label>
        <asp:Button ID="btnYes" runat="server" height="40px"  Text="Yes" width="100px" OnClick="btnYes_Click"></asp:Button>
        <asp:Button ID="btnNo" runat="server" height="40px"  Text="No" width="100px" OnClick="btnNo_Click"></asp:Button>
    </form>
</body>
</html>
