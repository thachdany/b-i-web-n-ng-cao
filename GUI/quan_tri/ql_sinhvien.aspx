﻿<%@ Page Title="" Language="C#" MasterPageFile="~/quan_tri/Site1.Master" AutoEventWireup="true" CodeBehind="ql_sinhvien.aspx.cs" Inherits="GUI.quan_tri.ql_sinhvien" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <style>
        table, th, td {
          border: 0px solid black;
          border-collapse: collapse;
        }
        th, td {
          padding: 5px;
          text-align: left;    
        }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div >
        <center><h1> QUẢN LÝ SINH VIÊN</h1></center>
        <form>
            <div class="form-group">
               
                <table ">
                    <tr >
                        <td> <asp:Label ID="Label2" runat="server" Text="Mã sinh viên"></asp:Label> </td>

                        <td> <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style1" placeholder="Nhập mã sinh viên" Width="249px"     ></asp:TextBox></td>
                    </tr>

                  <tr >
                        <td> <asp:Label ID="Label1" runat="server" Text="Tên sinh viên"></asp:Label> </td>
                        <td>  <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style1" placeholder="Tên sinh viên" Width="249px"></asp:TextBox></td>
                    </tr>
                    
                    <tr >
                        <td> <asp:Label ID="Label5" runat="server" Text="Ngày sinh"></asp:Label> </td>
                        <td>  <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style1" placeholder="Moth/day/year" Width="249px"></asp:TextBox></td>
                    </tr>
                    <tr >
                        <td> <asp:Label ID="Label6" runat="server" Text="Giới tính"></asp:Label> </td>
                        <td>  <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style1" placeholder="Giới tính sinh viên" Width="249px"></asp:TextBox></td>
                    </tr>
                    <tr >
                        <td> <asp:Label ID="Label7" runat="server" Text="Tên Cố Vấn học tập "></asp:Label> </td>
                        <td>  <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style1" placeholder="Tên cố vấn học tập " Width="249px"></asp:TextBox></td>
                    </tr>
                     <tr >
                        <td> <asp:Label ID="Label8" runat="server" Text="Địa Chỉ sinh viên "></asp:Label> </td>
                        <td>  <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style1" placeholder="Địa chỉ sinh viên" Width="249px"></asp:TextBox></td>
                    </tr>
                    <tr >
                        <td> <asp:Label ID="Label9" runat="server" Text="Mã Lớp "></asp:Label> </td>
                        <td> <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList> </td>
                    </tr>

                </table>



                    


            </div>
            <asp:Button ID="Button1" runat="server" Text="Thêm Mới" CssClass="btn-success" OnClick="Button1_Click1"/>
        </form>


        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Thêm" CssClass="btn-success" OnClick="Button2_Click"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Xóa" CssClass="btn-success"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Text="Sửa" CssClass="btn-success"/>
    &nbsp;&nbsp;<asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />&nbsp;<br />

       
          <asp:GridView ID="dgvdiemhk1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" Width="1160px" Height="164px" style="text-align:center" OnSelectedIndexChanged="dgvdiemhk1_SelectedIndexChanged" EnableModelValidation="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="MaSV" HeaderText="Mã Sinh Viên"  HeaderStyle-CssClass="text-center" >
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="TenSV" HeaderText=" Tên Sinh Viên"  HeaderStyle-CssClass="text-center">        
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
              <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh"  HeaderStyle-CssClass="text-center">        
          
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="Gioitinh" HeaderText="Giới Tính" />
            <asp:BoundField DataField="TenCVHT" HeaderText="TenCVHT" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ " />
            <asp:BoundField DataField="TenLop" HeaderText="Tên Lớp" />
          
            <asp:CommandField ShowSelectButton="True" ControlStyle-Width="25px" ControlStyle-Height="25px" ButtonType="Image" SelectImageUrl="~/img/edit.png" >
<ControlStyle Height="25px" Width="25px"></ControlStyle>
            </asp:CommandField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
               
     
    </asp:GridView>

        <br />
    </div>



</asp:Content>
