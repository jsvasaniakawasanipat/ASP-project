<%@ Page Title="" Language="C#" MasterPageFile="~/Project/Admin/AdminMaster.master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="int422_123b24.Project.Admin.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="PnlCreateUser" runat="server" Width = "500px">
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" Height="317px" Width="336px" 
        oncreateduser="CreateUserWizard1_CreatedUser1" 
            ContinueDestinationPageUrl="~/Project/Admin/Default.aspx" 
            FinishDestinationPageUrl="~/Project/Admin/Default.aspx" 
            LoginCreatedUser="False">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" Title="Create New User" >
                    <ContentTemplate>
                        <table style="font-family:Verdana;font-size:100%;height:317px;width:413px;">
                            <tr>
                                <td align="center" colspan="2" 
                            style="color:White;background-color:#507CD1;font-weight:bold;">
                                    Create New User</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" 
                                ControlToValidate="UserName" ErrorMessage="User Name is required." 
                                ToolTip="User Name is required." ValidationGroup="CreateUserWizard1" 
                                        Display="Dynamic">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" 
                                ControlToValidate="Password" ErrorMessage="Password is required." 
                                ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="ConfirmPasswordLabel" runat="server" 
                                AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" 
                                ControlToValidate="ConfirmPassword" 
                                ErrorMessage="Confirm Password is required." 
                                ToolTip="Confirm Password is required." 
                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="EmailRequired" runat="server" 
                                ControlToValidate="Email" ErrorMessage="E-mail is required." 
                                ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Security Question:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Question" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" 
                                ControlToValidate="Question" ErrorMessage="Security question is required." 
                                ToolTip="Security question is required." 
                                ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">Security Answer:</asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="Answer" runat="server" ontextchanged="Answer_TextChanged"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" 
                                ControlToValidate="Answer" ErrorMessage="Security answer is required." 
                                ToolTip="Security answer is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Label ID="RoleLabel" runat="server" >Select Role</asp:Label>
                                </td>
                                <td>
                                    <asp:RadioButtonList ID="RBLrole" runat="server" RepeatColumns="2">
                                        <asp:ListItem Value="admin">Admin</asp:ListItem>
                                        <asp:ListItem Value="user">User</asp:ListItem>
                                    </asp:RadioButtonList>
                                    <asp:RequiredFieldValidator ID="RFVRole" runat="server" 
                                ControlToValidate="RBLrole" 
                                ErrorMessage="Role is required." 
                                ToolTip="Role is required." ValidationGroup="CreateUserWizard1"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" class="style1">
                                    <asp:CompareValidator ID="PasswordCompare" runat="server" 
                                ControlToCompare="Password" ControlToValidate="ConfirmPassword" 
                                Display="Dynamic" 
                                ErrorMessage="The Password and Confirmation Password must match." 
                                ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" colspan="2" style="color:Red;">
                                    <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                                    <br />
                                    <asp:Label ID="LblError" runat="server" Text="Label" Visible="False"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep runat="server">
                    <ContentTemplate>
                        <table style="font-family:Verdana;font-size:100%;height:317px;width:336px;">
                            <tr>
                                <td align="center" 
                            style="color:White;background-color:#507CD1;font-weight:bold;">
                                    Complete</td>
                            </tr>
                            <tr>
                                <td>
                                    Your account has been successfully created.</td>
                            </tr>
                            <tr>
                                <td align="right">
                                    <asp:Button ID="ContinueButton" runat="server" BackColor="White" 
                                BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" 
                                CausesValidation="False" CommandName="Continue" Font-Names="Verdana" 
                                ForeColor="#284E98" Text="Continue" ValidationGroup="CreateUserWizard1"/>
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
    </asp:Panel>
</asp:Content>
