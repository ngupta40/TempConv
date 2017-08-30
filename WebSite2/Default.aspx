<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Button ID="C2F" runat="server" OnClick="C2F_Click" Text="C2F" />
<asp:Button ID="F2C" runat="server" Text="F2C" OnClick="F2C_Click" />
<asp:TextBox ID="TextBox1" runat="server" Height="103px" Width="787px"></asp:TextBox>

</asp:Content>
