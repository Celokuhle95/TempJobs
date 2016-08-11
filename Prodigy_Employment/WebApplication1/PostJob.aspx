<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="PostJob.aspx.cs" Inherits="WebApplication1.PostJob" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left:10%; padding-right:10%">
        <div class ="row" style="padding-left:10%; padding-right:5%; border:groove">
            <br /> <br />
            <h2>Provide job details.</h2>
            <hr  style="color: #808080, #C2C2C2" runat ="server"  /> 
            <p>After posting, this job will be viewed by many job seekers, who might be interested.</p>
            <br /><br /><br />
            <div class ="row">
                <div class="col-md-4">
                    <b>Job Name:</b>
                </div>
                 <div class="col-md-7">
                       <asp:DropDownList ID="drpSkillName" class="form-control" runat="server" style="width:auto">
                            <asp:ListItem Value="0">Select job name</asp:ListItem>
                            <asp:ListItem Value="1">Tree felling</asp:ListItem>
                            <asp:ListItem Value="2">Trimming and prunning</asp:ListItem>
                            <asp:ListItem Value="3">Working in the garden</asp:ListItem>
                            <asp:ListItem Value="4">Grass cutting</asp:ListItem>
                            <asp:ListItem Value="5">Plumbing</asp:ListItem>
                            <asp:ListItem Value="6">Site clearance/Waste removal</asp:ListItem>
                            <asp:ListItem Value="7">Painting</asp:ListItem> 
                            <asp:ListItem Value="8">Varnishing</asp:ListItem>
                            <asp:ListItem Value="9">Washing and Ironing</asp:ListItem>
                            <asp:ListItem Value="10">House Cleaning</asp:ListItem>
                       </asp:DropDownList>
                </div>
            </div>
           <br /><br />
            <div class ="row">
                <div class="col-md-4">
                    <b>Short Job Description:</b>
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtDescription" runat="server" class="form-control"></asp:TextBox>
                     <i>Provide a short description of what the job seeker will be expected to do inorder complete this job.</i>
                </div>
            </div>
            <br /><br />

            <div class ="row">
                <div class="col-md-4">
                    <b>Number Of Days :</b>
                </div>
                 <div class="col-md-7">
                     <%--<asp:TextBox ID="txtNumDays" runat="server" class="form-control"></asp:TextBox>--%>
                     <input type="number" id="NumberOfDays" name="num_days" min="1" style="width:70px" runat="server"/><br />
                       <i>The number of days the job will take to complete, this also indicates the number of days the job seeker will be expected to work.</i>
                </div>
            </div> 

            <br /><br />
              
             <div class ="row">
                <div class="col-md-4">
                   <b> Due date for applications:</b>
                </div>
                <div class="col-md-7">                   
                    <%--<asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>--%>
                        <input type="date" id="DueDate" name="due_date" runat="server"/> <br />
                        <i>JobSeekers must apply for this job before this date.</i>                 
                </div>
            </div>

            <br /><br />
             <div class ="row">
                <div class="col-md-4">
                    <b>Job start date:</b>
                </div>
                <div class="col-md-7">                   
                        <input type="date" id="StartDate" name="start_date" runat="server"/> <br />
                        <i>This is the date on which employed you want the Job Seeker to start doing the job.</i>                 
                </div>
            </div>
            
            <br /><br />
            <div class ="row">
                <div class="col-md-4">
                    <b>Start time(For each day):</b>
                </div>
                 <div class="col-md-7">
                     <input type="time" id="StartTime" name="start_Time" runat="server"/><br />
                     <i>This is the time the job seeker will be required to start working every day, for the duration of the job.</i>
                </div>
            </div>
           <br /><br />
           <div class ="row">
                <div class="col-md-4">
                    <b>Knock-off time(For each day):</b>
                </div>
                 <div class="col-md-7">
                     <input type="time" id="EndTime" runat="server"/><br />
                     <i>This is the time the job seeker can expect to knockof every day, for the duration of the job.</i>
                </div>
            </div>
            <br /><br />
            <div class ="row">
                <div class="col-md-4">
                    <b>Location/Place where the job is to be done: </b>
                </div>
                 <div class="col-md-7">
                     <asp:TextBox ID="txtLocation" runat="server" class="form-control"></asp:TextBox>
                     <i>Provide the address of the place where the job is to be done. This may be your home, your business space or whereever.</i>
                </div>
            </div>
            <br /><br />

            <div class ="row">
                <div class="col-md-4">
                    <b>Pay Amount: </b>
                </div>
                 <div class="col-md-7">
                     <b>R</b> <input type="number" id="PayAmount" name="pay" step="50" min="100" style="width:80px" runat="server"/><br />
                     <i>Total amount of money to be paid after the job is completed.</i>
                </div>
            </div>
            <br />

            <div class ="row">
                <asp:Button ID="btnUpload" runat="server" style="width:20%" Text="Post" class="btn btn-primary" OnClick="btnUpload_Click" />
            </div>
            <br />
        </div>
    </div>
</asp:Content>
