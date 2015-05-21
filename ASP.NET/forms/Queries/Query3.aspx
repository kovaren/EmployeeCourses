<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query3.aspx.cs" Inherits="IIS.EmployeeCourses.forms.Queries.Query3" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3 style="font-family:'Segoe UI';font-weight:lighter">Рейтинг сотрудников по среднему баллу</h3>
        <asp:GridView ID="GridView1" ShowHeaderWhenEmpty="true" RowStyle-HorizontalAlign="Center" AutoGenerateColumns="true" runat="server"></asp:GridView>
    </div>
</asp:Content>
