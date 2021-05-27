<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Login.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Login ID="IDControlLogin" runat="server"
                TitleText="Log in page"
                UserNameLabelText="Username"
                PasswordLabelText="Password"
                LoginButtonText="Log in"
                DisplayRememberMe="False"
                OnAuthenticate="AuthenticateLogIn">
            </asp:Login>
        </div>
    </form>
</body>
</html>
