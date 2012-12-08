<%@ Page Title="" Language="C#" MasterPageFile="~/templates/Project.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="int422_123b24.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
<asp:HyperLink ID="HyperLink1" runat="server" 
    NavigateUrl="~/Project/Admin/Default.aspx">Admin</asp:HyperLink>
<br />
<asp:HyperLink ID="HyperLink2" runat="server" 
    NavigateUrl="~/Project/User/Default.aspx">User</asp:HyperLink>
<br />
<asp:HyperLink ID="HyperLink3" runat="server" 
    NavigateUrl="~/Project/Public/Default.aspx">public</asp:HyperLink>
<br />
</asp:Content>
