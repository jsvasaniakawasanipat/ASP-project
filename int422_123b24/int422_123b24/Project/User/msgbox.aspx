<%@ Page Title="" Language="C#" MasterPageFile="~/Project/User/UserMaster.master" AutoEventWireup="true" CodeBehind="msgbox.aspx.cs" Inherits="int422_123b24.Project.User.msgbox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table width = "200px">
            <tr>
                <td colspan="2">
                    Are you want to create new comment?</td>
            </tr>
            <tr>
                <td>
        <asp:Button ID="BtnYes" runat="server" Text="Yes" onclick="BtnYes_Click" />
                </td>
                <td>
        <asp:Button ID="BTNNo" runat="server" Text="No" onclick="BTNNo_Click" />
                </td>
            </tr>
        </table>
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
</asp:Content>
