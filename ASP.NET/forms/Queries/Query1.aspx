<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query1.aspx.cs" Inherits="IIS.EmployeeCourses.forms.Queries.Query1" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<script runat="server">
    protected void Button_Click(object sender, EventArgs e)
    {
        var table = new System.Data.DataTable();
        var connection = (System.Data.SqlClient.SqlConnection)((ICSSoft.STORMNET.Business.SQLDataService)
            ICSSoft.STORMNET.Business.DataServiceProvider.DataService).GetConnection(); //получение подключения
        var command = new System.Data.SqlClient.SqlCommand("SELECT * FROM Сотрудник", connection); //формирование запроса
        //var command = new System.Data.SqlClient.SqlCommand("SELECT SUM(\"Стоимость\") FROM \"Курс\"", connection); //формирование запроса
        try
        {
            connection.Open();
            System.Data.SqlClient.SqlDataAdapter adapt = new System.Data.SqlClient.SqlDataAdapter(command);
            adapt.Fill(table);
            table.Columns.RemoveAt(0);
        }
        finally
        {
            connection.Close();
        }
        GridView1.DataSource = table.DefaultView;
        GridView1.DataBind();
    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3 style="font-family:'Segoe UI';font-weight:lighter">Список наиболее посещаемых курсов за указанный период</h3>
        <div class="descTxt">
            <ac:DatePicker ID="firstDate" Text="Начало периода" runat="server"/>
        </div>
        <div class="descTxt">
            <ac:DatePicker ID="lastDate" Text="Конец периода" runat="server"/>
        </div>
        <asp:GridView ID="GridView1" ShowHeaderWhenEmpty="true" AutoGenerateColumns="true" runat="server"></asp:GridView>
        <asp:Button ID="queryButton" Text="Запрос" OnClick="Button_Click" runat="server"/>
    </div>
</asp:Content>
