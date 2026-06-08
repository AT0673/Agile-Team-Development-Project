<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
       
        Do you wish to delete this record?<asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" style="z-index: 1; left: 92px; top: 94px; position: absolute" Text="Yes" />
         <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 216px; top: 94px; position: absolute" Text="No" />
    </form>
</body>
</html>
