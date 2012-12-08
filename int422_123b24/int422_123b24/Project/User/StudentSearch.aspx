<%@ Page Title="" Language="C#" MasterPageFile="~/Project/User/UserMaster.master" AutoEventWireup="true" CodeBehind="StudentSearch.aspx.cs" Inherits="int422_123b24.Project.User.test3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style=" color: #000099;">
        <strong><em style="font-size: x-large; font-family: 'Bookman Old Style'">
        <span style="text-decoration: underline;">Search Comments for Student</span><br /></em></strong>
        <br /></div>
    <table class="style1" width="440">
        <tr>
            <td align = "right">
                Please Enter Student Number:</td>
            <td align = "left">
                <asp:TextBox ID="TBStdid" runat="server" MaxLength="9" align="left" 
                    Height="20px" Width="145px" ></asp:TextBox>
            </td>
            <td align = "center" rowspan="2">
                <asp:Button ID="BTNSearch" runat="server" Text="Search" Width="80px" 
                    BackColor="#999999" BorderColor="#CCCCCC" BorderStyle="Groove" Font-Bold="True" 
                    Font-Italic="True" Font-Names="Bookman Old Style" Font-Size="Medium" 
                    ForeColor="#0066FF" onclick="BTNSearch_Click" style="height: 29px" />
            </td>
        </tr>
        <tr>
            <td align ="right">
                 Or Select Student Number:</td>
            <td align = "left">
                <asp:DropDownList ID="DDLStdid" runat="server" Width="145px" 
                    DataSourceID="SqlDataSource1" DataTextField="student_id" 
                    DataValueField="student_id">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:int422_123b24Entities %>" 
        SelectCommand="SELECT [student_id] FROM [student]"></asp:SqlDataSource>
    <asp:Label ID="LBLerr" runat="server" ForeColor="Red"></asp:Label>
    <br />
</asp:Content>
