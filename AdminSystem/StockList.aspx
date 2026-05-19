<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstProductList" runat="server" Height="389px" Width="501px" OnSelectedIndexChanged="lstProductList_SelectedIndexChanged"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 16px; top: 417px; position: absolute; right: 558px;" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 63px; top: 416px; position: absolute; bottom: 178px" Text="Edit" OnClick="btnEdit_Click" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 461px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
