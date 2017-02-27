<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" Title="oPass : A User Verification Protocol" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 100%;">
        
        <tr>
            <td colspan="2">
                &nbsp;
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
                    ForeColor="#FF3300" 
                    Text=" Opass:A User Verification Protocol Opposed to Password Stealing And Password Reuse Attacks"></asp:Label>
            </td>
          
        </tr>
        <tr>
            <td width="30%" align="center">
                &nbsp;
                <asp:Image ID="Image3" runat="server" ImageUrl="~/images/opasimg.jpg" 
                    Width="300px" />
               
            </td>
           <td>
               <p style="text-align: justify; font-family: 'Courier New', Courier, monospace; text-decoration: blink">Text password is the most common form of user authentication on websites due to its simplicity and convenience.
               Users passwords are easy to be stolen and compromised under different threats. Two types of mistakes are commonly done by the users. Firstly, users select weak passwords and reuse the same passwords across different websites. Secondly typing the passwords into un trusted computers leads to password threat and theft.
               a user authentication protocol named Opass which uses a user’s cell phone and short message service to thwart password stealing and reuse attacks . Opass only requires each participating website to possess a unique phone number and involves a (TSP) telecommunication service provider in registration and recovery phases. 
               Through Opass users only need to remember a long term password to login on all websites.</p>
               <p style="text-align: justify; font-family: 'Courier New', Courier, monospace; text-decoration: blink">Opass utilizes a user’s cell phone as an authentication token, SMS as a secure channel.
                In the registration phase the users start the pass program to register a new account on the website she wishes to visit in the future.
                 The server requests for the users account Id and phone number instead of the users password. After filling out the registration form the program asks the users to setup a long-term password. This long-term password is used to generate a chain of one-time password for further logins on the target server. 
               Then the program automatically sends a registration SMS message to the server for completing the registration procedure.</p>
            </td>
        </tr>
    </table>
</asp:Content>

