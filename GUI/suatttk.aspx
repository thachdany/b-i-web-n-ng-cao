<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="suatttk.aspx.cs" Inherits="GUI.suatttk" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left: 0px; padding-right: 0px">
    <div class="form-container">
        <div class="row" style="margin-right:0px">
            <div class="col-lg-8">
                <img style="width: 100%; height: 400px" src="img/meeting.jpg" />
            </div>
            <div class="col-lg-4 dn" style="padding-left:5px;">
                <legend style="background-color: orangered;color: white;text-align: center;padding: 5px;">ĐĂNG NHẬP</legend><br />
&nbsp;<div class="form-group">        
                Tên Đang Nhập
                    <asp:TextBox class="form-control" ID="txttentk" placeholder="Tên tài khoản đăng nhập" runat="server"></asp:TextBox>

                </div>


                <div class="form-group">
                    Mật Khẩu cũ
                    <asp:TextBox class="form-control" ID="txtmk" TextMode="Password" placeholder="Mật khẩu cũ" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    Mật Khẩu Mới
                    <asp:TextBox class="form-control" ID="txtmknew" TextMode="Password" placeholder="Mật khẩu mới" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                   Nhập lại Mật Khẩu 
                    <asp:TextBox class="form-control" ID="retxtmknew" TextMode="Password" placeholder="Mật khẩu mới" runat="server"></asp:TextBox>
                </div>
           <%-- <asp:Button class="btn btn-primary btn-block" runat="server" OnClick="login" Text="Đăng Nhập" />--%>
                <asp:Button class="btn btn-primary btn-block" ID="Button1" runat="server" Text="Lưu lại" style="margin-left:0px" OnClick="Button1_Click" />
        </div>
        </div>
    </div>

</div>
</asp:Content>
 