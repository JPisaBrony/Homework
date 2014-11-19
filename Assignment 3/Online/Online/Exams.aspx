<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exams.aspx.cs" Inherits="Online.Chapter_Exams.Exams" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:HyperLink ID="Exam1hyp" runat="server" NavigateUrl="~/Chapter Exams/Exam1.aspx">Exam1</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="Exam2hyp" runat="server" NavigateUrl="~/Chapter Exams/Exam2.aspx">Exam2</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink ID="Exam3hyp" runat="server" NavigateUrl="~/Chapter Exams/Exam3.aspx">Exam3</asp:HyperLink>
</asp:Content>
