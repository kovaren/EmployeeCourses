<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query2.aspx.cs" Inherits="IIS.EmployeeCourses.forms.Queries.Query2" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3 style="font-family:'Segoe UI';font-weight:lighter">Список наиболее посещаемых курсов за указанный период</h3>
        <div class="descTxt">
            <ac:DatePicker ID="firstDate" Text="Начало периода" runat="server"/>
        </div>
        <div class="descTxt">
            <ac:DatePicker ID="lastDate" Text="Конец периода" runat="server"/>
        </div>
        <asp:Button ID="queryButton" Text="Суммарная стоимость" OnClick="RunQuery" runat="server"/>
        <asp:TextBox ID="costSum" runat="server"></asp:TextBox>
    </div>
</asp:Content>
