<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
       <meta charset="utf-8"/>
       <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
       <meta name="viewport" content="width=device-width, initial-scale=1"/>
       <meta name="description" content=""/>
       <meta name="author" content=""/>

       <title>Tempjobs</title>

    <!-- Bootstrap Core CSS -->
    <link rel="stylesheet" href="css/bootstrap.min.css" type="text/css"/>

    <!-- Custom Fonts -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel='stylesheet' type='text/css'/>
    <link href='http://fonts.googleapis.com/css?family=Merriweather:400,300,300italic,400italic,700,700italic,900,900italic' rel='stylesheet' type='text/css'/>
    <link rel="stylesheet" href="font-awesome/css/font-awesome.min.css" type="text/css"/>

    <!-- Plugin CSS -->
    <link rel="stylesheet" href="css/animate.min.css" type="text/css"/>

    <!-- Custom CSS -->
    <link rel="stylesheet" href="css/creative1.css" type="text/css"/>


</head>
<body id="pagetop" runat="server">
      
	<form id="form1" runat="server">
		<nav id="mainNav" class="navbar navbar-default navbar-fixed-top">
			<div class="container-fluid">
				<!-- Brand and toggle get grouped for better mobile display -->
				<div class="navbar-header">
					<button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
						<span class="sr-only">Toggle navigation</span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
						<span class="icon-bar"></span>
					</button>
					<a class="navbar-brand page-scroll" href="#homepage.aspx">Tempjobs</a>
				</div> 

				<!-- Collect the nav links, forms, and other content for toggling -->
				<div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
					<ul class="nav navbar-nav navbar-right">
						<li>
							<a class="page-scroll" href="About.aspx">About</a>
						</li>
						<li id ="lblViewJobseekers" runat="server" visible="false">
							<a class="page-scroll" href="ViewUsers.aspx">Job seekers</a>
						</li>
						<li id ="lblPostJob" runat="server" visible="false">
							<a class="page-scroll" href="PostJob.aspx">Post job</a>
						</li>
						<li  id ="lblProfile" runat="server" visible="false" >
							<a class="page-scroll" href="Profile.aspx">Profile</a>
						</li>
						<li id ="lblViewJobs" runat="server" visible="false">
							<a class="page-scroll" href="ViewJobs.aspx">Available jobs</a>
						</li>
						<li id ="lblRes" runat="server" visible="true" >
							<a class="page-scroll" href="Registration.aspx">Register</a>
						</li>
						<li id ="lblLogin" runat="server" visible="true">
							<a class="page-scroll" href="LoginPage.aspx">Login</a>
						</li>
						<li id ="lblLogout" runat="server" visible="false">
							<a class="page-scroll" href="Logout.aspx">Logout</a>
						</li>
					</ul>
				</div>
				<!-- /.navbar-collapse -->
			</div>
			<!-- /.container-fluid -->
		</nav>
        
        <section class="container-fluid myHeader" runat="server" style="background-image:url(header.jpg);">
	     <%--<header class="myHeader" runat ="server">--%>
		       <div class="header-content">
			       <div class="header-content-inner">
					    <h1>Informally skilled job sekeers meet informal skills employment opportunities</h1>
					    <hr/>
					    <p>Your gateway to informal skills employment opportunities and to informally skilled job seekers</p>
					    <a href="#about" class="btn btn-primary btn-xl page-scroll">Find Out More</a>
				    </div>
			    </div>
		    <%--</header>--%>
          </section>

		<section class="bg-primary" id="about">
			<div class="container">
				<div class="row">
					<div class="col-lg-8 col-lg-offset-2 text-center">
						<h2 class="section-heading">We've got what you need!</h2>
						<hr class="light"/>
						<p class="text-faded">Tempjobs has everything you need interms of access to short-term employment opportunities that require informal skills. Profiles of job seekers who posses these skills are are available for those looking to provide these employment opportunities.</p>
						<a href="#" class="btn btn-default btn-xl">Get Started!</a>
					</div>
				</div>
			</div>
		</section>

		<section id="services">
			<div class="container">
				<div class="row">
					<div class="col-lg-12 text-center">
						<h2 class="section-heading">At Your Service</h2>
						<hr class="primary"/>
					</div>
				</div>
			</div>
			<div class="container">
				<div class="row">
					<div class="col-lg-3 col-md-6 text-center">
						<div class="service-box">
							<i class="fa fa-4x fa-diamond wow bounceIn text-primary"></i>
							<h3>Post a job</h3>
							<p class="text-muted">Potential employers can post jobs and view profiles of those applying for that job.</p>
						</div>
					</div>
					<div class="col-lg-3 col-md-6 text-center">
						<div class="service-box">
							<i class="fa fa-4x fa-paper-plane wow bounceIn text-primary" data-wow-delay=".1s"></i>
							<h3>Employ job seekers</h3>
							<p class="text-muted">Look at profiles of jobseekers with different rated informal skills and select those to employ.</p>
						</div>
					</div>
					<div class="col-lg-3 col-md-6 text-center">
						<div class="service-box">
							<i class="fa fa-4x fa-newspaper-o wow bounceIn text-primary" data-wow-delay=".2s"></i>
							<h3>Experienced job seekers</h3>
							<p class="text-muted">Tempjobs records all employment details as part of job seekers' experience profiles.</p>
						</div>
					</div>
					<div class="col-lg-3 col-md-6 text-center">
						<div class="service-box">
							<i class="fa fa-4x fa-heart wow bounceIn text-primary" data-wow-delay=".3s"></i>
							<h3>Instant notifications</h3>
							<p class="text-muted">Job seekers with our mobile app get notifications when they are selected for employment.</p>
						</div>
					</div>
				</div>
			</div>
		</section>

		<section class="no-padding" id="portfolio">
			<div class="container-fluid">
				<div class="row no-gutter">
					<div class="col-lg-4 col-sm-6">
						<a href="#" class="portfolio-box">
							<img src="img/portfolio/b2.jpg" class="img-responsive" alt="" style="height:280px; width:100%"/>
							<div class="portfolio-box-caption">
								<div class="portfolio-box-caption-content">
									<div class="project-category text-faded">
										Category
									</div>
									<div class="project-name">
										Highly skilled handymen
									</div>
								</div>
							</div>
						</a>
					</div>
					<div class="col-lg-4 col-sm-6">
						<a href="#" class="portfolio-box">
							<img src="img/portfolio/bricklayering.jpg" class="img-responsive" alt="" style="height:280px; width:100%"/>
							<div class="portfolio-box-caption">
								<div class="portfolio-box-caption-content">
									<div class="project-category text-faded">
										Category
									</div>
									<div class="project-name">
										Builders
									</div>
								</div>
							</div>
						</a>
					</div>
					<div class="col-lg-4 col-sm-6">
						<a href="#" class="portfolio-box">
							<img src="img/portfolio/treetriming.jpg" class="img-responsive" alt="" height="250px"/>
							<div class="portfolio-box-caption">
								<div class="portfolio-box-caption-content">
									<div class="project-category text-faded">
										Category
									</div>
									<div class="project-name">
										Gardeners
									</div>
								</div>
							</div>
						</a>
					</div>
					<div class="col-lg-4 col-sm-6">
						<a href="#" class="portfolio-box">
							<img src="img/portfolio/watering.jpg" class="img-responsive" alt="" height="350px"/>
							<div class="portfolio-box-caption">
								<div class="portfolio-box-caption-content">
									<div class="project-category text-faded">
										Category
									</div>
									<div class="project-name">
										Farm work related
									</div>
								</div>
							</div>
						</a>
					</div>
					<div class="col-lg-4 col-sm-6">
						<a href="#" class="portfolio-box">
							<img src="img/portfolio/image4.jpg" class="img-responsive" alt="" height="350px"/>
							<div class="portfolio-box-caption">
								<div class="portfolio-box-caption-content">
									<div class="project-category text-faded">
										Category
									</div>
									<div class="project-name">
										Small businesses
									</div>
								</div>
							</div>
						</a>
					</div>
					<div class="col-lg-4 col-sm-6">
						<a href="#" class="portfolio-box">
							<img src="img/portfolio/ironing.jpg" class="img-responsive" alt="" height="350px"/>
							<div class="portfolio-box-caption">
								<div class="portfolio-box-caption-content">
									<div class="project-category text-faded">
										Category
									</div>
									<div class="project-name">
										Domestic work
									</div>
								</div>
							</div>
						</a>
					</div>
				</div>
			</div>
		</section>

		<aside class="bg-dark">
			<div class="container text-center">
				<div class="call-to-action">
					<h2>Many more categories of skills available.</h2>
					<a href="#" class="btn btn-default btn-xl wow tada">Vew More!</a>
				</div>
			</div>
		</aside>

		<section id="contact">
			<div class="container">
				<div class="row">
					<div class="col-lg-8 col-lg-offset-2 text-center">
						<h2 class="section-heading">More about us</h2>
						<hr class="primary">
						<p> TEMPJOBS is a site where jobseekers with infomal skills can get employment from people who are looking for short term services.</p>
					</div>
					<div class="col-lg-4 col-lg-offset-2 text-center">
						<i class="fa fa-phone fa-3x wow bounceIn"></i>
						<p>011-788-4543</p>
					</div>
					<div class="col-lg-4 text-center">
						<i class="fa fa-envelope-o fa-3x wow bounceIn" data-wow-delay=".1s"></i>
						<p><a href="mailto:your-email@your-domain.com">feedback@tempjobs.com</a></p>
					</div>
				</div>
			</div>
		</section>

		<!-- jQuery -->
		<script src="js/jquery.js"></script>

		<!-- Bootstrap Core JavaScript -->
		<script src="js/bootstrap.min.js"></script>

		<!-- Plugin JavaScript -->
		<script src="js/jquery.easing.min.js"></script>
		<script src="js/jquery.fittext.js"></script>
		<script src="js/wow.min.js"></script>

		<!-- Custom Theme JavaScript -->
		<script src="js/creative.js"></script>
	 </form>
</body>
</html>
