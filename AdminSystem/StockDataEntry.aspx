<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 304px;
            width: 1030px;
        }
    </style>
</head>
<body style="height: 302px; width: 958px;">
    <form id="form1" runat="server">
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 19px;" Text="Product ID"></asp:Label>
        <div>
        </div>
        <p>
            <asp:TextBox ID="txtStockArrivalDate" runat="server" style="z-index: 1; left: 111px; top: 90px; position: absolute"></asp:TextBox>
        </p>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 111px; top: 14px; position: absolute; bottom: 632px;"></asp:TextBox>
        <asp:Label ID="tblProductQuantity" runat="server" style="z-index: 1; left: 5px; top: 41px; position: absolute" Text="Product Quantity" width="68px"></asp:Label>
        <asp:TextBox ID="txtProductQuantity" runat="server" style="z-index: 1; left: 111px; top: 46px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStockArrrivalDate" runat="server" style="z-index: 1; left: 7px; top: 82px; position: absolute; bottom: 530px; width: 77px" Text="Stock Arrival Date"></asp:Label>
        <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 9px; top: 131px; position: absolute" Text="Supplier ID" width="68px"></asp:Label>
        <asp:Label ID="lblProductName" runat="server" style="z-index: 1; left: 9px; top: 176px; position: absolute" Text="Product Name" width="68px"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 111px; top: 183px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductName" runat="server" style="z-index: 1; left: 111px; top: 132px; position: absolute"></asp:TextBox>
        <p>
            <asp:CheckBox ID="InStock" runat="server" style="z-index: 1; left: 135px; top: 229px; position: absolute" Text="In Stock?" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 7px; top: 229px; position: absolute"></asp:Label>
        <div style="margin-left: 40px">
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 15px; top: 267px; position: absolute" Text="OK" />
        </div>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 97px; top: 267px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
