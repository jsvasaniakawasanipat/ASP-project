<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Lab3.aspx.cs" Inherits="int422_123b24.Lab3.Lab3" MasterPageFile="~/templates/Labs.Master" Title="Lab 3" %>

<asp:Content ID="Body" runat="server" ContentPlaceHolderID="Main">

    <asp:Panel ID="PNL1" runat="server" Width = "590px" BackColor="#9933FF" 
        BorderColor="#990000" BorderStyle="Double">
<center>
    <asp:Label ID = "HD" runat="server" Text="LAB 3" BorderColor="#660033" 
        BorderStyle="Double" Font-Bold="True" Font-Italic="True" 
        Font-Names="Bookman Old Style" Font-Overline="False" Font-Size="X-Large"  
        Font-Underline="True" ForeColor="#FFFF99" Width="580px"></asp:Label>
        </center>

        <asp:Panel ID="Panel1" runat="server" BorderColor="Maroon" BorderStyle="Double" 
            Height="120px" HorizontalAlign="Left" Width="585px">
            <asp:Label ID="Label2" runat="server" ForeColor="#6699FF" Text="Upload File"></asp:Label>
            <br />
            <br />
            <asp:FileUpload ID="FileUpload" runat="server" />
            <br />
            <br />
            <asp:Button ID="BTNupload" runat="server" BackColor="#99FF66" 
                BorderColor="#99FFCC" BorderStyle="Groove" BorderWidth="5px" Font-Bold="True" 
                Font-Italic="True" ForeColor="#6600FF" OnClick="UploadButton_Click" 
                Text="Upload" Width="95px" />
            &nbsp;
            <asp:Label ID="LBLFileUploadMsg" runat="server"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="Panal2" runat="server" BorderColor="Maroon" BorderStyle="Double" 
            Height="213px" Width="585px">
        
            &nbsp;&nbsp;
                <asp:LinkButton ID="LBFileList0" runat="server" Font-Bold="True" 
                Font-Italic="True" Font-Names="Bookman Old Style" 
                OnClick="FileListButton_Click">File List</asp:LinkButton>
            
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />           
                <asp:ListBox ID="FileListBox" runat="server" Font-Names="Bookman Old Style" 
                Height="165px" onselectedindexchanged="FileListBox_SelectedIndexChanged" 
                Rows="5" Visible="False" Width="252px"></asp:ListBox>
            
        </asp:Panel>
        <asp:Panel ID="Panel3" runat="server" BorderColor="Maroon" BorderStyle="Double"
            Height="400px" Width="585px">
            &nbsp;
            <asp:Button ID="BTNFileRead1" runat="server" BackColor="#666666" 
                BorderColor="#999966" BorderStyle="Outset" Font-Bold="True" Font-Italic="True" 
                Font-Names="Bookman Old Style" ForeColor="#990099" 
                OnClick="FileReadButton_Click" Text="Open Document" Width="130px" />
            &nbsp;&nbsp;
            <asp:Button ID="BTNCopyFile2" runat="server" BackColor="#666666" 
                BorderColor="#999966" BorderStyle="Outset" Font-Bold="True" Font-Italic="True" 
                Font-Names="Bookman Old Style" ForeColor="#990099" 
                OnClick="CopyFileButton_Click" Text="Copy File" Width="130px" />
            &nbsp;&nbsp;
            <asp:Button ID="BTNsearch" runat="server" BackColor="#666666" 
                BorderColor="#999966" BorderStyle="Outset" Font-Bold="True" Font-Italic="True" 
                Font-Names="Bookman Old Style" ForeColor="#990099" 
                Text="Search" Width="130px" onclick="BTNsearch_Click" />
            &nbsp;&nbsp;
            <asp:Button ID="BTNClose" runat="server" BackColor="#666666" 
                BorderColor="#999966" BorderStyle="Outset" Font-Bold="True" Font-Italic="True" 
                Font-Names="Bookman Old Style" ForeColor="#990099" onclick="CloseButton_Click" 
                Text="Close File" Width="130px" />
            <br />
                 <asp:Label ID="LBLFileErrorMsg" runat="server" ForeColor="Red" 
                    Visible="False" Width="265px"></asp:Label>
                <asp:Label ID="lblsrch" runat="server" Text="Please Enter Search String"></asp:Label>
                &nbsp;
                <asp:TextBox ID="TBsrch" runat="server" Width="140px"></asp:TextBox>

                <asp:TextBox ID="TBDisplayFile" runat="server"
                    ReadOnly="True" TextMode="MultiLine" Visible="False" Width="99%" 
                    Rows="20"></asp:TextBox>
        
        </asp:Panel>
        
               
            
         
      
    </asp:Panel>
</asp:Content>

