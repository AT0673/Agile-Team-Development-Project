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
        .menu-link {
            display: block;
            padding: 16px;
            border: 1px solid #b8c2cc;
            border-radius: 6px;
            background-color: #f8fafc;
            color: #1f2933;
            text-decoration: none;
        }
        .menu-link:hover {
            border-color: #256fae;
            background-color: #edf6ff;
        }
        .menu-title {
            display: block;
            margin-bottom: 4px;
            font-size: 17px;
            font-weight: 700;
        }
        .menu-description {
            color: #52616f;
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
                <a class="menu-link" href="StaffList.aspx">
                    <span class="menu-title">Staff</span>
                    <span class="menu-description">Manage staff records.</span>
                </a>

                <a class="menu-link" href="CustomerList.aspx">
                    <span class="menu-title">Customers</span>
                    <span class="menu-description">View and manage customer records.</span>
                </a>

                <a class="menu-link" href="SupplierList.aspx">
                    <span class="menu-title">Suppliers</span>
                    <span class="menu-description">Maintain supplier details.</span>
                </a>

                <a class="menu-link" href="StockList.aspx">
                    <span class="menu-title">Stock</span>
                    <span class="menu-description">Manage product and stock records.</span>
                </a>

                <a class="menu-link" href="OrderLogin.aspx">
                    <span class="menu-title">Orders</span>
                    <span class="menu-description">Log in to manage customer and guest orders.</span>
                </a>
            </div>
        </div>
    </form>
</body>
</html>
