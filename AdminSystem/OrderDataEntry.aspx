<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Details</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 14px;
            margin: 0;
            background-color: #f4f6f8;
            color: #1f2933;
        }
        .page {
            max-width: 620px;
            margin: 32px auto;
            padding: 24px;
            background-color: #ffffff;
            border: 1px solid #d8dee4;
            border-radius: 8px;
        }
        h1 {
            margin: 0 0 18px 0;
            font-size: 24px;
            font-weight: 700;
        }
        .form-grid {
            display: grid;
            grid-template-columns: 150px 1fr;
            gap: 12px 16px;
            align-items: center;
        }
        .lbl {
            font-weight: 700;
            text-align: right;
        }
        .txt,
        .select {
            width: 100%;
            box-sizing: border-box;
            padding: 8px;
            border: 1px solid #b8c2cc;
            border-radius: 4px;
            font-size: 14px;
        }
        .check-row {
            grid-column: 2;
        }
        .button-row {
            margin-top: 20px;
            display: flex;
            gap: 8px;
        }
        .button {
            padding: 8px 14px;
            border: 1px solid #1f5f99;
            border-radius: 4px;
            background-color: #256fae;
            color: #ffffff;
            cursor: pointer;
        }
        .button-secondary {
            background-color: #ffffff;
            color: #1f5f99;
        }
        .error-label {
            display: block;
            margin-top: 14px;
            color: #b42318;
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <h1>Order Details</h1>

            <div class="form-grid">
                <asp:Label ID="lblOrderID" runat="server" CssClass="lbl" Text="Order ID"></asp:Label>
                <asp:TextBox ID="txtOrderID" runat="server" CssClass="txt"></asp:TextBox>

                <asp:Label ID="lblCustomerID" runat="server" CssClass="lbl" Text="Customer ID"></asp:Label>
                <asp:TextBox ID="txtCustomerID" runat="server" CssClass="txt" TextMode="Number"></asp:TextBox>

                <asp:Label ID="lblOrderDate" runat="server" CssClass="lbl" Text="Order Date"></asp:Label>
                <asp:TextBox ID="txtOrderDate" runat="server" CssClass="txt" TextMode="Date"></asp:TextBox>

                <asp:Label ID="lblTotalPrice" runat="server" CssClass="lbl" Text="Total Price"></asp:Label>
                <asp:TextBox ID="txtTotalPrice" runat="server" CssClass="txt"></asp:TextBox>

                <asp:Label ID="lblStatus" runat="server" CssClass="lbl" Text="Status"></asp:Label>
                <asp:DropDownList ID="ddlStatus" runat="server" CssClass="select">
                    <asp:ListItem Text="Pending" Value="Pending"></asp:ListItem>
                    <asp:ListItem Text="Processing" Value="Processing"></asp:ListItem>
                    <asp:ListItem Text="Dispatched" Value="Dispatched"></asp:ListItem>
                    <asp:ListItem Text="Delivered" Value="Delivered"></asp:ListItem>
                    <asp:ListItem Text="Cancelled" Value="Cancelled"></asp:ListItem>
                </asp:DropDownList>

                <asp:Label ID="lblProductID" runat="server" CssClass="lbl" Text="Product ID"></asp:Label>
                <asp:TextBox ID="txtProductID" runat="server" CssClass="txt" TextMode="Number"></asp:TextBox>

                <span></span>
                <div class="check-row">
                    <asp:CheckBox ID="chkIsGuestOrder" runat="server" Text="Guest order" />
                </div>
            </div>

            <asp:Label ID="lblError" runat="server" CssClass="error-label" Text=""></asp:Label>

            <div class="button-row">
                <asp:Button ID="btnOK" runat="server" Text="Save Order" CssClass="button" OnClick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button button-secondary" OnClick="btnCancel_Click" />
                <asp:Button ID="btnFind" runat="server" Text="Find Order" CssClass="button button-secondary" OnClick="btnFind_Click" />
            </div>
        </div>

    </form>
</body>
</html>
