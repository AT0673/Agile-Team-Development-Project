<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ClothesRUs Admin System</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 14px;
            margin: 0;
            background-color: #f4f6f8;
            color: #1f2933;
        }
        .page {
            max-width: 820px;
            margin: 40px auto;
            padding: 24px;
            background-color: #ffffff;
            border: 1px solid #d8dee4;
            border-radius: 8px;
        }
        h1 {
            margin: 0;
            font-size: 26px;
            font-weight: 700;
        }
        .subtitle {
            display: block;
            margin: 6px 0 22px 0;
            color: #52616f;
        }
        .menu-grid {
            display: grid;
            grid-template-columns: repeat(2, minmax(0, 1fr));
            gap: 12px;
        }
        .menu-button {
            width: 100%;
            padding: 16px;
            border: 1px solid #b8c2cc;
            border-radius: 6px;
            background-color: #f8fafc;
            color: #1f2933;
            font-size: 17px;
            font-weight: 700;
            text-align: left;
            cursor: pointer;
        }
        .menu-button:hover {
            border-color: #256fae;
            background-color: #edf6ff;
        }
        @media (max-width: 640px) {
            .page {
                margin: 16px;
            }
            .menu-grid {
                grid-template-columns: 1fr;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="page">
            <h1>ClothesRUs Admin System</h1>
            <span class="subtitle">Team Main Menu</span>

            <div class="menu-grid">
                <asp:Button ID="btnStaff" runat="server" Text="Staff" CssClass="menu-button" OnClick="btnStaff_Click" />
                <asp:Button ID="btnCustomers" runat="server" Text="Customers" CssClass="menu-button" OnClick="btnCustomers_Click" />
                <asp:Button ID="btnSuppliers" runat="server" Text="Suppliers" CssClass="menu-button" OnClick="btnSuppliers_Click" />
                <asp:Button ID="btnStock" runat="server" Text="Stock" CssClass="menu-button" OnClick="btnStock_Click" />
                <asp:Button ID="btnOrders" runat="server" Text="Orders" CssClass="menu-button" OnClick="btnOrders_Click" />
            </div>
        </div>
    </form>
</body>
</html>
