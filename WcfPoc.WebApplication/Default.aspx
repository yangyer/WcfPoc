<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WcfPoc.WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="txtNum1" runat="server" Text="2"></asp:TextBox>
    <asp:TextBox ID="txtNum2" runat="server" Text="4"></asp:TextBox>=
    <asp:TextBox ID="txtSum" runat="server"></asp:TextBox>

    <asp:Button ID="btnRun" runat="server" Text="Run" OnClick="btnRun_Click" />
</asp:Content>
