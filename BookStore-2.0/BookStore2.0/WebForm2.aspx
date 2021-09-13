<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="BookStore2._0.WebForm2" %>

 <html>
     <head>
         <title>
             Login Page
         </title>
         <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
     </head>
     <body>
         <div class="container">
          <div>
            <h1>Login Page</h1>
        </div><br><br>
    <div>
        <form runat="server">
          <div class="form-group row">
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="UserName" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter your username "></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tb_Name" runat="server" Text="Name cannot be empty" ErrorMessage="Name cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Password" ID="Label1" runat="server" Text="Password" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_Password" runat="server" class="form-control" placeholder="Please enter your password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="tb_Password" runat="server" Text="Password cannot be empty" ErrorMessage="password cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
           
          <div class="form-group row">
            <div class="col-sm-5 offset-sm-2">
                <asp:Button ID="btn_Add" class="btn btn-primary" runat="server" Text="Login" OnClick="btn_Add_Click"  />
            </div>
              <asp:GridView ID="gv_cats" runat="server" BackColor="WhiteSmoke"> </asp:GridView>
              
          </div>
            <asp:Label ID="lbl_Display" runat="server" Text="" ForeColor="Red"></asp:Label>
            </form>
    </div>
</div>
</body>
 </html>