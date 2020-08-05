<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="trangchu.aspx.cs" Inherits="GUI.trangchu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div id="myCarousel" class="carousel slide" data-ride="carousel" style="overflow:hidden; height:50%">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
    <li data-target="#myCarousel" data-slide-to="1"></li>
    <li data-target="#myCarousel" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
 <div class="carousel-inner" >
    <div class="item active">
     <img src="img/hb1.png" alt="" width="100%" >
    </div>

    <div class="item">
      <img src="img/hb2.jpg" alt="" width="100%" >
    </div>

    <div class="item">
      <img src="img/4.jpg" alt="" width="100%" >
    </div>
  </div>

  <!-- Left and right controls -->
  <a class="left carousel-control" data-target="#myCarousel" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" data-target="#myCarousel" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right"></span>
    <span class="sr-only">Next</span>
  </a>
</div>
    <div class="">
         <div class="form-container">
            <div class="" style="margin-right: 0px; margin-left: 0px">
                <legend style="background-color: orangered; color: white; padding: 5px; padding-left: 10px">THÔNG TIN HỌC BỔNG</legend>
        <div class="col-lg-12">
            <p style="font-size:16px"><span class="glyphicon glyphicon-ok"></span> Thông báo: đề cử sinh viên có hoàn cảnh đặc biệt khó khăn hỗ trợ học phí học kỳ I năm học 2018-2019. </p>
            <p style="font-size:16px"><span class="glyphicon glyphicon-ok"></span> Thông báo: xét chọn sinh viên hoàn cảnh khó khăn nhận học bổng tài trợ Công ty cổ phần Xây dựng Đại Nam. </p>
            <p style="font-size:16px"><span class="glyphicon glyphicon-ok"></span> Thông báo: đề cử sinh viên có hoàn cảnh đặc biệt khó khăn hỗ trợ học phí học kỳ I năm học 2018-2019. </p>
            <p style="font-size:16px"><span class="glyphicon glyphicon-ok"></span> Thông báo: Hỗ trợ học bổng sinh viên có kết quả học tập tốt và hoàn cảnh khó khăn.</p>
                </div>
            
             </div>
        
    </div>
        </div>
</asp:Content>
