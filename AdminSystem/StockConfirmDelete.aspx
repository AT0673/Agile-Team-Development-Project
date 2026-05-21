<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="txtDelete" runat="server" style="z-index: 1; left: 94px; top: 81px; position: absolute" Text="Are you sure you want to delete this reord?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 289px; top: 116px; position: absolute; right: 325px" Text="No" />
        <p>
            <asp:Button ID="bntYes" runat="server" OnClick="bntYes_Click" style="z-index: 1; left: 138px; top: 113px; position: absolute; height: 29px" Text="Yes" />
        </p>
    </form>
</body>
</html>
