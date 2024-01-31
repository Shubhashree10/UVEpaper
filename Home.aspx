<%@ Page Title="" Language="C#" MasterPageFile="~/UVEpaper.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="UVEpaper.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6">
            <div class="card">
                <div class="card-header">
                    <h4 class="card-title">UDAYAVANI</h4>
                    <p class="text-muted mb-0">Get Started.</p>
                </div>
                <!--end card-header-->
                <div class="card-body">
                    <div class="mb-3">
                        <label for="exampleInputEmail1">Folder Name</label>
                        <asp:TextBox ID="txtFolderName" runat="server" CssClass="form-control" placeholder="Enter folder name"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnsubmit" runat="server" CssClass="btn btn-de-primary" Text="Submit" OnClick="btnsubmit_Click" />
                </div>
                <!--end card-body-->
            </div>
            <!--end card-->
        </div>
        <!--end col-->
    </div>
    <div class="row">
        <div class="table-responsive">
           <asp:GridView ID="gridfilelist" runat="server" CssClass="table mb-0" AutoGenerateColumns="false" OnRowDataBound="gridfilelist_RowDataBound">
               <HeaderStyle CssClass="thead-light" />
               <Columns>
                   <asp:TemplateField HeaderText="filename">
                       <ItemTemplate>
                           
                           <asp:HiddenField ID="hidfilename" runat="server" Value='<%# Bind ("filename")%>' />
                           <asp:HiddenField ID="hidfilepath" runat="server" Value='<%# Bind ("filepath")%>' />
                           <asp:Literal ID="litfilename" runat="server"></asp:Literal>

                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:BoundField DataField="Mainedition" HeaderText="mainedition" />
                   <asp:BoundField DataField="date" HeaderText="publishdate" />
                   <asp:BoundField DataField="Pagenumber" HeaderText="Pagenumber" />
                   <asp:BoundField DataField="subedition" HeaderText="subedition" />

               </Columns>
           </asp:GridView>
        </div>
    </div>
</asp:Content>
