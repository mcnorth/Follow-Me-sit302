<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProfile.aspx.cs" Inherits="Follow_Me_sit302.ViewProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/main.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/demo.css" rel="stylesheet" />
    <link href="css/material-dashboard.css" rel="stylesheet" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/chartist.min.js"></script>
    <script src="Scripts/demo.js"></script>
    <script src="Scripts/jquery-3.1.0.min.js"></script>
    <script src="Scripts/material-dashboard.js"></script>
    <script src="Scripts/material.min.js"></script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="wrapper">

	    <div class="sidebar" data-color="green" data-image="../assets/img/sidebar-1.jpg">
			<!--
		        Tip 1: You can change the color of the sidebar using: data-color="purple | blue | green | orange | red"

		        Tip 2: you can also add an image using data-image tag
		    -->

            <!-----------------------Side nav bar begin-------------------------------------->
			<div class="logo">
				
                <asp:Label ID="lblSession" runat="server" Text=""></asp:Label>
				
			</div>

	    	<div class="sidebar-wrapper">
	            <ul class="nav">
	                <li>
	                    <a href="UserPage.aspx">	                        
	                        <p>Dashboard</p>
	                    </a>
	                </li>
	                <li>
	                    <a href="Profile.aspx">	                        
	                        <p>Edit Profile</p>
	                    </a>
	                </li>
	                <li class="active">
	                    <a href="ViewProfile.aspx">	                        
	                        <p>View Profile</p>
	                    </a>
	                </li>
	                <li>
	                    <a href="SendProfile.aspx">
	                        <p>Send Profile</p>
	                    </a>
	                </li>
	                
	                
					
	            </ul>
	    	</div>
	    </div>
<!-----------------------Side nav bar end-------------------------------------->

 <!-----------------------main panel start-------------------------------------->       

	    <div class="main-panel">

<!-----------------------header begin-------------------------------------->
			<nav class="navbar navbar-transparent navbar-absolute">
				<div class="container-fluid">
					<div class="navbar-header">
						
                        Follow Me Application
						<%--<a class="navbar-brand" href="#">Material Dashboard</a>--%>
					</div>
					
				</div>
                <hr />
			</nav>
<!-----------------------header end-------------------------------------->

<!-----------------------main content start-------------------------------------->
			<div class="content">
				<div class="container-fluid">
					<div class="row">
																							
					</div>

					<div class="row">
						
					</div>

					<div class="row">
						<div class="col-lg-6 col-md-12">
							<div class="card card-nav-tabs">
								<div class="card-header" data-background-color="black">
                                    <h4 class="title">View Profile</h4>
									<p class="category">View your completed profile.</p>								
								</div>

								<div class="card-content">
	                                
	                                    <div class="row">
	                                        <div class="col-md-6">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProUserName" runat="server" placeholder="Username" CssClass="form-control"></asp:TextBox> 																										
												</div>
	                                        </div>

	                                        <div class="col-md-6">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProEmail" runat="server" placeholder="Email" CssClass="form-control"></asp:TextBox> 	
												</div>
	                                        </div>
	                                    </div>

	                                    <div class="row">
	                                        <div class="col-md-6">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProFirstName" runat="server" placeholder="First Name" CssClass="form-control"></asp:TextBox> 
												</div>
	                                        </div>

	                                        <div class="col-md-6">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProLastName" runat="server" placeholder="Last Name" CssClass="form-control"></asp:TextBox> 
												</div>
	                                        </div>
	                                    </div>

	                                    <div class="row">
	                                        <div class="col-md-4">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProHouseNo" runat="server" placeholder="House Number" CssClass="form-control"></asp:TextBox> 
												</div>
	                                        </div>

	                                        <div class="col-md-4">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProStreetName" runat="server" placeholder="Street Name" CssClass="form-control"></asp:TextBox> 
												</div>
	                                        </div>

	                                        <div class="col-md-4">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProSuburb" runat="server" placeholder="Suburb" CssClass="form-control"></asp:TextBox> 
												</div>
	                                        </div>
	                                    </div>

	                                    <div class="row">
	                                        <div class="col-md-4">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProState" runat="server" placeholder="State" CssClass="form-control"></asp:TextBox>
												</div>
	                                        </div>

	                                        <div class="col-md-4">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProCountry" runat="server" placeholder="Country" CssClass="form-control"></asp:TextBox>
												</div>
	                                        </div>

	                                        <div class="col-md-4">
												<div class="form-group label-floating">
                                                    <asp:TextBox ID="txtProPostcode" runat="server" placeholder="Postcode" CssClass="form-control"></asp:TextBox>
												</div>
	                                        </div>
	                                    </div>
                                    

	                                    
                                        <%--<asp:Button ID="btnUpdate" runat="server" Text="Update Profile" CssClass="btn btn-primary pull-right" OnClick="btnUpdate_Click" />--%>
	                                    <div class="clearfix">
                                            <asp:Label ID="lblProStatus" runat="server" Text=""></asp:Label>
                                        </div>
	                                
	                            </div>
							</div>
						</div>

						
					</div>
				</div>
			</div>
<!-----------------------main content end-------------------------------------->

			<footer class="footer">
				<div class="container-fluid">
					<nav class="pull-left">
						
					</nav>

					<p class="copyright pull-right">
						
					</p>

				</div>
			</footer>
		</div>
 <!-----------------------main panel end-------------------------------------->  
	</div>
    
    </div>
    </form>
</body>
</html>
