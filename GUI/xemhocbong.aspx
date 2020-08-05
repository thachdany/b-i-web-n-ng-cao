<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="xemhocbong.aspx.cs" Inherits="GUI.xemhocbong" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding-left: 0px; padding-right: 0px">
        <div class="form-container">
            <div class="row" style="margin-right: 0px; margin-left: 0px">
                <legend style="background-color: orangered; color: white; text-align: center; padding: 5px;font-size:20px">NHẬP THÔNG TIN TRA CỨU</legend>
                <div class="col-lg-6 ">
                    <div class="form-group">
                        
                            <div class="col-lg-2">
                                <label for="">Mã Lớp:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:DropDownList class="form-control" ID="DropDownlop" runat="server">
                                    <asp:ListItem>DA15TT</asp:ListItem>
                                    <asp:ListItem>DA15QTM</asp:ListItem>
                                    <asp:ListItem>DA16TT</asp:ListItem>
                                    <asp:ListItem>DA16QTM</asp:ListItem>
                                    <asp:ListItem>DA17TT</asp:ListItem>
                                    <asp:ListItem>DA17QTM</asp:ListItem>
                                    <asp:ListItem>DA18TT</asp:ListItem>
                                    <asp:ListItem>DA18QTM</asp:ListItem>
                                    <asp:ListItem>DA19TT</asp:ListItem>
                                    <asp:ListItem>DA19QTM</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        <div class="col-lg-2">
                                <label for="">Học Kì:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:DropDownList class="form-control" ID="DropDownhk" runat="server">
                                    <asp:ListItem>HK1</asp:ListItem>
                                    <asp:ListItem>HK2</asp:ListItem>

                                </asp:DropDownList>
                            </div>
                        

                    </div>
                    <div class="form-group">
                        <div class="row">
                            
                        </div>

                    </div>


                </div>
                <div class="col-lg-6">

                    <div class="form-group">
                        <div class="row">
                            <div class="col-lg-2">
                                <label for="">Năm Học:</label>
                            </div>
                            <div class="col-lg-4">
                                <asp:DropDownList class="form-control" ID="DropDownnamhoc" runat="server">
                                    <asp:ListItem>2015-2016</asp:ListItem>
                                    <asp:ListItem>2016-2017</asp:ListItem>
                                    <asp:ListItem>2017-2018</asp:ListItem>
                                    <asp:ListItem>2018-2019</asp:ListItem>
                                    <asp:ListItem>2019-2020</asp:ListItem>
                                </asp:DropDownList>
                            </div>
                            <asp:Button ID="bthocbong" runat="server" Text="Xem học bổng" class="btn btn-primary" OnClick="bthocbong_Click" />
                        </div>
                        

                    </div>                 
                
                </div>             


            </div>

        </div>

    </div>

    <div class="row" style="margin-right: 0px; margin-left: 0px; padding-top: 10px">
        <legend style="background-color: orangered; color: white; padding: 2px;font-size:15px"></legend>
        <div class="row" style="padding-left: 10px">

        </div>
        <div class="row" style="padding-left: 10px">
        </div>
        <div class="table table-hover" style="text-align: center">
            <center>
             <asp:GridView ID="dgvkqhb" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="157px" Width="1169px" style="text-align:center">
                 <AlternatingRowStyle BackColor="White" />
                 <Columns>
                     <asp:BoundField DataField="MaSV" HeaderText="MSSV"  HeaderStyle-CssClass="text-center" />
                     <asp:BoundField DataField="TenSV" HeaderText="Họ &amp; Tên"  HeaderStyle-CssClass="text-center"/>
                     <asp:BoundField DataField="MaLop" HeaderText="Mã Lớp"  HeaderStyle-CssClass="text-center"/>
                     <asp:BoundField DataField="Hk" HeaderText="Học Kỳ"  HeaderStyle-CssClass="text-center"/>
                     <asp:BoundField DataField="Namhoc" HeaderText="Năm Học"  HeaderStyle-CssClass="text-center"/>
                     <asp:BoundField DataField="DiemTB" HeaderText="Điểm TBHK"  HeaderStyle-CssClass="text-center"/>
                     <asp:BoundField DataField="DiemRL" HeaderText="Điểm RL"  HeaderStyle-CssClass="text-center"/>
                     <asp:BoundField DataField="Xeploai" HeaderText="Xếp Loại"  HeaderStyle-CssClass="text-center" />
                 </Columns>
                 <EditRowStyle BackColor="#2461BF" />
                 <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                 <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                 <RowStyle BackColor="#EFF3FB" />
                 <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />

                </asp:GridView>
        </div>
        <div class="table table-hover" style="text-align: center">
        </div>

        </center>
    </div>

    </div>
</asp:Content>
