<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Menu.aspx.cs" Inherits="Menu" Title="oPass : A User Verification Protocol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style2 {
            width: 492px;
        }
        .auto-style3 {
            width: 201px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
<table align="center" cellpadding="0" cellspacing="0" class="style1" 
        style="width: 760">
        
        <tr>
            <td class="auto-style2">
                <table align="left" cellpadding="0" cellspacing="0" style="width: 145%">
                    <tr>
                        <td valign="top" class="auto-style3">
                            <asp:TreeView ID="TreeView1" runat="server" Font-Names="Courier New" 
                                ShowLines="True" 
                                Font-Bold="True" Font-Size="Small" Height="113px" Width="197px" style="margin-right: 0px">
                                <Nodes>
                                    <asp:TreeNode Text="My Menu" Value="My Menu"></asp:TreeNode>
                                    <asp:TreeNode Text="Gmail " Value="Gmail" NavigateUrl="~/gmail.aspx"></asp:TreeNode>
                                    <asp:TreeNode Text="Yahoo " Value="Yahoo" NavigateUrl="~/yahoo.aspx"></asp:TreeNode>
                                    <%--<asp:TreeNode Text="Update" Value="Update" NavigateUrl="~/Settings.aspx"></asp:TreeNode>--%>
                                    <asp:TreeNode Text="Change Password"  Value="Change Password" NavigateUrl="~/Changepwd.aspx"></asp:TreeNode>
                                    <asp:TreeNode Text="Change Mobile Number"  Value="Change Mobile" NavigateUrl="~/ChangeMobileno.aspx"></asp:TreeNode>
                                   
                             
                                </Nodes>
                            </asp:TreeView>
                        </td>
                        <td valign="top">
                            <asp:Image ID="Image3" runat="server" Height="271px" ImageUrl="~/images/welcomepng.gif" 
                                Width="99%" style="margin-left: 5px" />
                        </td>
                        
                    </tr>
                   
                   
                </table>
            </td>
        </tr>
    </table>

</div>
</asp:Content>

