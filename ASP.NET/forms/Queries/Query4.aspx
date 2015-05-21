<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query4.aspx.cs" Inherits="IIS.EmployeeCourses.forms.Queries.Query4" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3 style="font-family:'Segoe UI';font-weight:lighter">Процент неуспешного прохождения обязательных курсов</h3>
        <asp:GridView ID="GridView1" ShowHeaderWhenEmpty="true" AutoGenerateColumns="true" runat="server"></asp:GridView>
        <asp:TextBox ID="percent" runat="server"></asp:TextBox>
    </div>
</asp:Content>
