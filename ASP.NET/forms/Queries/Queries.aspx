<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Queries.aspx.cs" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>
<script runat="server">

    protected void Button1_Click(object sender, EventArgs e)
    {
        var table = new System.Data.DataTable();
        var connection = (System.Data.SqlClient.SqlConnection)((ICSSoft.STORMNET.Business.SQLDataService)
            ICSSoft.STORMNET.Business.DataServiceProvider.DataService).GetConnection(); //получение подключения
        var command = new System.Data.SqlClient.SqlCommand("SELECT SUM(\"Стоимость\") FROM \"Курс\"", connection); //формирование запроса
        try
        {
            connection.Open();
            System.Data.SqlClient.SqlDataAdapter adapt = new System.Data.SqlClient.SqlDataAdapter(command);
            adapt.Fill(table);
        }
        finally
        {
            connection.Close();
        }
        GridView1.DataSource = table.DefaultView;
    }
</script>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <table>
        <tr><td><asp:Button ID="Button1" OnClick="Button1_Click" runat="server" Text="Button" /></td><td>Список наиболее посещаемых курсов за указанный период</td></tr>
        <tr><td></td><td>Суммарная стоимость за указанный период</td></tr>
        <tr><td></td><td>Рейтинг сотрудников по среднему баллу</td></tr>
        <tr><td></td><td>% успешного прохождения обязательных курсов</td></tr>
        <tr><td></td><td>Рейтинг наиболее активных сотрудников, которые предлагают пройти обучение</td></tr>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </table>
    </div>
</asp:Content>
