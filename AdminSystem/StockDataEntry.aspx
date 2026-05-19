<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="StockDataEntry.aspx.cs"
    Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Stock Data Entry</title>

    <style>
        .form-row {
            margin-bottom: 12px;
        }

        .label {
            display: inline-block;
            width: 140px;
        }

        .textbox {
            width: 250px;
        }

        .buttons {
            margin-top: 20px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div class="form-row">
            <asp:Label ID="lblProductID"
                runat="server"
                CssClass="label"
                Text="Product ID">
            </asp:Label>

            <asp:TextBox ID="txtProductID"
                runat="server"
                CssClass="textbox">
            </asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblProductAmount"
                runat="server"
                CssClass="label"
                Text="Product Amount"></asp:Label>

            <asp:TextBox ID="txtProductAmount"
                runat="server"
                CssClass="textbox"></asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblStockArrivalDate"
                runat="server"
                CssClass="label"
                Text="Stock Arrival Date">
            </asp:Label>

            <asp:TextBox ID="txtStockArrivalDate"
                runat="server"
                CssClass="textbox"
                TextMode="Date">
            </asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblSupplierID"
                runat="server"
                CssClass="label"
                Text="Supplier ID">
            </asp:Label>

            <asp:TextBox ID="txtSupplierID"
                runat="server"
                CssClass="textbox">
            </asp:TextBox>
        </div>

        <div class="form-row">
            <asp:Label ID="lblProductName"
                runat="server"
                CssClass="label"
                Text="Product Name">
            </asp:Label>

            <asp:TextBox ID="txtProductName"
                runat="server"
                CssClass="textbox">
            </asp:TextBox>
        </div>

        <div class="form-row">
            <asp:CheckBox ID="InStock"
                runat="server"
                Text="In Stock?" />
        </div>

        <div class="form-row">
            <asp:Label ID="lblError"
                runat="server"
                ForeColor="Red">
            </asp:Label>
        </div>

        <div class="buttons">
            <asp:Button ID="btnOk"
                runat="server"
                Text="OK"
                OnClick="btnOk_Click" />

            <asp:Button ID="btnCancel"
                runat="server"
                Text="Cancel" OnClick="btnCancel_Click" />
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 103px; top: 277px; position: absolute" Text="Find" />
        </div>

    </form>
</body>
</html>