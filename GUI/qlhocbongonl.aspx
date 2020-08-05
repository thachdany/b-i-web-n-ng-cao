<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="qlhocbongonl.aspx.cs" Inherits="GUI.qlhocbongonl" %>

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
        if (quyen == 1)
        {
            //string scr = "swal('Thông báo','Xin chào admin','success');";
            //Page.ClientScript.RegisterStartupScript(this.GetType(), "tt", scr, true);
    %>
    <div class="container" style="padding-left: 0px; padding-right: 0px">
        <div class="form-container">
            <div class="row" style="margin-right: 0px; margin-left: 0px">
                <legend style="background-color: orangered; color: white; padding: 5px; padding-left: 10px">NHẬP THÔNG TIN</legend>
                <div class="col-lg-6 ">

                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">MSSV:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox ID="txtms" runat="server" ReadOnly="true" Style="font-weight: bold; border: none; font-size: 14px; font-family: Arial"></asp:TextBox>
                            </div>
                        </div>

                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Họ & Tên:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox ID="txtten" runat="server" ReadOnly="true" Style="font-weight: bold; border: none; font-size: 14px; font-family: Arial"></asp:TextBox>
                            </div>
                        </div>

                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Lớp:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox Style="font-weight: bold; border: none; font-size: 14px; font-family: Arial" ID="txtlop" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>

                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Điạ Chỉ:</label>
                            </div>
                            <div class="col-lg-8">
                                <asp:TextBox Style="font-weight: bold; border: none; font-size: 14px; font-family: Arial" ID="txtdiachi" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>

                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">SĐT:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:TextBox class="form-control" ID="txtsdt" runat="server" onkeypress="return isNumberKey(event)"></asp:TextBox>
                            </div>
                        </div>

                    </div>

                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
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
                                <label for="">Hoàn cảnh:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:TextBox ID="TextBox1" class="form-control" TextMode="MultiLine" runat="server" Rows="8" placeholder="Vui lòng nhập ngắn gọn hoàn cảnh khoảng 200 ki tự" Style="width: 600px"></asp:TextBox>
                            </div>
                        </div>

                    </div>
                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Duyệt:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:DropDownList ID="txthientrang" runat="server" class="form-control">
                                    <asp:ListItem>Đã duyệt</asp:ListItem>
                                    <asp:ListItem>Không đạt yêu cầu</asp:ListItem>                                    
                                </asp:DropDownList>
                            </div>
                        </div>

                    </div>

                </div>
                <div class="col-lg-6">

                    <img src="img/2.jpg" style="width: 30%; opacity: 0.7" />
                    <img src="img/3.jpg" style="width: 30%; opacity: 0.7" />
                    <img src="img/4.png" style="width: 30%; opacity: 0.7" />

                </div>

               





            </div>

        </div>
                <div class="" style="margin-right: 0px; margin-left: 0px; padding-top: 10px">
                    <div class="col-lg-3" style="margin-bottom: 20px">

                        <asp:Button ID="btduyet" runat="server" Text="Duyệt" class="btn btn-primary" Style="float: right" OnClick="btduyet_Click" />
                        <asp:Button ID="btclean" runat="server" Text="Làm Mới" class="btn btn-primary" Style="float: right; margin-right: 5px" />
                    </div>


                </div>

    </div>

                

    <div class="form-container" style="margin-bottom:20px">
        <div class="row" style="margin-right: 0px; margin-left: 0px">
            <legend style="background-color: orangered; color: white; padding: 5px; padding-left: 10px">NHẬP THÔNG TIN</legend>
            <asp:GridView ID="dgvxethb" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="173px" Width="1170px" AutoGenerateColumns="False" OnSelectedIndexChanged="dgvxethb_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="MaSV" HeaderText="MSSV" />
                    <asp:BoundField DataField="TenSV" HeaderText="Họ &amp; Tên" />
                    <asp:BoundField DataField="SDT" HeaderText="SĐT" />
                    <asp:BoundField DataField="Dienkhokhan" HeaderText="Diện Khó Khăn" />
                    <asp:BoundField DataField="Hientrang" HeaderText="Duyệt" />
                    <asp:BoundField DataField="Hoancanh" HeaderText="Hoàn Cảnh" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                
            </asp:GridView>
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
