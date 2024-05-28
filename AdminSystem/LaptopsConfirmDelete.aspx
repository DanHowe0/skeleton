<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LaptopsConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 115px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="margin-left:50px">
        <div style="margin-top:30px">
            <asp:Label ID="txtDeleteConfirm" runat="server" style="margin-left: 10px; margin-top:20px" Text="Are you sure you want to delete the record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" style="margin-left: 50px; margin-top: 30px;" Width="50px" Text="Yes" OnClick="btnYes_Click" />
        <asp:Button ID="btnNo" runat="server" style="margin-left: 50px" Width="50px" Text="No" OnClick="btnNo_Click" />
    </form>
</body>
</html>
