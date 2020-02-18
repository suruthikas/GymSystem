<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnEquipment.aspx.cs" Inherits="AnEquipment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 309px">
    <form id="form1" runat="server">
        EquipmentID
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 78px"></asp:TextBox>
        <p>
            Equipment Description<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 23px"></asp:TextBox>
        </p>
        Equipment Colour<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 48px"></asp:TextBox>
        <p>
            Equipment Date Added<asp:TextBox ID="TextBox5" runat="server" style="margin-left: 13px" Width="121px"></asp:TextBox>
        </p>
        Equipment Price
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 54px"></asp:TextBox>
        <p>
            Equipment Available<asp:TextBox ID="TextBox6" runat="server" style="margin-left: 36px; margin-bottom: 1px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
