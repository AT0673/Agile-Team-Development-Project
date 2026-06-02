<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Login</title>

    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }

        .container {
            width: 400px;
            margin: 80px auto;
            background-color: white;
            padding: 30px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
        }

        .title {
            text-align: center;
            color: #333;
            margin-bottom: 25px;
        }

        .form-row {
            margin-bottom: 15px;
        }

        .label {
            display: block;
            font-weight: bold;
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
            cursor: pointer;
        }

        .button:hover {
            background-color: #005fa3;
        }

        .cancel-button {
            background-color: #777;
        }

        .cancel-button:hover {
            background-color: #555;
        }

        .error {
            color: red;
            font-weight: bold;
            display: block;
            margin-top: 15px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

        <div class="container">

            <h1 class="title">Customer Login Page</h1>

            <div class="form-row">
                <asp:Label ID="lblUserName"
                    runat="server"
                    Text="Enter Username"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox ID="txtUserName"
                    runat="server"
                    CssClass="textbox">
                </asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Label ID="lblPassword"
                    runat="server"
                    Text="Enter Password"
                    CssClass="label">
                </asp:Label>

                <asp:TextBox ID="txtPassword"
                    runat="server"
                    TextMode="Password"
                    CssClass="textbox">
                </asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Button ID="btnLogin"
                    runat="server"
                    Text="Login"
                    CssClass="button"
                    OnClick="btnLogin_Click" />

                <asp:Button ID="btnCancel"
                    runat="server"
                    Text="Cancel"
                    CssClass="button cancel-button"
                    OnClick="btnCancel_Click"/>
            </div>

            <asp:Label ID="lblError"
                runat="server"
                CssClass="error">
            </asp:Label>

        </div>

    </form>
</body>
</html>