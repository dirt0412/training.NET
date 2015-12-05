<%@ Page Title="" Language="C#" MasterPageFile="~/Glowna.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyMasterPage.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" AutoPostBack="true" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="215px">
        <asp:ListItem Selected="True" Value="Glowna.Master">Glowna</asp:ListItem>
        <asp:ListItem Value="Druga.Master">Druga</asp:ListItem>
    </asp:DropDownList>
    
    <asp:Button ID="Button1" runat="server" Text="Button" />
   
    <div>    
        <asp:Label ID="Label6" runat="server">czas: </asp:Label>
&nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True"></asp:Label>
        <br />
        <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Refresh ViewState" Width="130px" />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Pierwsze wywolanie strony:"></asp:Label>
&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="-"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Kolejne wywolanie strony:"></asp:Label>
&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Font-Bold="True" ForeColor="Red" Text="-"></asp:Label>
&nbsp;</div>
   
</asp:Content>
