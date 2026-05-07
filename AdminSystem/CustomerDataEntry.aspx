<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblCustomerId" runat="server" style="z-index: 1; left: 16px; top: 58px; position: absolute; margin-bottom: 1px" Text="Customer ID" width="145px"></asp:Label>
        <asp:TextBox ID="txtCustomerID" runat="server" height="29px" style="z-index: 1; left: 168px; top: 56px; position: absolute" width="188px"></asp:TextBox>
        <asp:Label ID="lblCustomerFirstName" runat="server" style="z-index: 1; left: 17px; top: 94px; position: absolute" Text="First Name" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerLastName" runat="server" style="z-index: 1; left: 17px; top: 130px; position: absolute" Text="Last Name" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerEmail" runat="server" style="z-index: 1; left: 16px; top: 168px; position: absolute" Text="Email" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerPassword" runat="server" style="z-index: 1; left: 16px; top: 204px; position: absolute" Text="Password" width="145px"></asp:Label>
        <asp:Label ID="lblCustomerPhone" runat="server" style="z-index: 1; left: 15px; top: 241px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:Label ID="lblCustomerAddress" runat="server" style="z-index: 1; left: 13px; top: 274px; position: absolute" Text="Address" width="145px"></asp:Label>
        <asp:TextBox ID="txtCustomerFirstName" runat="server" height="29px" style="z-index: 1; left: 168px; top: 92px; position: absolute" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerLastName" runat="server" height="29px" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 168px; top: 128px; position: absolute" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerEmail" runat="server" height="29px" style="z-index: 1; left: 168px; top: 165px; position: absolute" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPassword" runat="server" height="29px" style="z-index: 1; left: 168px; top: 202px; position: absolute" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerPhone" runat="server" height="29px" style="z-index: 1; left: 168px; top: 239px; position: absolute" width="188px"></asp:TextBox>
        <asp:TextBox ID="txtCustomerAddress" runat="server" style="z-index: 1; left: 168px; top: 273px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblCustomerError" runat="server" style="z-index: 1; left: 16px; top: 332px; position: absolute" Text="lblError"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 172px; top: 332px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 227px; top: 331px; position: absolute" Text="Cancel" />
    </form>
</body>
</html>
