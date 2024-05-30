<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LaptopsLogin.aspx.cs" Inherits="LaptopsLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="lblTitle" runat="server" Text="Laptops Login Page" style="margin-left: 100px"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblUser" runat="server" Text="Username:" style="margin-left: 30px"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server" style="margin-left: 30px; margin-top: 40px" Width="200px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPass" runat="server" Text="Password:" style="margin-left: 30px"></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" style="margin-left: 30px" Width="200px" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" style="margin-left: 89px" Text="Login" Width="70px" OnClick="btnLogin_Click" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 40px" Text="Cancel" Width="70px" OnClick="btnCancel_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="margin-left: 50px" ForeColor="#FF3300"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnMenu" runat="server" style="margin-left: 40px" Text="Return To Main Menu" Width="350px" />
        </p>
    </form>
</body>
</html>
