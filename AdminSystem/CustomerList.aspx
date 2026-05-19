<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" height="29px" style="z-index: 1; left: 168px; top: 56px; position: absolute" width="188px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" height="10px" style="z-index: 1; left: 168px; top: 56px; position: absolute" width="30px"></asp:Button>
        </div>
    </form>
</body>
</html>
