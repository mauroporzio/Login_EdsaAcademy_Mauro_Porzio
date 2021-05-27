<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Redirect.aspx.cs" Inherits="Login.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%" id ="usernameTable" runat ="server" >
                    <tr> 
                        <td>
                            <asp:Label ID="lblInfo" runat="server" Text="Username: "></asp:Label> 

                            <asp:TextBox ID="txtInfo" runat="server" Width="250px" Height="30px" Font-Size="Larger"></asp:TextBox>
                        </td>
                    </tr>
                <tr>
                     <td>
                            <asp:Label ID="lblInfo2" runat="server" Text="Date: "></asp:Label> 

                            <asp:TextBox ID="txtinfo2" runat="server" Width="250px" Height="30px" Font-Size="Larger"></asp:TextBox>
                     </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
