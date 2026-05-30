<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ListBox ID="lstCustomerList" runat="server" height="200px" left="300px" top="56px" width="300px"></asp:ListBox>
        
        <br /><br />

        <asp:Button ID="btnAdd" runat="server" height="40px"  Text="Add" width="100px" OnClick="btnAdd_Click"></asp:Button>
        <asp:Button ID="btnEdit" runat="server" height="40px"  Text="Edit" width="100px" OnClick="btnEdit_Click"></asp:Button>
        <asp:Button ID="btnDelete" runat="server" height="40px"  Text="Delete" width="100px" OnClick="btnDelete_Click"></asp:Button>

        <asp:Label ID="lblEnterFirstName" runat="server"  Text="Enter a first name" width="145px"></asp:Label>
        <asp:TextBox ID="txtEnterFirstName" runat="server" height="29px"  width="188px"></asp:TextBox>

        <asp:Button ID="btnApply" runat="server" height="40px"  Text="Apply" width="100px" OnClick="btnApply_Click"></asp:Button>
        <asp:Button ID="btnClear" runat="server" height="40px"  Text="Clear" width="100px" OnClick="btnClear_Click"></asp:Button>

        <asp:Label ID="lblLoggedInUser" runat="server"  width="145px"></asp:Label>
        <asp:Label ID="lblError" runat="server"  width="145px"></asp:Label>
    </form>
</body>
</html>
