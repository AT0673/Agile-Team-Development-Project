<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblSupplierID" runat="server" style="z-index: 1; left: 11px; top: 59px; position: absolute; height: 21px" Text="Supplier ID"></asp:Label>
        <asp:TextBox ID="txtSupplierID" runat="server" style="z-index: 1; left: 129px; top: 58px; position: absolute; width: 70px"></asp:TextBox>
        <asp:Label ID="lblSupplierName" runat="server" style="z-index: 1; left: 11px; top: 90px; position: absolute" Text="Name"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server" style="z-index: 1; left: 129px; top: 87px; position: absolute; width: 289px"></asp:TextBox>
        <asp:Label ID="lblSupplierEmail" runat="server" style="z-index: 1; left: 11px; top: 120px; position: absolute" Text="Email"></asp:Label>
        <asp:TextBox ID="txtSupplierEmail" runat="server" style="z-index: 1; left: 129px; top: 118px; position: absolute; width: 289px; height: 18px;"></asp:TextBox>
        <asp:TextBox ID="txtSupplierAddress" runat="server" style="z-index: 1; left: 129px; top: 148px; position: absolute; width: 288px"></asp:TextBox>
        <asp:Label ID="lblSupplierAddress" runat="server" style="z-index: 1; left: 11px; top: 150px; position: absolute" Text="Address"></asp:Label>
        <asp:Label ID="lblPhoneNumber" runat="server" style="z-index: 1; left: 11px; top: 183px; position: absolute" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="txtSupplierPhoneNumber" runat="server" style="z-index: 1; left: 129px; top: 181px; position: absolute; width: 288px"></asp:TextBox>
        <asp:Label ID="lblDateCreated" runat="server" style="z-index: 1; left: 11px; top: 214px; position: absolute" Text="Date Created"></asp:Label>
        <asp:TextBox ID="txtSupplierCreatedDate" runat="server" style="z-index: 1; left: 129px; top: 215px; position: absolute; width: 110px"></asp:TextBox>
        <asp:CheckBox ID="chkSupplierActive" runat="server" style="z-index: 1; left: 10px; top: 242px; position: absolute" Text="Active" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 146px; top: 244px; position: absolute; height: 19px" Text=""></asp:Label>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 80px; top: 281px; position: absolute; height: 26px; width: 60px" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 156px; top: 281px; position: absolute; height: 26px; width: 60px" Text="Cancel" />
        <p>
            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 211px; top: 58px; position: absolute; width: 60px; margin-bottom: 1px" Text="Find" OnClick="btnFind_Click" />
        </p>
    </form>
</body>
</html>
