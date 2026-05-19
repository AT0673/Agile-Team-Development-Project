<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Order</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 14px;
            margin: 0;
            background-color: #f4f6f8;
            color: #1f2933;
        }
        .page {
            max-width: 560px;
            margin: 32px auto;
            padding: 24px;
            background-color: #ffffff;
            border: 1px solid #d8dee4;
            border-radius: 8px;
        }
        h1 {
            margin: 0 0 12px 0;
            font-size: 24px;
            font-weight: 700;
        }
        .warning {
            margin-bottom: 16px;
            color: #b42318;
            font-weight: 700;
        }
        .summary {
            padding: 12px;
            border: 1px solid #f2c4bd;
            border-radius: 4px;
            background-color: #fff5f3;
            margin-bottom: 18px;
            line-height: 1.6;
        }
        .button-row {
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
        .button-danger {
            border-color: #b42318;
            background-color: #b42318;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <h1>Delete Order</h1>
            <div class="warning">Are you sure you want to delete this order?</div>

            <div class="summary">
                <asp:Label ID="lblOrderSummary" runat="server" Text=""></asp:Label>
            </div>

            <div class="button-row">
                <asp:Button ID="btnYes" runat="server" Text="Delete Order" CssClass="button button-danger" OnClick="btnYes_Click" />
                <asp:Button ID="btnNo" runat="server" Text="Cancel" CssClass="button button-secondary" OnClick="btnNo_Click" />
            </div>
        </div>
    </form>
</body>
</html>
