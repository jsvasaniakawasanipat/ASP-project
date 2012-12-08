<%@ Page Title="" Language="C#" MasterPageFile="~/Project/User/UserMaster.master" AutoEventWireup="true" CodeBehind="AddStudent.aspx.cs" Inherits="int422_123b24.Project.User.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div style=" color: #000099;">
        <strong><em style="font-size: x-large; font-family: 'Bookman Old Style'">
        <span style="text-decoration: underline;">Add Student</span><br /></em></strong>
        <br /></div>
    <table class="style1">
        <tr>
            <td align="right">
                Student Name :
            </td>
            <td align="left">
                <asp:TextBox ID="TBStdName" runat="server" Width="137px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                Student Number:
            </td>
            <td align="left">
                <asp:TextBox ID="TBStdNo" runat="server" MaxLength="9" Width="138px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;
            </td>
            <td align="right">
                <asp:Button ID="BTNAddStd" runat="server" Text="Save" Width="80px" BackColor="#999999"
                    BorderColor="#CCCCCC" BorderStyle="Groove" Font-Bold="True" Font-Italic="True"
                    Font-Names="Bookman Old Style" Font-Size="Medium" ForeColor="#0066FF" OnClick="BTNSearch_Click"
                    Style="height: 29px" />
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="LBLerr" runat="server" ForeColor="Red"></asp:Label>
</asp:Content>
