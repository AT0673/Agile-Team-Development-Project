<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body
    style="height: 403px">
    <form id="form1" runat="server">
        <div>
            Staff Data Entry<br />
        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute" Text="Staff ID" width="75px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 98px; top: 52px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 8px; top: 398px; position: absolute; width: 52px; height: 28px;" Text="OK" OnClick="btnOK_Click" />
        <asp:Label ID="lblStaffUsername" runat="server" style="z-index: 1; left: 13px; top: 90px; position: absolute" Text="Username" width="75px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 97px; top: 88px; position: absolute" width="128px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 100px; top: 126px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Password" width="75px"></asp:Label>
        <p style="height: 39px">
            <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 13px; top: 173px; position: absolute; height: 21px" Text="Last Name" width="75px"></asp:Label>
&nbsp;&nbsp;
        </p>
        <p style="height: 39px">
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 99px; top: 172px; position: absolute" width="128px"></asp:TextBox>
            <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 10px; top: 225px; position: absolute; height: 19px; bottom: 292px;" Text="Address" width="75px"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 95px; top: 222px; position: absolute; height: 22px;" width="128px"></asp:TextBox>
        </p>
        <p style="height: 32px">
            <asp:Label ID="lblStaffDOB" runat="server" style="z-index: 1; left: 10px; top: 282px; position: absolute" Text="DOB"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" style="z-index: 1; left: 99px; top: 281px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 97px; top: 333px; position: absolute" Text="Active" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 108px; top: 397px; position: absolute; height: 30px" Text="Cancel" OnClick="btnCancel_Click" width="52px" />
    </form>
</body>
</html>
