<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CalculatorWebService.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Number 1 :
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
        </div>
        Number 2 :
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Operator :
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Add</asp:ListItem>
            <asp:ListItem>Sub</asp:ListItem>
            <asp:ListItem>Mul</asp:ListItem>
            <asp:ListItem>Dev</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
