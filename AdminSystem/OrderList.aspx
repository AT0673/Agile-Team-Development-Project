<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 13px;
            margin: 10px;
        }
        .filter-label {
            display: block;
            margin-bottom: 4px;
        }
        .filter-row {
            display: flex;
            align-items: center;
            gap: 6px;
            margin-bottom: 8px;
        }
        .filter-row input {
            width: 200px;
        }
        .action-row {
            margin-top: 6px;
            display: flex;
            gap: 6px;
        }
        .error-label {
            color: red;
            display: block;
            margin-top: 4px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <span class="filter-label">Order Status:</span>
        <div class="filter-row">
            <asp:TextBox ID="txtFilter" runat="server" placeholder="Enter an Order Status" OnTextChanged="txtOrderStatus_TextChanged" />
            <asp:Button ID="btnApply"       runat="server" Text="Apply"        OnClick="btnApply_Click" />
            <asp:Button ID="btnClearFilter" runat="server" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        </div>

        <asp:ListBox ID="lstOrderList" runat="server" Height="200px" Width="360px" />

        <div class="action-row">
            <asp:Button ID="btnAdd"    runat="server" Text="Add"    OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit"   runat="server" Text="Edit"   OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        </div>

        <asp:Label ID="lblError" runat="server" Text="" CssClass="error-label" />

    </form>
</body>