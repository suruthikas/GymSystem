<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Order No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 21px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Equipment Ordered<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 10px"></asp:TextBox>
            <br />
            Total Cost<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 66px"></asp:TextBox>
            <br />
            Customer Name<asp:TextBox ID="TextBox4" runat="server" style="margin-left: 31px; margin-bottom: 0px"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <br />
            Date Ordered<asp:TextBox ID="TextBox6" runat="server" style="margin-left: 46px"></asp:TextBox>
        </div>
        <p>
            <asp:CheckBox runat="server" Text="Order Processed" />
        </p>
        <asp:Button ID="BtnOK" runat="server" OnClick="BtnOK_Click" style="height: 26px" Text="Button" />
    </form>
</body>
</html>
