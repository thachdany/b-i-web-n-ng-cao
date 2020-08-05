<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="dkxethb.aspx.cs" Inherits="GUI.dkxethb" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function isNumberKey(evt) {
            var charCode = (evt.which) ? evt.which : evt.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57))
                return false;
            return true;
        }
    </script>
     <%
        int quyen = Convert.ToInt32(Session["quyen"]); ;
        if (quyen == 4)
        {
            //string scr = "swal('Thông báo','Xin chào admin','success');";
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
    %>
    <div class="container" style="padding-left: 0px; padding-right: 0px">
        <div class="form-container">
            <div class="row" style="margin-right: 0px; margin-left: 0px">
                <legend style="background-color: orangered; color: white;  padding: 5px;padding-left:10px">NHẬP THÔNG TIN</legend>
                <div class="col-lg-6 ">

                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">MSSV:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox  ID="txtms" runat="server" ReadOnly="true" style="font-weight:bold; border:none; font-size:14px; font-family:Arial"></asp:TextBox>
                            </div>
                        </div>

                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Họ & Tên:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox ID="txtten" runat="server" ReadOnly="true" style="font-weight:bold; border:none; font-size:14px;font-family:Arial"></asp:TextBox>
                            </div>
                        </div>

                    </div>
                     <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Lớp:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox style="font-weight:bold; border:none; font-size:14px;font-family:Arial" ID="txtlop" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>

                    </div>    
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Điạ Chỉ:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox style="font-weight:bold; border:none; font-size:14px;font-family:Arial" ID="txtdiachi" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>

                    </div> 
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="" >SĐT:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:TextBox class="form-control" ID="txtsdt" runat="server" onkeypress="return isNumberKey(event)" ></asp:TextBox>
                            </div>
                        </div>

                    </div>    
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2" >
                                <label for="">Diện khó khăn:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:DropDownList ID="txtdkk" runat="server" class="form-control">
                                    <asp:ListItem>Hộ Nghèo</asp:ListItem>
                                    <asp:ListItem>Dân Tộc</asp:ListItem>
                                    <asp:ListItem>Vùng sâu vùng xa</asp:ListItem>
                                    <asp:ListItem>Con thương binh có công CM</asp:ListItem>
                                    <asp:ListItem>Diện mồ côi</asp:ListItem>
                                    <asp:ListItem>Diện khó khăn khác</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>

                    </div>                
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="" >Hoàn cảnh:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:TextBox ID="TextBox1" class="form-control" TextMode="MultiLine" runat="server" Rows="8" placeholder="Vui lòng nhập ngắn gọn hoàn cảnh khoảng 200 ki tự" style="width:600px"></asp:TextBox>
                            </div>
                        </div>

                    </div> 
                </div>
                <div class="col-lg-6">
                    
                    <img src="img/2.jpg" style="width: 30%; opacity:0.7" />
                    <img src="img/3.jpg" style="width: 30%; opacity:0.7"/>
                    <img src="img/4.png" style="width: 30% ;opacity:0.7"/>

                </div>
                
                
               


            </div>

        </div>

    </div>


    <div class="" style="margin-right: 0px; margin-left: 0px; padding-top: 10px">
        <div class="col-lg-3" style="margin-bottom:10px">
            <asp:Button ID="btxethb" runat="server" Text="Đăng Ký" class="btn btn-primary" style="float:right" OnClick="btxethb_Click"/>
            <asp:Button ID="Button1" runat="server" Text="Làm Mới" class="btn btn-primary" style="float:right; margin-right:5px" OnClick="Button1_Click"/>
        </div>
        
        
    </div>
     <%
        }
        else
        {

            string scr = "swal('Thông báo','Vui lòng đăng nhập ','error');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);


        }
    %>

</asp:Content>
