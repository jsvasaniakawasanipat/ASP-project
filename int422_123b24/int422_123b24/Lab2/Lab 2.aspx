<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab 2.aspx.cs" Inherits="int422_123b24.Lab2.Lab_2" MasterPageFile="~/templates/Labs.Master" %>
<%@ Register Src="~/Lab2/Lab2.ascx" TagName="stdnt" TagPrefix="uc1" %>
<asp:Content ID="Body" runat="server" ContentPlaceHolderID="Main">


    


    <asp:Panel ID="PNLget" runat="server" Height="367px" Width="938px">
        &nbsp;<br />
        <asp:Label ID="Label2" runat="server" Text="First Name : " Width="90px"></asp:Label>
&nbsp;<asp:TextBox ID="TBfnm" runat="server" Width="174px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFVfname" runat="server" 
            ControlToValidate="TBfnm" ErrorMessage="You Must Enter Valid First Name" 
            ForeColor="Red" ValidationGroup="enter"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Last Name : " Width="90px"></asp:Label>
&nbsp;<asp:TextBox ID="TBlnm" runat="server" Width="174px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFVLname" runat="server" 
            ControlToValidate="TBlnm" ErrorMessage="You Must Enter Valid Last Name" 
            ForeColor="Red" ValidationGroup="enter"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label4" runat="server" Text="E-Mail ID : " Width="90px"></asp:Label>
        &nbsp;<asp:TextBox ID="TBemail" runat="server" Width="175px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFVEmail" runat="server" 
            ControlToValidate="TBemail" ErrorMessage="You Must Enter Valid E-mail Address" 
            ForeColor="Red" ValidationGroup="enter"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="TBemail" ErrorMessage="You Must Enter Valid E-mail Address" 
            ForeColor="Red" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            ValidationGroup="enter"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Student ID" Width="90px"></asp:Label>
&nbsp;<asp:TextBox ID="TBsid" runat="server" Width="175px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RFVsid" runat="server" 
            ControlToValidate="TBsid" ErrorMessage="You Must Enter Student Number" 
            ForeColor="Red" ValidationGroup="enter"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
            ControlToValidate="TBsid" 
            ErrorMessage="Please Enter Student Number in valid Format 0nnnnnnnn or 0nn-nnn-nnn" 
            ForeColor="Red" ValidationExpression="^0(\d{2})(-\d{3})(-\d{3})|0(\d{8})$" 
            ValidationGroup="enter"></asp:RegularExpressionValidator>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DDLcource" runat="server" 
            style="margin-bottom: 0px" Width="174px" 
            onselectedindexchanged="DDLcource_SelectedIndexChanged" 
            AutoPostBack="True">
            <asp:ListItem>Please Select Program Here</asp:ListItem>
            <asp:ListItem>CPD</asp:ListItem>
            <asp:ListItem>CPA</asp:ListItem>
            <asp:ListItem>DAD</asp:ListItem>
            <asp:ListItem>CTY</asp:ListItem>
            <asp:ListItem>IFS</asp:ListItem>
            <asp:ListItem>BSD</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:RadioButtonList ID="RBL2sem" runat="server" AutoPostBack="True" 
            CellPadding="3" CellSpacing="3" 
            onselectedindexchanged="RBL2sem_SelectedIndexChanged" 
            RepeatDirection="Horizontal" Visible="False" Width="217px">
            <asp:ListItem>Semester 1</asp:ListItem>
            <asp:ListItem>Semester 2</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButtonList ID="RBL4sem" runat="server" CellPadding="3" 
            CellSpacing="3" RepeatDirection="Horizontal" Visible="False" Width="434px" 
            AutoPostBack="True" onselectedindexchanged="RBL4sem_SelectedIndexChanged">
            <asp:ListItem>Semester 1</asp:ListItem>
            <asp:ListItem>Semester 2</asp:ListItem>
            <asp:ListItem>Semester 3</asp:ListItem>
            <asp:ListItem>Semester 4</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButtonList ID="RBL6sem" runat="server" CellPadding="3" 
            CellSpacing="3" RepeatDirection="Horizontal" Visible="False" Width="645px" 
            AutoPostBack="True" onselectedindexchanged="RBL6sem_SelectedIndexChanged">
            <asp:ListItem>Semester 1</asp:ListItem>
            <asp:ListItem>Semester 2</asp:ListItem>
            <asp:ListItem>Semester 3</asp:ListItem>
            <asp:ListItem>Semester 4</asp:ListItem>
            <asp:ListItem>Semester 5</asp:ListItem>
            <asp:ListItem>Semester 6</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RadioButtonList ID="RBL8sem" runat="server" CellPadding="3" 
            CellSpacing="3" RepeatDirection="Horizontal" Visible="False" Width="861px" 
            AutoPostBack="True" onselectedindexchanged="RBL8sem_SelectedIndexChanged">
            <asp:ListItem>Semester 1</asp:ListItem>
            <asp:ListItem>Semester 2</asp:ListItem>
            <asp:ListItem>Semester 3</asp:ListItem>
            <asp:ListItem>Semester 4</asp:ListItem>
            <asp:ListItem>Semester 5</asp:ListItem>
            <asp:ListItem>Semester 6</asp:ListItem>
            <asp:ListItem>Semester 7</asp:ListItem>
            <asp:ListItem>Semester 8</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BTNsbmt" runat="server" Text="Submit" BackColor="#CC00CC" 
            BorderColor="Blue" BorderStyle="Groove" BorderWidth="4px" ForeColor="Lime" 
            ValidationGroup="enter" Visible="False" onclick="BTNsbmt_Click" />
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BTNsbmt0" runat="server" BackColor="#CC00CC" BorderColor="Blue" 
            BorderStyle="Groove" BorderWidth="4px" ForeColor="Lime" onclick="BTNsbmt_Click" 
            Text="Submit" ValidationGroup="enter" Visible="False" />
    
    </asp:Panel>
    <br />
    <br />
    <asp:Panel ID="PNLshow" runat="server" Visible="False">
        <uc1:stdnt id="std1" runat="server" />
    </asp:Panel>
    <br />
    </asp:Content>
