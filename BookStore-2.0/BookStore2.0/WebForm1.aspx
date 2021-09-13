<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="BookStore2._0.WebForm1" %>

<html>
    <head>
       <title>SignUp page</title>
       <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
        <style>
            body{
                background-color:whitesmoke;
            }
            .container{
                  margin: auto;                  width: 50%;                  border: 3px solid purple;                  padding: 10px;

            }
           
            .container1{
                width:80%;
                margin-left:28%;
            }
        </style>
    </head>
    <body>
          <div class="container">
          <div>
            <h1 style="text-align:center">------ Sign Up ------</h1>
        </div>
    <div><br><br>
        <div class="container1">
        <form runat="server">
        <div class="form-group row">
              <asp:Label for="tb_Name" ID="lbl_Name" runat="server" Text="Name" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_Name" runat="server" class="form-control" placeholder="Please enter your name "></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="tb_Name" runat="server" Text="Name cannot be empty" ErrorMessage="Name cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_Phone" ID="Label1" runat="server" Text="Phone" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_Phone" runat="server" class="form-control" placeholder="Please enter your Phone Number"></asp:TextBox>
                 <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tb_Phone"   ErrorMessage="Phone is not valid" ValidationExpression="^[89][0-9]{9}" ForeColor="Red"></asp:RegularExpressionValidator>
              
            </div>
          </div>
            <div class="form-group row">
              <asp:Label for="tb_Email" ID="Label2" runat="server" Text="Email" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_Email" runat="server" class="form-control" placeholder="Please enter your Email"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tb_Email"   ErrorMessage="Email is not valid" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="Red"></asp:RegularExpressionValidator>
              
            </div>
          </div>
          <div class="form-group row">
              <asp:Label for="tb_age" ID="Label5" runat="server" Text="Age" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_age" runat="server" class="form-control" type="number" min="14" max="100" placeholder="Please enter your Age"></asp:TextBox> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ControlToValidate="tb_age" runat="server" Text="Age cannot be empty" ErrorMessage="Age cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
            <div class="form-group row">
              <asp:Label for="Gender" ID="lbl_Gender" runat="server" Text="Gender" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:RadioButton ID="rb_Male" GroupName="Gender" Text="Male" runat="server" Checked="true" />
                <asp:RadioButton ID="rb_Female" GroupName="Gender" Text="Female" runat="server" />
            </div>
          </div>
              <div class="form-group row">
              <asp:Label for="tb_address" ID="Label3" runat="server" Text="address" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_address" runat="server" class="form-control" placeholder="Please enter your address"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ControlToValidate="tb_address" runat="server" Text="address cannot be empty" ErrorMessage="address cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
              <div class="form-group row">
              <asp:Label for="tb_password" ID="Label4" runat="server" Text="Password" class="col-sm-2 col-form-label"></asp:Label>
            <div class="col-sm-5">
                <asp:TextBox ID="tb_password" type="Password" runat="server" class="form-control" placeholder="Please enter your password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="tb_password" runat="server" Text="password cannot be empty" ErrorMessage="password cannot be empty" ForeColor="Red"></asp:RequiredFieldValidator>
            </div>
          </div>
          <div class="form-group row">
            <div class="col-sm-5 offset-sm-2">
                <asp:Button ID="btn_Add" class="btn btn-primary" runat="server" Text="Submit" OnClick="btn_Add_Click1" />
            </div>
              <asp:GridView ID="gv_cats" runat="server" BackColor="WhiteSmoke"> </asp:GridView>
              
          </div>
            <asp:Label ID="lbl_Display" runat="server" Text=""></asp:Label>
    </form>
            </div>
    </div>
    </div>

</body>
</html>