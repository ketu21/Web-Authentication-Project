<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Settings.aspx.cs" Inherits="Settings" Title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    .auto-style2 {
        width: 1027px;
    }
    .auto-style3 {
        height: 30px;
        width: 1027px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;">
        <tr>
            <td width="40%">
                &nbsp;
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/index.jpeg" Height="231px" Width="224px" />
            </td>
            <td>
               <table style="width: 100%;">
        <tr>
         <td colspan ="3" align="center" bgcolor="#6699FF">
             <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                 ForeColor="#FF3300" 
                 Text="Modifications "></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtfnm" runat="server"  Width="208px" OnTextChanged="txtfnm_TextChanged" ></asp:TextBox>
            </td>
        </tr>
       
        <tr>
            <td align="right" class="auto-style2">
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtlnm" runat="server" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style2">
                <%--&nbsp;--%>
                <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtadd" runat="server" Width="209px" ></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td align="right" class="auto-style2">
                &nbsp;
                <asp:Label ID="Label3" runat="server" Text="Gmail Account Login ID."></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtLoginId" runat="server" Width="210px" ></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td align="right" class="auto-style2">
                &nbsp;
                <asp:Label ID="Label6" runat="server" Text="Gmail Account Password"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtPwd" runat="server"  
                    TextMode="Password" Width="210px"></asp:TextBox>
            </td>
        </tr>
                   <tr>
            <td align="right" class="auto-style2">
                &nbsp;
                <asp:Label ID="Label7" runat="server" Text="Yahoo Account Login ID."></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtLoginId2" runat="server" Width="210px"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label8" runat="server" Text="Yahoo Account Password"></asp:Label>
            </td>
            <td class="auto-style1">
                &nbsp;
                <asp:TextBox ID="txtPwd2" runat="server" TextMode="Password" Width="209px"></asp:TextBox>
            </td>
        </tr>
        <td colspan ="3" align="left">
        
            <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        
        </td>
        </tr>
        <tr>
            <td class="auto-style2">
                
            </td>
            <td>
                &nbsp;
                <asp:Button ID="btnSave" runat="server" Text="Save" 
                     Height="33px" Width="107px" OnClick="btnVerify_Click" />
            
                &nbsp;
                <asp:Button ID="btnReset" runat="server" Text="Reset" 
                     Height="29px" Width="78px" />
            </td>
        </tr>
    </table>
            </td>
       
        </tr>
       
    </table>

</asp:Content>

