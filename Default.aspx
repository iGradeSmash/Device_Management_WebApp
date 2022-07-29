<%@ Page Title="Login" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Device_Management_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceholderLogin" runat="server">
    <div class="col-md-12" style="max-width:60%;">
        <h2 style="font-family: 'Century Gothic'; color: #808080; text-transform: uppercase;">Login</h2>
        <hr />
    </div>
    <div class="form col-md-12" style="box-shadow:0px 0px 0px 1px rgba(0,0,0,.2); background-color:#15152e; max-width:60%;">
        <br />
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <div class="col-md-12 ">
                        <asp:Label Text="Username" runat="server" Font-Size="small" Font-Bold="true" ForeColor="#FFFFFF" />
                        <asp:TextBox runat="server" ID="txtUsername" CssClass="form-control" placeholder="(Example:John.Doe@gmail.com)" ForeColor="#15154e" style="max-width:100%;" />
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <div class="col-md-12 ">
                        <asp:Label Text="Password" runat="server" Font-Size="small" Font-Bold="true" ForeColor="#FFFFFF" />
                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" TextMode="Password" ForeColor="#15154e" style="max-width:100%;" />
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-12 ">
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Button Text="Submit" runat="server" ID="btnSubmit" Font-Size="Large" Font-Bold="true" ForeColor="#FFFFFF" CssClass="btn btn-success" Style="max-width:100%;width:100%;" OnClick="btnSubmit_Click" />
                    </div>
                </div>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-md-12">
                <div class="form-group">
                    <div class="col-md-12">
                        <asp:Label runat="server" ID="lblResult" ForeColor="#808080" Font-Bold="true" Font-Size="small" />
                    </div>
                </div>
            </div>
        </div>
        <br />
    </div>
    <br />
    <div class="form form col-md-12">
        <asp:Label runat="server" font-size="X-Small" Text="Don't have an Account?"/>
        <a class="navbar-link" style="font-size:small;">Create Account</a>
    </div>
</asp:Content>
