<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ListBox ID="lstCustomerList" runat="server" height="200px" style="z-index: 1; left: 168px; top: 56px; position: absolute" width="300px"></asp:ListBox>
        
        <br /><br />

        <asp:Button ID="btnAdd" runat="server" height="40px"  Text="Add" width="100px"></asp:Button>
        <asp:Button ID="btnEdit" runat="server" height="40px"  Text="Edit" width="100px"></asp:Button>
        <asp:Button ID="btnDelete" runat="server" height="40px"  Text="Edit" width="100px"></asp:Button>

        <asp:Label ID="lblEnterFirstName" runat="server"  Text="Enter a first name" width="145px"></asp:Label>
        <asp:TextBox ID="txtEnterFirstName" runat="server" height="29px"  width="188px"></asp:TextBox>

        <asp:Button ID="btnApply" runat="server" height="40px"  Text="Edit" width="100px"></asp:Button>
        <asp:Button ID="btnClear" runat="server" height="40px"  Text="Edit" width="100px"></asp:Button>
    </form>
</body>
</html>
