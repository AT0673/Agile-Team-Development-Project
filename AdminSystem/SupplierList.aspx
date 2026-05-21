<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 14px; top: 22px; position: absolute; height: 301px; width: 329px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 345px; position: absolute; height: 25px; width: 51px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 74px; top: 345px; position: absolute; height: 25px; width: 59px" Text="Edit" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 380px; position: absolute; right: 505px" Text="Error"></asp:Label>
    </form>
</body>
</html>
