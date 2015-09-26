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
    
</asp:Content>
