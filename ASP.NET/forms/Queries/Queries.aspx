<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Queries.aspx.cs" Inherits="IIS.EmployeeCourses.forms.Queries.Queries" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <table style="font-family:'Segoe UI';font-weight:lighter;font-size:16px;">
        <tr><td></td><td><a href="Query2.aspx">Суммарная стоимость за указанный период</a></td></tr>
        <tr><td></td><td><a href="Query3.aspx">Рейтинг сотрудников по среднему баллу</a></td></tr>
        <tr><td></td><td><a href="Query4.aspx">Процент неуспешного прохождения обязательных курсов</a></td></tr>
        <tr><td></td><td><a href="Query5.aspx">Рейтинг наиболее активных сотрудников, которые предлагают пройти обучение</a></td></tr>
    </table>
    </div>
</asp:Content>
