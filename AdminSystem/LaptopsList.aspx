<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LaptopsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstLaptopsList" runat="server" Height="426px" Width="458px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="70px" style="margin-left: 25px" />
        <asp:Button ID="btnEdit" runat="server" style="margin-left: 30px; margin-top: 10px" Text="Edit" Width="69px" OnClick="btnEdit_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" style="margin-left: 30px"></asp:Label>
        </p>
    </form>
</body>
</html>
