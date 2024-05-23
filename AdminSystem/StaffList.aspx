<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        
        <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 89px; top: 15px; position: absolute; height: 378px; width: 192px"></asp:ListBox>

        
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 412px; top: 199px; position: absolute"></asp:Label><blocked-overlay-rect height="2" width="58" top="53" left="0"><br class="Apple-interchange-newline"><div class="blockedOverlayRect" style="position: absolute; cursor: not-allowed; background-color: rgba(0, 0, 0, 0.3); pointer-events: auto; top: 0px; left: 0px; width: 58px; height: 2px;"></div></blocked-overlay-rect><blocked-overlay-rect height="2" width="73" top="53" left="679"><div class="blockedOverlayRect" style="position: absolute; cursor: not-allowed; background-color: rgba(0, 0, 0, 0.3); pointer-events: auto; top: 53px; left: 679px; width: 73px; height: 2px;"></div></blocked-overlay-rect><blocked-overlay-rect height="277" width="752" top="413" left="0">
        <asp:Button ID="buttonAdd" runat="server"  style="z-index: 1; left: 59px; top: 424px; position: absolute; width: 44px" Text="Add" height="26px" OnClick="buttonAdd_Click" />
        </blocked-overlay-rect><blocked-overlay-rect height="340" width="58" top="73" left="0"><span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;"></span><br class="Apple-interchange-newline">

            <asp:Button ID="buttonEdit" runat="server" style="z-index: 1; left: 135px; top: 425px; position: absolute; width: 44px" Text="Edit" OnClick="buttonEdit_Click1" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Button ID="buttonDelete" runat="server" style="z-index: 1; left: 220px; top: 424px; position: absolute; width: 48px; height: 26px" Text="Delete" OnClick="buttonDelete_Click1" />
        <asp:Label ID="Name" runat="server" style="z-index: 1; left: 74px; top: 496px; position: absolute" Text="Enter a Name "></asp:Label>
        <p>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 197px; top: 493px; position: absolute"></asp:TextBox>
        </p>
        <asp:Button ID="ApplyFilter" runat="server" style="z-index: 1; left: 57px; top: 551px; position: absolute" Text="Apply Filter " OnClick="ApplyFilter_Click1" />
        <p>
            <asp:Button ID="ClearFilter" runat="server" style="z-index: 1; left: 247px; top: 549px; position: absolute" Text="Clear Filter" OnClick="ClearFilter_Click" />
        </p>
        </form>
</body>
</html>
