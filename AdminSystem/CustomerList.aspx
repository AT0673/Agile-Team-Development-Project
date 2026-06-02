<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer List</title>

    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }

        .container {
            width: 700px;
            margin: 40px auto;
            background-color: white;
            padding: 25px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
        }

        .title {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
        }

        .listbox {
            width: 100%;
            height: 250px;
            margin-bottom: 20px;
        }

        .form-row {
            margin-bottom: 15px;
        }

        .label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .textbox {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }

        .button {
            background-color: #0078D7;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 5px;
            margin-right: 10px;
            margin-top: 10px;
            cursor: pointer;
        }

        .button:hover {
            background-color: #005fa3;
        }

        .main-menu-button {
            background-color: #555;
        }

        .main-menu-button:hover {
            background-color: #333;
        }

        .error {
            color: red;
            font-weight: bold;
            display: block;
            margin-top: 15px;
        }

        .logged-user {
            color: green;
            font-weight: bold;
            margin-top: 15px;
            display: block;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div class="container">

            <h1 class="title">Customer List</h1>

            <asp:ListBox ID="lstCustomerList"
                runat="server"
                CssClass="listbox">
            </asp:ListBox>

            <div class="form-row">
                <asp:Button ID="btnAdd"
                    runat="server"
                    Text="Add"
                    CssClass="button"
                    OnClick="btnAdd_Click">
                </asp:Button>

                <asp:Button ID="btnEdit"
                    runat="server"
                    Text="Edit"
                    CssClass="button"
                    OnClick="btnEdit_Click">
                </asp:Button>

                <asp:Button ID="btnDelete"
                    runat="server"
                    Text="Delete"
                    CssClass="button"
                    OnClick="btnDelete_Click">
                </asp:Button>
            </div>

            <div class="form-row">
                <asp:Label ID="lblEnterFirstName"
                    runat="server"
                    Text="Enter a first name"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox ID="txtEnterFirstName"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Button ID="btnApply"
                    runat="server"
                    Text="Apply Filter"
                    CssClass="button"
                    OnClick="btnApply_Click">
                </asp:Button>

                <asp:Button ID="btnClear"
                    runat="server"
                    Text="Clear Filter"
                    CssClass="button"
                    OnClick="btnClear_Click">
                </asp:Button>
            </div>

            <div class="form-row">
                <asp:Button ID="btnMainMenu"
                    runat="server"
                    Text="Return to Main Menu"
                    CssClass="button main-menu-button"
                    OnClick="btnMainMenu_Click">
                </asp:Button>
            </div>

            <asp:Label ID="lblLoggedInUser"
                runat="server"
                CssClass="logged-user">
            </asp:Label>

            <asp:Label ID="lblError"
                runat="server"
                CssClass="error">
            </asp:Label>

        </div>

    </form>
</body>
</html>