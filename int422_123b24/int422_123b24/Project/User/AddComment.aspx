<%@ Page Title="" Language="C#" MasterPageFile="~/Project/User/UserMaster.master" AutoEventWireup="true" CodeBehind="AddComment.aspx.cs" Inherits="int422_123b24.Project.User.AddComment" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PNLaddComment" runat="server" Width = "500px">
    <div style=" color: #000099;">
        <strong><em style="font-size: x-large; font-family: 'Bookman Old Style'">
        <span style="text-decoration: underline;">Add Comment</span><br /></em></strong>
        <br /></div>
        <div>
            <table align="center" style="width: 307px">
                
                <tr>
                    <td align= "right" style="width: 225px">
                        Student Number:
                    </td>
                    <td align = "left">
                        <asp:TextBox ID="TBstdId" runat="server" Width="180px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 225px">
                        &nbsp;Comment:
                    </td>
                    <td align="left">
                        <CKEditor:CKEditorControl ID="CKEcmt" runat="server" BasePath="/ckeditor/"></CKEditor:CKEditorControl>
                    </td>
                </tr>
                <tr>
                    <td style="width: 225px">
                        &nbsp;
                    </td>
                    <td align="right">
                        <asp:Button ID="BtnSave" runat="server" Text="Save" onclick="BtnSave_Click" 
                            Width="78px" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="LBLaddCmntErr" runat="server" ForeColor="Red"></asp:Label>
            <br />
        </div>
    </asp:Panel>
</asp:Content>
