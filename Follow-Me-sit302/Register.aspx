<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Follow_Me_sit302.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/main.css" rel="stylesheet" />
    <script src="Scripts/JavaScript.js"></script>
    <title>FollowMe</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <div class="login-page">
            <div class="form">
                
                <img src="images/front-logo.png" class="img-responsive center" id="front-logo" />

                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtregname" Display="Dynamic" ErrorMessage="Name is required" Font-Size="Small" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                
                <asp:TextBox ID="txtregname" runat="server" placeholder="username"></asp:TextBox>                  
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtregpassword" Display="Dynamic" ErrorMessage="Password is required" Font-Size="Small" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                <asp:TextBox ID="txtregpassword" runat="server" placeholder="password"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtregemail" Display="Dynamic" ErrorMessage="Email address is required" Font-Size="Small" ValidationGroup="AllValidators"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtregemail" Display="Dynamic" ErrorMessage="E-mail addresses must be in the format of name@domain.xyz" Font-Size="Small" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="AllValidators">Invalid format!</asp:RegularExpressionValidator>
                <asp:TextBox ID="txtregemail" runat="server" placeholder="email address"></asp:TextBox>
                <asp:TextBox ID="txtRegHouseNumber" runat="server" placeholder="house number"></asp:TextBox>
                <asp:TextBox ID="txtRegStreet" runat="server" placeholder="street"></asp:TextBox>
                <asp:TextBox ID="txtRegSuburb" runat="server" placeholder="suburb"></asp:TextBox>
                <asp:TextBox ID="txtRegState" runat="server" placeholder="state"></asp:TextBox>
                <asp:TextBox ID="txtRegCountry" runat="server" placeholder="country"></asp:TextBox>
                <asp:TextBox ID="txtRegPostcode" runat="server" placeholder="postcode"></asp:TextBox>--%>
                <asp:Button ID="btnregister" runat="server" Text="register" ValidationGroup="AllValidators" OnClick="btnregister_Click"></asp:Button>
                <asp:Label ID="lblregStatus" runat="server"></asp:Label>
                <p class="message">Already registered? <a href="Default.aspx">Sign In</a></p>
                    
                
    
            </div>
        </div>
    
    </div>
    </form>
</body>
</html>
