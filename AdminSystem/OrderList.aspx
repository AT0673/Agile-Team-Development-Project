<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat ="server">
    <title></title>
    <style type ="text/css">
        body {
            font-family: Arial, sans-serif;
            font-size: 13px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrderList" runat="server" CssClass="txt row1" Height="200px" Width="300px"></asp:ListBox>

        <asp:Button ID="btnAdd"    runat="server" Text="Add"    style="position:absolute; left:0px; top:240px; width:60px;" OnClick="btnAdd_Click" />
        <asp:Button ID="btnEdit"   runat="server" Text="Edit"   style="position:absolute; left:75px; top:240px; width:60px;" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" style="position:absolute; left:150px; top:240px; width:60px;" OnClick="btnDelete_Click" />
        <asp:Label ID="lblError" runat="server" Text="" style="position:absolute; left:15px; top:275px; width:300px; color:red;"></asp:Label>
    </form>
</body>
</html>
