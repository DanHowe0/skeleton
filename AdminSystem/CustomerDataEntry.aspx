<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 247px">
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 116px; top: 34px; position: absolute" width="128px"></asp:TextBox>
        </div>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblCustomerNo" runat="server" style="z-index: 1; left: 19px; top: 36px; position: absolute; bottom: 607px; width: 81px" Text="CustomerNo"></asp:Label>
        <asp:Label ID="lblFirstName" runat="server" height="22px" style="z-index: 1; left: 19px; top: 67px; position: absolute; right: 557px" Text="First Name" width="81px"></asp:Label>
        <asp:Label ID="lblLastName" runat="server" height="22px" style="z-index: 1; left: 19px; top: 98px; position: absolute; bottom: 543px; width: 81px; margin-bottom: 0px" Text="Last Name"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" height="22px" style="z-index: 1; left: 19px; top: 130px; position: absolute" Text="DOB" width="81px"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" height="22px" style="z-index: 1; left: 19px; top: 162px; position: absolute" Text="Email" width="81px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 116px; top: 66px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 116px; top: 95px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 116px; top: 127px; position: absolute; margin-bottom: 0px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 116px; top: 160px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 116px; top: 197px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Label ID="lblAddress" runat="server" height="22px" style="z-index: 1; left: 19px; top: 196px; position: absolute" Text="Address" width="81px"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkHas2SV" runat="server" style="z-index: 1; left: 150px; top: 234px; position: absolute" Text="Has2SV" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 18px; top: 234px; position: absolute"></asp:Label>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 18px; top: 277px; position: absolute; height: 20px; width: 33px" Text="Ok" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 64px; top: 277px; position: absolute; height: 19px; width: 60px; margin-bottom: 2px" Text="Cancel" />
    </form>
</body>
</html>
