<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query1.aspx.cs" Inherits="IIS.EmployeeCourses.forms.Queries.Query1" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3 style="font-family:'Segoe UI';font-weight:lighter">Список наиболее посещаемых курсов за указанный период</h3>
        <asp:GridView ID="GridView1" ShowHeaderWhenEmpty="true" AutoGenerateColumns="true" runat="server"></asp:GridView>
        <asp:Button ID="queryButton" Text="Запрос" OnClick="Button_Click" runat="server"/>
    </div>
</asp:Content>
