<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FAI_lab2.Views.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  <form id="form1" runat="server">  
        <div>  
            <table>  
                <tr>  
                    <td> Username: </td>  
                    <td>  
                        <asp:TextBox ID="txtUserName" runat="server" />  
                        <asp:RequiredFieldValidator ID="rfvUser" ErrorMessage="Please enter Username" ControlToValidate="txtUserName" runat="server" /> </td>  
                </tr>  
                <tr>  
                    <td> Password: </td>  
                    <td>  
                        <asp:TextBox ID="txtPWD" runat="server" TextMode="Password" />  
                        <asp:RequiredFieldValidator ID="rfvPWD" runat="server" ControlToValidate="txtPWD" ErrorMessage="Please enter Password" /> </td>  
                </tr>  
                <tr>  
                    <td> </td>  
                    <td>  
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /> </td>  
                </tr>  
            </table>  
        </div>  
    </form>  
</body>
</html>
