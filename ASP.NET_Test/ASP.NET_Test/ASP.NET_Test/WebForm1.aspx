<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP.NET_Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label6" runat="server">czas: </asp:Label>
&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Zapisz" Width="85px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Pierwsze wywolanie strony:"></asp:Label>
&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="-"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Kolejne wywolanie strony:"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text="-"></asp:Label>
&nbsp;</div>
    </form>
</body>
</html>
