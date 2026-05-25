<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 14px; top: 22px; position: absolute; height: 301px; width: 329px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 17px; top: 345px; position: absolute; height: 25px; width: 51px" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 74px; top: 345px; position: absolute; height: 25px; width: 59px" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Style="z-index: 1; left: 140px; top: 345px; position: absolute; height: 25px; width: 59px" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 22px; top: 380px; position: absolute; right: 505px" Text="Error"></asp:Label>
           
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 10px; top: 425px; position: absolute" Text="Enter Supplier Name"></asp:Label>
        <asp:TextBox ID="txtFilterSupplierName" runat="server" style="z-index: 1; left: 194px; top: 425px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 259px; top: 476px; position: absolute" Text="Clear" />
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick = "btnApply_Click" style="z-index: 1; left: 106px; top: 476px; position: absolute; height: 29px" Text="Apply" />
        </p>
           
    </form>
</body>
</html>
