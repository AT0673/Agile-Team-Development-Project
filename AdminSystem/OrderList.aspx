<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Management</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 14px;
            margin: 0;
            background-color: #f4f6f8;
            color: #1f2933;
        }
        .page {
            max-width: 760px;
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
        .section-title {
            display: block;
            margin-bottom: 8px;
            font-weight: 700;
        }
        .filter-row {
            display: flex;
            align-items: center;
            gap: 6px;
            margin-bottom: 14px;
            flex-wrap: wrap;
        }
        .filter-row input {
            width: 200px;
            padding: 8px;
            border: 1px solid #b8c2cc;
            border-radius: 4px;
            font-size: 14px;
        }
        .action-row {
            margin-top: 12px;
            display: flex;
            gap: 6px;
        }
        .list-box {
            width: 100%;
            box-sizing: border-box;
            border: 1px solid #b8c2cc;
            border-radius: 4px;
            padding: 6px;
            font-size: 14px;
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
            <h1>Order Management</h1>

            <span class="section-title">Order Filters</span>
            <div class="filter-row">
                <asp:TextBox ID="txtFilter" runat="server" placeholder="Enter an Order Status" />
                <asp:TextBox ID="txtCustomerIDFilter" runat="server" placeholder="Enter a Customer ID" />
                <asp:Button ID="btnApply" runat="server" Text="Apply Filter" CssClass="button" OnClick="btnApply_Click" />
                <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" CssClass="button button-secondary" OnClick="btnClearFilter_Click" />
            </div>

            <span class="section-title">Orders</span>
            <asp:ListBox ID="lstOrderList" runat="server" Height="220px" CssClass="list-box" />

            <div class="action-row">
                <asp:Button ID="btnAdd" runat="server" Text="Add Order" CssClass="button" OnClick="btnAdd_Click" />
                <asp:Button ID="btnEdit" runat="server" Text="Edit Order" CssClass="button button-secondary" OnClick="btnEdit_Click" />
                <asp:Button ID="btnDelete" runat="server" Text="Delete Order" CssClass="button button-danger" OnClick="btnDelete_Click" />
            </div>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="error-label" />
        </div>

    </form>
</body>
</html>
