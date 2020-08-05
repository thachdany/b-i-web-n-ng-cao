<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="xemttsv.aspx.cs" Inherits="GUI.xemdiem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container" style="padding-left: 0px; padding-right: 0px">
    
    <div class="row" style="margin-right: 0px; margin-left: 0px; padding-top: 10px">
        
        <center>
        <div  style=" width:600px; height:120px; border:1px solid #a19d9d">
            <legend style="background-color: orangered; color: white; text-align: center; padding: 5px;">NHẬP THÔNG TIN TÌM KIẾM</legend>
            <div class="col-lg-6">
                <asp:TextBox class="form-control" ID="txttimsinhvien" runat="server" style="width:70%; float:right"></asp:TextBox>
            </div>
            <div class="col-lg-2" style="width: 150px">
                <asp:DropDownList ID="listloc" runat="server" class="form-control">
                    <asp:ListItem>MSSV</asp:ListItem>
                    <asp:ListItem>Tên</asp:ListItem>
                    <asp:ListItem>Địa Chỉ</asp:ListItem>
                    <asp:ListItem>Lớp</asp:ListItem>
                    <asp:ListItem>CVHT</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="col-lg-1">
                <%--<asp:Button class="bg-primary btn" ID="btloc" runat="server" Text="Lọc" OnClick="btloc_Click" />--%>
                <asp:Button ID="seach" runat="server" Text="Tìm" class="bg-primary btn" OnClick="seach_Click"/>
            </div>

        </div>
        </center>
        
        </div>
    <div>
        <legend style="background-color: orangered; color: white; padding: 5px;margin-top:20px"></legend>
    </div>
    <asp:GridView ID="dgvsearch" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="180px" Width="1167px" style="text-align:center">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="MaSV" HeaderText="MSSV"  HeaderStyle-CssClass="text-center" >
            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:BoundField>
            <asp:BoundField DataField="TenSV" HeaderText="Họ &amp; Tên" HeaderStyle-CssClass="text-center">
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="NgaySinh" HeaderText="Ngày Sinh" HeaderStyle-CssClass="text-center" >
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="GioiTinh" HeaderText="Giới Tính" HeaderStyle-CssClass="text-center" >
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="MaLop" HeaderText="Lớp"  HeaderStyle-CssClass="text-center" >
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="TenCVHT" HeaderText="Tên CVHT"  HeaderStyle-CssClass="text-center">
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
            <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ"  HeaderStyle-CssClass="text-center">
<HeaderStyle CssClass="text-center"></HeaderStyle>
            </asp:BoundField>
        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
       
    </asp:GridView>
      
    </div>

   
</asp:Content>