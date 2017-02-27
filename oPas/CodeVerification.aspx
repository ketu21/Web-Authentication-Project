<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CodeVerification.aspx.cs" Inherits="CodeVerification" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
        .auto-style2 {
            width: 32%;
        }
        .auto-style3 {
            width: 537px;
        }
        .auto-style4 {
            height: 30px;
            width: 537px;
        }
        .auto-style6 {
            height: 32px;
        }
        .auto-style7 {
            height: 32px;
            width: 537px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%; height: 629px;">
        <tr>
            <td class="auto-style2">
                &nbsp;
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/index.jpeg" Width="275px" />
            </td>
            <td>
               <table style="width: 100%;">
        <tr>
         <td colspan ="3" align="center" bgcolor="#6699FF">
             <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                 ForeColor="#FF3300" 
                 Text="Please Specify Verification Code Received on Mobile"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtunm" runat="server" ReadOnly="True" Width="205px"></asp:TextBox>
            </td>
            <td>
               
            </td>
        </tr>
                   <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label5" runat="server" Text="Mobile No."></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtMbno" runat="server" ReadOnly="True" Width="205px"></asp:TextBox>
            </td>
            <td>
               
            </td>
        </tr>
       
        <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Verification Code"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtVcd" runat="server" Width="207px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtVcd" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
                   <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label9" runat="server" Text="First Name"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtfnm" runat="server" Width="209px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtfnm" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
                   <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label10" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtlnm" runat="server" Width="212px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtlnm" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
                   <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label11" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtadd" runat="server" Width="215px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="txtadd" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
                    <tr>
            <td align="right" class="auto-style7">
                &nbsp;
                <asp:Label ID="Label12" runat="server" Text="Security Question"></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="224px">
                    <asp:ListItem>What is your Birth Place?</asp:ListItem>
                    <asp:ListItem>What is your first mobile number?</asp:ListItem>
                    <asp:ListItem>What is your Favourite color?</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style6">
                &nbsp;
                </td>
        </tr>
                    <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label13" runat="server" Text="Answer"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtans" runat="server" Width="211px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="txtans" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
                </td>
        </tr>
        
         <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label3" runat="server" Text="Gmail Account Login ID."></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtLoginId" runat="server" Height="17px" Width="212px" ></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtLoginId" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label6" runat="server" Text="Gmail Account Password"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtPwd" runat="server" 
                    TextMode="Password" Width="209px"></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                    ControlToValidate="txtPwd" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
                   <tr>
            <td align="right" class="auto-style3">
                &nbsp;
                <asp:Label ID="Label7" runat="server" Text="Yahoo Account Login ID."></asp:Label>
            <%--</td>--%>
            <td>
                &nbsp;
                <asp:TextBox ID="txtLoginId2" runat="server" Width="210px" ></asp:TextBox>
            </td>
            <td>
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="txtLoginId2" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td align="right" class="auto-style4">
                &nbsp;
                <asp:Label ID="Label8" runat="server" Text="Yahoo Account Password"></asp:Label>
            </td>
            <td class="auto-style1">
                &nbsp;
                <asp:TextBox ID="txtPwd2" runat="server"  
                    TextMode="Password" Width="210px"></asp:TextBox>
            </td>
            <td >
                &nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="txtPwd2" ErrorMessage="Cannot Be Blank"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <td colspan ="3" align="left">
        
            <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#FF3300"></asp:Label>
        
        </td>
        </tr>
        <tr>
            <td class="auto-style3">
                
            </td>
            <td>
                &nbsp;
                <asp:Button ID="btnVerify" runat="server" Text="Verify" 
                    onclick="btnVerify_Click" Height="33px" Width="107px" />
            </td>
            <td>
                &nbsp;
                <asp:Button ID="btnReset" runat="server" Text="Reset" 
                    onclick="btnReset_Click" Height="29px" Width="78px" />
            </td>
        </tr>
    </table>
            </td>
       
        </tr>
       
    </table>

</asp:Content>

