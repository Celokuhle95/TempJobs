<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ConfirmInvite.aspx.cs" Inherits="WebApplication1.ConfirmInvite" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="width:40%">
        <div class="card">
            <div class="page-header">
                <h2 class="text-center">  Confirm Invite.</h2>
            </div>
            <div class="card-block">
                <p class=" text-center">To confirm that you want to invite this job seeker to view one of your posted job, click the confirm button below or else cancel.</p>               
                <div class="row">
                    <div class="col-md-6">
                        <asp:Button ID="btnConfirm" class="btn btn-success"  style="width:100%;border-radius:initial" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />
                    </div>
                    <div class="col-md-6">
                        <asp:Button ID="btnCancel" CssClass="btn btn-block" style="width:100%;border-radius:initial" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                    </div>
                </div>
                <br />
            </div>
        </div>





    </div>
</asp:Content>
