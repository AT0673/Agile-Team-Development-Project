<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Product ID"></asp:Label>
        <div>
        </div>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 97px; top: 14px; position: absolute"></asp:TextBox>
        <asp:Label ID="tblProductQuantity" runat="server" style="z-index: 1; left: 1px; top: 45px; position: absolute" Text="Product Quantity"></asp:Label>
        <asp:TextBox ID="txt" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
