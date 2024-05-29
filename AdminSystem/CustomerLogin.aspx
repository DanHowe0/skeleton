<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerLogin.aspx.cs" Inherits="CustomerLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
 
        <asp:Label ID="tblLoginPage" runat="server" style="z-index: 1; left: 12px; top: 52px; position: absolute" Text="Customer Login Page"></asp:Label>
        <asp:Label ID="tblUserName" runat="server" style="z-index: 1; left: 81px; top: 143px; position: absolute; bottom: 712px" Text="UserName:"></asp:Label>
        <asp:Label ID="tblPassword" runat="server" style="z-index: 1; left: 81px; top: 186px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 177px; top: 142px; position: absolute; width: 134px"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 177px; top: 187px; position: absolute; width: 134px" TextMode="Password"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 353px; top: 164px; position: absolute"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" height="26px" style="z-index: 1; left: 259px; top: 240px; position: absolute; width: 53px" Text="Cancel" />

        </div>

        <asp:Button ID="btnLogIn" runat="server" OnClick="btnLogIn_Click" style="z-index: 1; left: 167px; top: 241px; position: absolute" Text="Log In" />

        
    </form>
</body>
</html>
