<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Exam1.aspx.cs" Inherits="Online.Chapter_Exams.Exam1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Question 1:</p>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 2:</p>
    <asp:RadioButtonList ID="RadioButtonList2" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="RadioButtonList2" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    </p>
    <p>
        Question 3:</p>
    <asp:RadioButtonList ID="RadioButtonList3" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="RadioButtonList3" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 4:</p>
    <asp:RadioButtonList ID="RadioButtonList4" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RadioButtonList4" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 5:</p>
    <asp:RadioButtonList ID="RadioButtonList5" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RadioButtonList5" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 6:</p>
    <asp:RadioButtonList ID="RadioButtonList6" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="RadioButtonList6" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 7:</p>
    <asp:RadioButtonList ID="RadioButtonList7" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="RadioButtonList7" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 8:</p>
    <asp:RadioButtonList ID="RadioButtonList8" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="RadioButtonList8" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 9:</p>
    <asp:RadioButtonList ID="RadioButtonList9" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="RadioButtonList9" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        Question 10:</p>
    <asp:RadioButtonList ID="RadioButtonList10" runat="server" Height="16px" Width="321px">
        <asp:ListItem Value="1">True</asp:ListItem>
        <asp:ListItem Value="0">False</asp:ListItem>
    </asp:RadioButtonList>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="RadioButtonList10" ErrorMessage="Must Answer!" ForeColor="#CC0000"></asp:RequiredFieldValidator>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
    </p>
    </asp:Content>
