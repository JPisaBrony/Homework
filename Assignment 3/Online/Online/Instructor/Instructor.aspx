<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Instructor.aspx.cs" Inherits="Online.Instructor.Instructor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="227px">
        <asp:ListItem Value="1">Exam1</asp:ListItem>
        <asp:ListItem Value="2">Exam2</asp:ListItem>
        <asp:ListItem Value="3">Exam3</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <strong>Exam Average:</strong>&nbsp;
    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show Above 60%" Width="175px" />
    &nbsp;&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" Text="Show Below 60%" OnClick="Button2_Click" Width="175px" />
    &nbsp;&nbsp;&nbsp;
<asp:Button ID="Button3" runat="server" Text="Show Top 10%" OnClick="Button3_Click" Width="175px" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Show Average" Width="175px" />
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" Height="113px" Width="868px">
    </asp:GridView>
    <strong>
    <asp:GridView ID="GridView2" runat="server" Height="113px" Width="868px">
    </asp:GridView>
    </strong>
</asp:Content>
