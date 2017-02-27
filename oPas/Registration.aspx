<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" Title="oPass : A User Verification Protocol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style1
    {
        width: 340px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;" border="1">
        <tr>
            <td width="40%">
                &nbsp;
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/index.jpeg" />
            </td>
            <td>
               <table style="width: 100%; z-index: -1;">
        <tr>
         <td colspan ="3" align="center" bgcolor="#6699FF">
             <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                 ForeColor="#FF3300" Text="Please Register Here"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right">
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            </td>
            <td class="style1">
                &nbsp;
                <asp:TextBox ID="txtunm" runat="server"></asp:TextBox>
                <asp:Button ID="btnCheck" runat="server" Text="Check User" 
                    onclick="btnCheck_Click" CausesValidation="False" />
            </td>
            <td>
                &nbsp;&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtunm" ErrorMessage="Cannot Be Blank" 
                    Display="Dynamic"></asp:RequiredFieldValidator>
            &nbsp;</td>
        </tr>
        
       
        <tr>
            <td align="right">
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Mobile No."></asp:Label>
            </td>
            <td class="style1">
                &nbsp;
                <asp:TextBox ID="txtMbno" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="txtMbno" ErrorMessage="Should Be of 10 Digits Only" 
                    ValidationExpression="\d{10}" Display="Dynamic"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
        <td colspan ="3" align="right">
        
            <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        
        </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td class="style1">
                &nbsp;
                <asp:Button ID="btnReg" runat="server" Text="Register" Enabled="False" 
                    onclick="btnReg_Click" />
                <asp:Button ID="btnReset" runat="server" Text="Reset" 
                    onclick="btnReset_Click" />
                <asp:Button ID="BtnNext" runat="server" onclick="BtnNext_Click" 
                    Text="Next" Enabled="False" />
            </td>
            <td>
                &nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
        </tr>
    </table>
            </td>
       
        </tr>
       
    </table>
</asp:Content>

