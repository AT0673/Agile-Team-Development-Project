<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="OrderLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Login</title>
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 14px;
            margin: 0;
            background-color: #f4f6f8;
            color: #1f2933;
        }
        .page {
            max-width: 420px;
            margin: 64px auto;
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
        .field {
            margin-bottom: 14px;
        }
        .field label {
            display: block;
            margin-bottom: 6px;
            font-weight: 700;
        }
        .field input {
            width: 100%;
            box-sizing: border-box;
            padding: 8px;
            border: 1px solid #b8c2cc;
            border-radius: 4px;
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
            <h1>Order Login</h1>

            <div class="field">
                <asp:Label ID="lblUsername" runat="server" Text="Username" AssociatedControlID="txtUsername" />
                <asp:TextBox ID="txtUsername" runat="server" />
            </div>

            <div class="field">
                <asp:Label ID="lblPassword" runat="server" Text="Password" AssociatedControlID="txtPassword" />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />
            </div>

            <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="button" OnClick="btnLogin_Click" />
            <asp:Label ID="lblError" runat="server" Text="" CssClass="error-label" />
        </div>
    </form>
</body>
</html>
