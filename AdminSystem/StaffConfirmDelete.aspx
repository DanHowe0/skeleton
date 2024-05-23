<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Decision" runat="server" style="z-index: 1; left: 240px; top: 37px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="buttonNo" runat="server" OnClick="buttonNo_Click" style="z-index: 1; left: 454px; top: 98px; position: absolute" Text="No" />
        <asp:Button ID="buttonYes" runat="server" OnClick="buttonYes_Click" style="z-index: 1; left: 247px; top: 99px; position: absolute" Text="Yes" />
    </form>
</body>
</html>
