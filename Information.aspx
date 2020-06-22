<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Information.aspx.cs" Inherits="Information" %>

<!DOCTYPE html>

<html lang="en">
    <head>
        <title>Info</title>
        <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

    </head>
    <style>
        @import "font-awesome.min.css";
@import "font-awesome-ie7.min.css";
/* Space out content a bit */
body {
  padding-top: 20px;
  padding-bottom: 20px;
}

/* Everything but the jumbotron gets side spacing for mobile first views */
.header,
.marketing,
.footer {
  padding-right: 15px;
  padding-left: 15px;
}

/* Custom page header */
.header {
  border-bottom: 1px solid #e5e5e5;
}
/* Make the masthead heading the same height as the navigation */
.header h3 {
  padding-bottom: 19px;
  margin-top: 0;
  margin-bottom: 0;
  line-height: 40px;
}

/* Custom page footer */
.footer {
  padding-top: 19px;
  color: #777;
  border-top: 1px solid #e5e5e5;
}

/* Customize container */
@media (min-width: 768px) {
  .container {
    max-width: 730px;
  }
}
.container-narrow > hr {
  margin: 30px 0;
}

/* Main marketing message and sign up button */
.jumbotron {
  text-align: center;
  border-bottom: 1px solid #e5e5e5;
}
.jumbotron .btn {
  padding: 14px 24px;
  font-size: 21px;
}

/* Supporting marketing content */
.marketing {
  margin: 40px 0;
}
.marketing p + h4 {
  margin-top: 28px;
}

/* Responsive: Portrait tablets and up */
@media screen and (min-width: 768px) {
  /* Remove the padding we set earlier */
  .header,
  .marketing,
  .footer {
    padding-right: 0;
    padding-left: 0;
  }
  /* Space out the masthead */
  .header {
    margin-bottom: 30px;
  }
  /* Remove the bottom border on the jumbotron for visual effect */
  .jumbotron {
    border-bottom: 0;
  }
}
        .auto-style1 {
            font-size: medium;
        }
    </style>
   <div class="container" style="background-color:blue">
    <h1 class="well" >Information Form</h1>
	<div class="col-lg-12 well">
	<div class="row">
				<form runat="server" style="height: 588px">
					<div class="col-sm-12">
						<div class="row">
							<div class="col-sm-6 form-group">
								 <strong><span class="auto-style1">Place</span></strong>
								&nbsp;<asp:TextBox ID="TextBox4" runat="server" Width="392px" Height="28px"></asp:TextBox>
							</div>
						</div>					
						<div class="form-group">
							<strong><span class="auto-style1">Incident</span></strong><br />
						<asp:TextBox ID="TextBox5" runat="server" Height="53px" Width="394px"></asp:TextBox>
						</div>	
                      
            												
					<div class="form-group">
					<asp:label runat="server" text="Date" ID="date1" style="font-size: medium; font-weight: 700"></asp:label>
                        <br />
                        <input type="date" name="date" id="date"   />
                        <br />
                        <br />
	
					    </div>		
				
                        <div class="col-sm-6 form-group">
                            &nbsp;&nbsp;&nbsp;
                            <br />
                        
                               					
					        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click2" Text="Submit" Height="42px" Width="131px" />
                        
                               					
					    <br />
                            <br />
				<br />						
					</div>
				</form> 
				</div>
	</div>
	</div>
</html>