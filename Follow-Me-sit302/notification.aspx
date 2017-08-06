<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="notification.aspx.cs" Inherits="Follow_Me_sit302.notification" %>

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
				<img src="images/front-logo.png" class="img-responsive center" id="front-logo" />
                
				
			</div>

	    	<div class="sidebar-wrapper">
	            <ul class="nav">
	                <li>
	                    <a href="business.aspx">	                        
	                        <p>Dashboard</p>
	                    </a>
	                </li>
	                <li>
	                    <a href="client.aspx">	                        
	                        <p>Get Client Details</p>
	                    </a>
	                </li>
	                <li class="active">
	                    <a href="notification.aspx">	                        
	                        <p>Send Notification</p>
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
						
                        <asp:Label ID="lblSession" runat="server" Text=""></asp:Label>
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
                                    <h4 class="title">Send Notifications</h4>
									<p class="category">Send an email to the Follow Me client</p>								
								</div>

								<div class="card-content">
	                                
	                                    <div class="row">
	                                        <div class="col-md-6">
												<div class="form-group label-floating">
                                                    <asp:Button ID="btnlogin" runat="server" Text="Follow ME ID" OnClick="btnlogin_Click"></asp:Button>																										
												</div>
	                                        </div>

	                                        <div class="col-md-6">
												<div class="form-group label-floating">
                                                    <asp:Button ID="btnfind" runat="server" Text="FIND" OnClick="btnfind_Click"></asp:Button>	
												</div>
	                                        </div>
	                                    </div>
                                     <div class="row">
	                                        <div class="col-md-12">
	                                            <div class="form-group">
	                                               
													<div class="form-group label-floating">
									    				<asp:TextBox id="txtProComment" TextMode="multiline" Columns="80" Rows="5" runat="server" />
                                                        <p class="category">Dear[Follow Me Id Name]</p>	
                                                        <p class="category">Your details have been updated in our system</p>	
		                        					</div>
	                                            </div>
	                                        </div>
	                                    </div>
                                    
                                        <asp:Button ID="btnSend" runat="server" Text="Send" CssClass="btn btn-primary pull-right" OnClick="btnSend_Click" />
	                                    
                                        
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
