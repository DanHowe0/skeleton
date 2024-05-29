<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffLogin.aspx.cs" Inherits="StaffLogin" %>

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
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblStaff" runat="server" style="z-index: 1; left: 366px; top: 172px; position: absolute" Text="Staff Login Page"></asp:Label>
        </p>
        <asp:Label ID="lblUserName" runat="server" style="z-index: 1; left: 295px; top: 218px; position: absolute" Text="UserName"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" style="z-index: 1; left: 294px; top: 259px; position: absolute" Text="Password"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" style="z-index: 1; left: 408px; top: 218px; position: absolute"></asp:TextBox>
        <p>
            <asp:TextBox ID="txtPassword" runat="server" style="z-index: 1; left: 409px; top: 259px; position: absolute" TextMode="Password"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="buttonLogIn" runat="server" height="26px" OnClick="buttonLogIn_Click" style="z-index: 1; left: 332px; top: 318px; position: absolute" Text="LogIn" width="60px" />
        </p>
        <p>
            <asp:Button ID="ButtonCancel" runat="server" style="left: 451px; top: 317px; position: absolute; bottom: 322px" Text="Cancel" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" style="z-index: 1; left: 385px; top: 387px; position: absolute"></asp:Label>
        </p>
    </form>
</body>
</html>
