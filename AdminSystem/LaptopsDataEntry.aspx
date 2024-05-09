<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LaptopsDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0;
            text-align: center;
        }
        .auto-style2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1">
        <asp:Label ID="lblLaptopID" runat="server" Text="Laptop ID" width="130px"></asp:Label>
        <asp:TextBox ID="txtLaptopID" runat="server" Width="183px"></asp:TextBox>
        </p>
        <p class="auto-style1">
        <asp:Label ID="lblLaptopModel" runat="server" Text="Model" width="130px"></asp:Label>
        <asp:TextBox ID="txtLaptopModel" runat="server" Width="191px"></asp:TextBox>
        </p>
        <p class="auto-style1">
        <asp:Label ID="lblLaptopManufacturer" runat="server" Text="Manufacturer" width="130px"></asp:Label>
        <asp:TextBox ID="txtLaptopManufacturer" runat="server" Width="191px"></asp:TextBox>
        </p>
        <p class="auto-style1">
        <asp:Label ID="lblLaptopQuantity" runat="server" Text="Quantity" width="130px"></asp:Label>
        <asp:TextBox ID="txtLaptopQuantity" runat="server" Width="191px"></asp:TextBox>
        </p>
        <p class="auto-style1">
        <asp:Label ID="lblLaptopPrice" runat="server" Text="Price" width="130px"></asp:Label>
        <asp:TextBox ID="txtLaptopPrice" runat="server" Width="191px"></asp:TextBox>
        </p>
        <p class="auto-style2">
        <asp:CheckBox ID="chkLaptopReorder" runat="server" Text="Reorder" />
        </p>
        <p class="auto-style1">
        <asp:Label ID="lblLaptopReorderDate" runat="server" Text="Reorder Date" width="130px"></asp:Label>
        <asp:TextBox ID="txtLaptopReorderDate" runat="server" Width="191px"></asp:TextBox>
        </p>
        <p class="auto-style2">
        <asp:Label ID="lblError" runat="server" style="text-align: center"></asp:Label>
        </p>
        <p class="auto-style2">
            <asp:Button ID="btnOk" runat="server" style="margin-left: 30px" Text="OK" Width="100px" OnClick="btnOk_Click" />
            <asp:Button ID="btnCancel" runat="server" style="margin-left: 30px" Text="Cancel" Width="100px" />
        </p>
    </form>
</body>
</html>
