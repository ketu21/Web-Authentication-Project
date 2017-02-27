<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Forgotpass.aspx.cs" Inherits="Forgotpass" Title="oPass : A User Verification Protocol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table style="width: 100%;">
        <tr>
            <td width="40%">
                &nbsp;
            </td>
            <td>
               <table style="width: 100%;">
        <tr>
         <td colspan ="3" align="center" bgcolor="#6699FF">
             <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                 ForeColor="#FF3300" Text="Password will be sent on mobile"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtunm" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtunm" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
       
        <tr>
        <td colspan ="3" align="left">
        
            <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        
        </td>
        </tr>
        <tr>
            <td> </td>
            <td>
                &nbsp;
                <asp:Button ID="btnReg" runat="server" Text="Send" onclick="btnReg_Click" />
            </td>
            <td></td>
        </tr>
    </table>
            </td>
       
        </tr>
       
    </table>

</asp:Content>

