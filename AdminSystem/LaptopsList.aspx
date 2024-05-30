<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LaptopsList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="lblUser" runat="server" style="margin-left: 30px"></asp:Label>
        </p>
        <div>
            <asp:ListBox ID="lstLaptopsList" runat="server" Height="426px" Width="458px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" Width="100px" style="margin-left: 40px" />
        <asp:Button ID="btnEdit" runat="server" style="margin-left: 36px; margin-top: 10px" Text="Edit" Width="100px" OnClick="btnEdit_Click" />
        <asp:Button ID="btnDelete" runat="server" style="margin-left: 35px;" Text="Delete" Width="100px" OnClick="btnDelete_Click" />
        <p>
            <asp:Label ID="lblFilter" runat="server" style="margin-left: 30px" Text="Enter a Manufacturer"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="margin-left: 29px; margin-top: 0px" Width="230px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnFilterApply" runat="server" style="margin-left: 50px" Width="150px" Text="Apply Filter" OnClick="btnFilterApply_Click" />
            <asp:Button ID="btnFilterRemove" runat="server" style="margin-left: 40px" Width="150px" Text="Clear Filter" OnClick="btnFilterRemove_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" style="margin-left: 30px" ForeColor="#FF3300"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnMenu" runat="server" style="margin-left: 40px" Text="Return To Main Menu" Width="350px" OnClick="btnMenu_Click"/>
        </p>
    </form>
</body>
</html>
