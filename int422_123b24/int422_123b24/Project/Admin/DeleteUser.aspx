<%@ Page Title="" Language="C#" MasterPageFile="~/Project/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="int422_123b24.Project.Admin.DeleteUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PnlDeleteUser" runat="server" width = "300px">
        <table style="width: 100%">
            <tr>
                <td colspan="2" align="left">
                    Please Select User from the list.</td>
            </tr>
            <tr>
                <td align = "left">
                    <asp:DropDownList ID="DDLusers" runat="server" DataSourceID="SqlDataSource1" 
                        DataTextField="UserName" DataValueField="UserName" Height="20px" 
                        Width="170px">
                    </asp:DropDownList>
                </td>
                <td align = "left">
                    <asp:Button ID="btnUsers0" runat="server" onclick="btnUsers_Click" 
                        Text="DeleteUser" />
                </td>
            </tr>
        </table>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:int422_123b24Entities %>" 
            SelectCommand="SELECT [UserName] FROM [vw_aspnet_Users]">
        </asp:SqlDataSource>
        <br />
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="LblsuccDel" runat="server" ForeColor="#009933" 
                Text="User Deleted Successfully" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="LbldelErr" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </asp:Panel>
</asp:Content>
