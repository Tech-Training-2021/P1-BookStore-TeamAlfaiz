<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="BookStore2._0.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div>
            <h1>UserName:</h1>
            
        </div>

      <div class="form-group row">
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="UserName" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-10">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter your username "></asp:TextBox>
            </div>
          </div>
    <div>
</div>
    <div class="form-group row">
            <div class="col-sm-10 offset-sm-2">
                <asp:Button ID="btn_Add" class="btn btn-primary" runat="server" Text="Logout" OnClick="btn_Add_Click"  />
            </div>
    </div>
</asp:Content>
