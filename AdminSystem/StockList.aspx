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
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 25px; top: 420px; position: absolute" Text="Add" />
        </div>
        <p>
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 92px; top: 420px; position: absolute" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 153px; top: 420px; position: absolute" Text="Delete" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 461px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
