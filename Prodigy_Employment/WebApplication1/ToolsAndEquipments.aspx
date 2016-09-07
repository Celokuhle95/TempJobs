<%@ Page Title="" Language="C#" MasterPageFile="~/TempJobs.Master" AutoEventWireup="true" CodeBehind="ToolsAndEquipments.aspx.cs" Inherits="WebApplication1.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="DisplayToolsAndEquipment1" class="container" runat="server" visible="false">
    </div>
    <div id="DisplayToolsAndEquipment2" class="container" runat="server">
        <div class="page-header">
            <h2>Tools and equipments.</h2>
        </div>

        <p class="text-muted">
            Here you can upload the picture of the tools or equipment that you use when doing the jobs you skilled in.
        This may be a romoval bakkie if you do refuse removal, a grass cutting machine if you do grass cutting, a 
        tree cutting machine if you do tree felling, or any tools that are essential to your job. You can upload upto 5 
        tools or any equipment that you use and want Employers to see to better your employment chances.
        </p>

        <p class="text-muted">
            Yo can howover upload less than five images if you don't use that much tools or equipments. It is noted that some
        informal jobs do not require tools or equipment of your own to complete. So in this case you can choose not to upload any photos
        Also note that some Employers may have their own tools and equipment which you can use aswell.
        </p>
        <br />
        <div class="card-deck-wrapper">
            <div class="card-deck">
                <div class="card">
                    <img class="card-img-top img-fluid img-responsive" id="Image1ID" src="image/" alt="no image to display." style="height:200px" runat="server" />
                    <div class="card-block">
                        <asp:FileUpload ID="ToolImage1" runat="server" Style="width: auto"  />
                        <asp:Button ID="btnReload1" runat="server" Text="upload" class=" btn-default" OnClick="btnReload1_Click" />
                        <br />
                        <br />
                        <div style="border-top: 1px solid#888; padding-top: 15px">
                            Name/Description:                 
                             <asp:TextBox ID="txtNameOrDescription1" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top img-fluid img-responsive" id="Image2ID" src="image/" alt="no image to display." style="height:200px" runat="server" />
                    <div class="card-block">
                        <asp:FileUpload ID="ToolImage2" runat="server" Style="width: auto" />
                        <asp:Button ID="btnReload2" runat="server" Text="upload" class=" btn-default" OnClick="btnReload1_Click" />

                        <br />
                        <br />
                        <div style="border-top: 1px solid#888; padding-top: 15px">
                            Name/Description:                 
                        <asp:TextBox ID="txtNameOrDescription2" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top img-fluid img-responsive" id="Image3ID" src="image/" alt="no image to display." style="height:200px" runat="server" />
                    <div class="card-block">
                        <asp:FileUpload ID="ToolImage3" runat="server" Style="width: auto"  />
                        <asp:Button ID="btnReload3" runat="server" Text="upload" class=" btn-default" OnClick="btnReload1_Click" />

                        <br />
                        <br />
                        <div style="border-top: 1px solid#888; padding-top: 15px">
                            Name/Description:                 
                         <asp:TextBox ID="txtNameOrDescription3" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top img-fluid img-responsive" id="Image4ID" src="image/" alt="no image to display." style="height:200px" runat="server" />
                    <div class="card-block">
                        <asp:FileUpload ID="ToolImage4" runat="server" Style="width: auto"  />
                        <asp:Button ID="btnReload4" runat="server" Text="upload" class=" btn-default" OnClick="btnReload1_Click" />

                        <br />
                        <br />
                        <div style="border-top: 1px solid#888; padding-top: 15px">
                            Name/Description:                 
                         <asp:TextBox ID="txtNameOrDescription4" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>

                <div class="card">
                    <img class="card-img-top img-fluid img-responsive" id="Image5ID" src="image/" alt="no image to display." style="height:200px" runat="server" />
                    <div class="card-block">
                        <asp:FileUpload ID="ToolImage5" runat="server" Style="width: auto"  />
                        <asp:Button ID="btnReload5" runat="server" Text="upload" class="btn-default" OnClick="btnReload1_Click" />

                        <br />
                        <br />
                        <div style="border-top: 1px solid#888; padding-top: 15px">
                            Name/Description:                 
                       <asp:TextBox ID="txtNameOrDescription5" class="form-control" runat="server"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div>
            <asp:Button ID="btnSave" runat="server" Style="border-radius: initial" Text="Save changes" class="btn btn-primary btn-md" OnClick="btnSave_Click" />
        </div>
    </div>
</asp:Content>
