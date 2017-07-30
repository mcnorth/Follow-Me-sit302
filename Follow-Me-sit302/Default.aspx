<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Follow_Me_sit302.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link rel="stylesheet" type="text/css" href="css/main.css"/>
    <script src="styles/JavaScript.js"></script>
    <title>FollowMe</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

<!-----------------------main content start-------------------------------------->
        <div class="login-page">
            <div class="form">

                
    
                <asp:TextBox ID="txtlogusername" runat="server" placeholder="username"></asp:TextBox>                  
                <asp:TextBox ID="txtlogpassword" runat="server" placeholder="password"></asp:TextBox>
                <asp:Button ID="btnlogin" runat="server" Text="login" OnClick="btnlogin_Click"></asp:Button>
                <asp:Label ID="lbllogStatus" runat="server"></asp:Label>
                <p class="message">Not registered? <a href="Register.aspx">Create an account</a></p>
     
            </div>
        </div>
<!-----------------------main content end-------------------------------------->
    
    </div>
    </form>
</body>
</html>
