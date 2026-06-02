<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Confirm Delete Page</title>
    <style>
        body {
            font-family: Arial;
            background-color: #f4f4f4;
        }

        .container {
            width: 400px;
            margin: 50px auto;
            background-color: white;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
        }

        .title {
            text-align: center;
            color: #333;
        }

        .textbox {
            width: 100%;
            padding: 8px;
            margin-top: 5px;
            margin-bottom: 10px;
        }

        .button {
            background-color: #0078D7;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .button:hover {
            background-color: #005fa3;
        }

        .error {
            color: red;
            font-weight: bold;
        }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this record?" width="145px"></asp:Label>
        <asp:Button ID="btnYes" runat="server" Text="Yes" OnClick="btnYes_Click" CssClass="button"></asp:Button>
        <asp:Button ID="btnNo" runat="server" Text="No" OnClick="btnNo_Click" CssClass="button"></asp:Button>
    </form>
</body>
</html>
