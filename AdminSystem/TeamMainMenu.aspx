<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #form1 {
            background-color: #3399FF;
        }
        .auto-style2 {
            font-weight: bold;
        }
    </style>
</head>
<body style="height: 375px; background-color: #3399FF">
    <form id="form1" runat="server">
        <div class="auto-style1">
        <div>
        </div>
            <p>
                &nbsp;</p>
            <p>
                <asp:Label ID="lblHeading" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 273px; top: 44px; position: absolute; text-align: center; color: #FFFFFF; font-weight: 700" Text="Team 2DK Login Page"></asp:Label>
            </p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p class="auto-style1">
                &nbsp;</p>
            <asp:Button ID="btnLaptop" runat="server" CssClass="auto-style2" OnClick="btnLaptop_Click" style="margin-left: 0px; background-color: #FFFFFF" Text="Laptop" Width="59px" />
            <asp:Button ID="btnStaff" runat="server" CssClass="auto-style2" OnClick="btnStaff_Click" style="background-color: #FFFFFF" Text="Staff" Width="52px" />
            <asp:Button ID="btnCustomer" runat="server" CssClass="auto-style2" OnClick="btnCustomer_Click" style="background-color: #FFFFFF" Text="Customer" Width="76px" />
            <p class="auto-style1">
                &nbsp;</p>
        </div>
    </form>
</body>
</html>
