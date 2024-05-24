<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 73px; top: 388px; position: absolute; height: 22px; width: 50px" Text="Edit" />
            <asp:ListBox ID="lstCustomerList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 345px; width: 475px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 11px; top: 388px; position: absolute; height: 22px;" Text="Add" width="50px" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 12px; top: 532px; position: absolute"></asp:Label>
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 134px; top: 388px; position: absolute; height: 22px; width: 50px" Text="Delete" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 11px; top: 490px; position: absolute; width: 98px; height: 22px; right: 500px" Text="Apply Filter" />
        <asp:Button ID="btnClear" runat="server" height="22px" OnClick="btnClear_Click" style="z-index: 1; left: 125px; top: 490px; position: absolute" Text="Clear Filter" width="98px" />
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 18px; top: 446px; position: absolute" Text="Enter a Address"></asp:Label>
        <asp:TextBox ID="txtEnterAddress" runat="server" style="z-index: 1; left: 132px; top: 445px; position: absolute; height: 17px; width: 212px"></asp:TextBox>
    </form>
</body>
</html>
