<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Getnewpwd.aspx.cs" Inherits="Getpwd" Title="oPass : A User Verification Protocol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 162px;">
        <tr>
            <td width="40%">
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/opasimg.jpg" 
                    Width="300px" />
            </td>
            <td>
               <table style="width: 100%;">
        <tr>
         <td align="center" bgcolor="#6699FF">
             <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                 ForeColor="#FF3300" Text="Please Send New Password "></asp:Label>
            </td>
        </tr>
       
        </table>
            </td>
       
        </tr>
       
    </table>
</asp:Content>

