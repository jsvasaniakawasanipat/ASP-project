<%@ Page Title="" Language="C#" MasterPageFile="~/Project/User/UserMaster.master" AutoEventWireup="true" CodeBehind="CommentView.aspx.cs" Inherits="int422_123b24.Project.User.test1" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div style=" color: #000099;">
        <strong><em style="font-size: x-large; font-family: 'Bookman Old Style'">
        <span style="text-decoration: underline;">Student Comments</span><br /></em></strong>
        <br />
        <table style=" width: 700px;">
            <tr>
                <td align="left" width="510px">
                    <asp:Label ID="LBLStdno" runat="server" Font-Bold="True" Font-Underline="True"></asp:Label>
                    <asp:Panel ID="Panel1" runat="server" Width="510px" HorizontalAlign = "Left">
                        <asp:Label ID="LBLDtl" runat="server"></asp:Label>
                    </asp:Panel>
                </td>
                <td align = "left" valign="top" width = "133px">
                    <asp:LinkButton ID="LBSortAdvisor" runat="server" onclick="LBSortAdvisor_Click">Sort By Advisor</asp:LinkButton>
                    <br />
                    <asp:LinkButton ID="LBSortDate" runat="server" onclick="LBSortDate_Click">Sort by Date</asp:LinkButton>
                </td>
            </tr>
            <tr>
                <td width = "510px" align="right">
    <asp:Panel ID="PNLaddComment" runat="server" Width = "350px">
        <div>
            <table align="center" style="width: 307px">
                
                <tr>
                    <td align="right" style="width: 225px">
                        &nbsp;Comment:
                    </td>
                    <td align="left">
                        <CKEditor:CKEditorControl ID="CKEcmt" runat="server" BasePath="/ckeditor/" 
                            Width="231px"></CKEditor:CKEditorControl>
                    </td>
                </tr>
                <tr>
                    <td style="width: 225px">
                        &nbsp;
                    </td>
                    <td align="right">
                        <asp:Button ID="BtnSave" runat="server" Text="Post" onclick="BtnSave_Click" 
                            Width="78px" />
                    </td>
                </tr>
            </table>
            <asp:Label ID="LBLaddCmntErr" runat="server" ForeColor="Red"></asp:Label>
            <br />
        </div>
    </asp:Panel>
                </td>
                <td width = "133px">
                    &nbsp;</td>
            </tr>
        </table>
        <asp:Label ID="LBLerr" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
    </div>
</asp:Content>
