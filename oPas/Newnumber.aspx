<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Newnumber.aspx.cs" Inherits="Newnumber" Title="oPass : A User Verification Protocol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 340px;
    }
        .auto-style2 {
            width: 23%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;" border="1">
        <tr>
            <td class="auto-style2">
                &nbsp;
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/index.jpeg" />
            </td>
            <td>
               <table style="width: 100%; z-index: -1;">
        <tr>
         <td colspan ="3" align="center" bgcolor="#6699FF">
             <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                 ForeColor="#FF3300" Text="New Number Registered"></asp:Label>
            </td>
        </tr>
        
        <tr>
        <td colspan ="3" align="center">
        
            <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        
        </td>
        </tr>
        <tr>
            
            <td class="style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnReg" runat="server" Text="Home" Enabled="False" OnClick="btnReg_Click"  />
            </td>
            
        </tr>
    </table>
            </td>
       
        </tr>
       
    </table>
</asp:Content>
