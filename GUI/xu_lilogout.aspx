<%@ Page Title="" Language="C#" MasterPageFile="~/header.Master" AutoEventWireup="true" CodeBehind="xu_lilogout.aspx.cs" Inherits="GUI.xu_lilogout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%
        Session.Abandon();
        Response.Redirect("dangnhap.aspx");
    %>
</asp:Content>
