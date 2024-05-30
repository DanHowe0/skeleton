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
        <asp:Label ID="lblFirstName" runat="server" height="22px" style="z-index: 1; left: 16px; top: 110px; position: absolute; " Text="First Name" width="81px"></asp:Label>
        <asp:Label ID="lblEmail" runat="server" height="22px" style="z-index: 1; left: 16px; top: 254px; position: absolute" Text="Email" width="81px"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 112px; top: 110px; position: absolute" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtDOB" runat="server" style="z-index: 1; left: 112px; top: 207px; position: absolute; margin-bottom: 0px" width="128px"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 111px; top: 298px; position: absolute" width="128px"></asp:TextBox>
        <asp:Label ID="lblLastName" runat="server" height="22px" style="z-index: 1; left: 16px; top: 156px; position: absolute; bottom: 498px; width: 81px; margin-bottom: 0px" Text="Last Name"></asp:Label>
        <p>
            <asp:Label ID="lblAddress" runat="server" height="22px" style="z-index: 1; left: 16px; top: 299px; position: absolute" Text="Address" width="81px"></asp:Label>
        <asp:Label ID="lblDOB" runat="server" height="22px" style="z-index: 1; left: 16px; top: 209px; position: absolute" Text="DOB" width="81px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" style="z-index: 1; left: 111px; top: 156px; position: absolute" width="128px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:CheckBox ID="chkHas2SV" runat="server" style="z-index: 1; left: 146px; top: 346px; position: absolute" Text="Has2SV" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 19px; top: 385px; position: absolute"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="z-index: 1; left: 112px; top: 251px; position: absolute" width="128px"></asp:TextBox>
        <p>
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" style="z-index: 1; left: 90px; top: 429px; position: absolute; height: 20px; width: 33px" Text="Ok" />
        </p>
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 167px; top: 428px; position: absolute; height: 19px; width: 60px; margin-bottom: 2px" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 153px; top: 69px; position: absolute; width: 53px" Text="Find" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" style="z-index: 1; left: 268px; top: 425px; position: absolute" Text="Return to Main Menu" />
    </form>
</body>
</html>
