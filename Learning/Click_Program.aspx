<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Click_Program.aspx.cs" Inherits="Learning.Click_Program" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
    <asp:Button ID="clicks" runat="server" Text="Clicks" Width="108px" OnClick="clicks_Click" /><br />
   
    <asp:Label ID="Label1" runat="server" Text="Addition"></asp:Label>
    <asp:TextBox ID="plus" runat="server"></asp:TextBox><br />
    
    <asp:Label ID="Label2" runat="server" Text="Square"></asp:Label>
    <asp:TextBox ID="square" runat="server"></asp:TextBox>
</asp:Content>
