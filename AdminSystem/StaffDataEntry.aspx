<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Data Entry</title>
    <style>

          .title {
      text-align: left;
      color: #333;
      margin-bottom: 25px;
            height: 33px;
        }
        
          .container {
    width: 500px;
    margin: 40px auto;
    background-color: white;
    padding: 25px;
    border-radius: 10px;
    box-shadow: 0px 0px 10px gray;
}
          
          .main-menu-button {}
        .button {}
        .form-row {
            margin-top: 46px;
        }
    </style>
</head>
<body
    style="height: 618px">
    <form id="form1" runat="server">
        <div>
           <h1 class="title">Staff Data Entry</h1>

        </div>
        <asp:Label ID="lblStaffID" runat="server" style="z-index: 1; left: 10px; top: 53px; position: absolute; height: 28px; width: 80px;" Text="Staff ID"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="z-index: 1; left: 98px; top: 52px; position: absolute; right: 1235px;"></asp:TextBox>
        <asp:Label ID="lblStaffUsername" runat="server" style="z-index: 1; left: 13px; top: 90px; position: absolute" Text="Username" width="75px"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 97px; top: 88px; position: absolute; width: 201px;"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 100px; top: 126px; position: absolute; width: 196px;"></asp:TextBox>
        </p>
        <asp:Label ID="lblStaffPassword" runat="server" style="z-index: 1; left: 10px; top: 129px; position: absolute" Text="Password" width="75px"></asp:Label>
        <p style="height: 39px">
            <asp:Label ID="lblStaffLastName" runat="server" style="z-index: 1; left: 13px; top: 173px; position: absolute; height: 21px" Text="Last Name" width="75px"></asp:Label>
&nbsp;&nbsp;
        </p>
        <p style="height: 70px">
            <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 99px; top: 172px; position: absolute; width: 195px;"></asp:TextBox>
            <asp:Label ID="lblStaffAddress" runat="server" style="z-index: 1; left: 10px; top: 225px; position: absolute; height: 19px; bottom: 292px;" Text="Address" width="75px"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" style="z-index: 1; left: 95px; top: 222px; position: absolute; height: 22px; width: 197px;"></asp:TextBox>
        </p>
       <div class="form-row">
     <asp:Label 
         ID="lblCustomerDOB" 
         runat="server" 
         Text="Date of Birth" 
         CssClass="label">
     </asp:Label>
     <asp:Calendar ID="calCustomerDOB" runat="server" CssClass="calendar" OnSelectionChanged="calCustomerDOB_SelectionChanged"></asp:Calendar>
 </div>
        <div class="form-row">
    <asp:Button ID="Button1" runat="server" OnClick="btnOK_Click" Text="OK" CssClass="button" BackColor="#33CCFF" Height="40px" Width="66px"></asp:Button>
    <asp:Button ID="Button2" runat="server" Text="Cancel" CssClass="button" BackColor="Red" Height="41px" Width="91px"></asp:Button>
    <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Text="Return to Main Menu" CssClass="button main-menu-button" BackColor="#00CCFF" Height="43px" Width="145px"></asp:Button>
</div>
        
        <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 423px; top: 341px; position: absolute; width: 156px; height: 67px;" Text="Active" />
        <p>
    
     <asp:Label ID="lblError" runat="server" Text="" CssClass="error"></asp:Label>
    
        </p>
        <p>
            &nbsp;</p>
    
    </form>

</body>
</html>
