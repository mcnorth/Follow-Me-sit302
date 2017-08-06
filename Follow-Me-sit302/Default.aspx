<%--<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Follow_Me_sit302.Default" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <link rel="stylesheet" type="text/css" href="css/main.css"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="styles/JavaScript.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <title>FollowMe</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

<!-----------------------main content start-------------------------------------->
        <div class="login-page">
            <div class="form">

                <img src="images/front-logo.png" class="img-responsive center" id="front-logo" />
    
                <asp:TextBox ID="txtlogusername" runat="server" placeholder="username"></asp:TextBox>                  
                <asp:TextBox ID="txtlogpassword" runat="server" placeholder="password"></asp:TextBox>
                <asp:Button ID="btnlogin" runat="server" Text="login" OnClick="btnlogin_Click"></asp:Button>
                <asp:Button ID="btnbusiness" runat="server" Text="business" OnClick="btnTemp_Click"></asp:Button>
                <asp:Label ID="lbllogStatus" runat="server"></asp:Label>

                <!----------------------------------checkboxes here------------------------------------->
                <asp:CheckBox ID="cbPersonal" Text ="Personal" runat="server" /> 
                <asp:CheckBox ID="cbbusiness" Text ="Business" runat="server" /> 

                <p class="message">Not registered? <a href="Register.aspx">Create an account</a></p>
     
            </div>
        </div>
<!-----------------------main content end-------------------------------------->
    
    </div>
    </form>
</body>
</html>
