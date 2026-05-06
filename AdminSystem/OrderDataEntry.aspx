<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 13px;
        }

        .lbl { position: absolute; left: 20px; height: 20px; line-height: 20px; width: 100px; text-align: right; }
        .txt { position: absolute; left: 130px; width: 180px; }

        .row1 { top: 20px;  } .row2 { top: 55px;  } .row3 { top: 90px;  }
        .row4 { top: 125px; } .row5 { top: 160px; } .row6 { top: 195px; }
        .row7 { top: 230px; } .row8 { top: 265px; } .row9 { top: 300px; }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <asp:Label   ID="lblOrderID"      runat="server" CssClass="lbl row1" Text="Order ID"></asp:Label>
        <asp:TextBox ID="txtOrderID"      runat="server" CssClass="txt row1"></asp:TextBox>

        <asp:Label   ID="lblCustomerID"   runat="server" CssClass="lbl row2" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerID"   runat="server" CssClass="txt row2"></asp:TextBox>

        <asp:Label   ID="lblOrderDate"    runat="server" CssClass="lbl row3" Text="Order Date"></asp:Label>
        <asp:TextBox ID="txtOrderDate"    runat="server" CssClass="txt row3" TextMode="Date"></asp:TextBox>

        <asp:Label   ID="lblTotalPrice"   runat="server" CssClass="lbl row4" Text="Total Price"></asp:Label>
        <asp:TextBox ID="txtTotalPrice"   runat="server" CssClass="txt row4"></asp:TextBox>

        <asp:Label   ID="lblStatus"       runat="server" CssClass="lbl row5" Text="Status"></asp:Label>
        <asp:TextBox ID="txtStatus"       runat="server" CssClass="txt row5"></asp:TextBox>

        <asp:Label   ID="lblProductID"    runat="server" CssClass="lbl row6" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtProductID"    runat="server" CssClass="txt row6"></asp:TextBox>

        <asp:CheckBox ID="chkIsGuestOrder"  runat="server" style="position:absolute; left:130px; top:233px;" Text="isGuestOrder" />

        <asp:Label ID="lblError" runat="server" CssClass="lbl row8" Text="" style="width:300px;"></asp:Label>

        <asp:Button ID="btnOK"     runat="server" Text="OK"     style="position:absolute; left:130px; top:300px; width:60px;" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" style="position:absolute; left:200px; top:300px; width:60px;" />

    </form>
</body>
</html>