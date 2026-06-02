<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Data Entry</title>

    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
        }

        .container {
            width: 500px;
            margin: 40px auto;
            background-color: white;
            padding: 25px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px gray;
        }

        .title {
            text-align: center;
            color: #333;
            margin-bottom: 25px;
        }

        .form-row {
            margin-bottom: 15px;
        }

        .label {
            display: block;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .textbox {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }

        .checkbox {
            margin-top: 5px;
        }

        .calendar {
            margin-top: 10px;
        }

        .button {
            background-color: #0078D7;
            color: white;
            padding: 10px 15px;
            border: none;
            border-radius: 5px;
            margin-right: 10px;
            cursor: pointer;
        }

        .button:hover {
            background-color: #005fa3;
        }

        .main-menu-button {
            background-color: #555;
        }

        .main-menu-button:hover {
            background-color: #333;
        }

        .error {
            color: red;
            font-weight: bold;
            display: block;
            margin-top: 15px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <div class="container">

            <h1 class="title">Customer Data Entry</h1>

            <div class="form-row">
                <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCustomerID" runat="server" CssClass="textbox"></asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Label ID="lblCustomerFirstName" runat="server" Text="First Name" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCustomerFirstName" runat="server" CssClass="textbox"></asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Label ID="lblCustomerEmail" runat="server" Text="Email" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCustomerEmail" runat="server" CssClass="textbox"></asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Label ID="lblCustomerPassword" runat="server" Text="Password" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCustomerPassword" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Label ID="lblCustomerAddress" runat="server" Text="Address" CssClass="label"></asp:Label>
                <asp:TextBox ID="txtCustomerAddress" runat="server" CssClass="textbox"></asp:TextBox>
            </div>

            <div class="form-row">
                <asp:Label ID="lblActive" runat="server" Text="Active" CssClass="label"></asp:Label>
                <asp:CheckBox ID="chkActive" runat="server" CssClass="checkbox"></asp:CheckBox>
            </div>

            <div class="form-row">
                <asp:Label 
                    ID="lblCustomerDOB" 
                    runat="server" 
                    Text="Date of Birth" 
                    CssClass="label">
                </asp:Label>
                <asp:Calendar ID="calCustomerDOB" runat="server" CssClass="calendar"></asp:Calendar>
            </div>

            <div class="form-row">
                <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" CssClass="button"></asp:Button>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" CssClass="button"></asp:Button>
                <asp:Button ID="btnMainMenu" runat="server" OnClick="btnMainMenu_Click" Text="Return to Main Menu" CssClass="button main-menu-button"></asp:Button>
            </div>

            <asp:Label ID="lblError" runat="server" Text="" CssClass="error"></asp:Label>

        </div>
    </form>
</body>
</html>