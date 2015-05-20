<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Query2.aspx.cs" Inherits="IIS.EmployeeCourses.forms.Queries.Query2" %>
<%@ Import namespace="NewPlatform.Flexberry.Web.Page" %>

<script runat="server">
    protected void Button_Click(object sender, EventArgs e)
    {
        //var table = new System.Data.DataTable();
        //var connection = (System.Data.SqlClient.SqlConnection)((ICSSoft.STORMNET.Business.SQLDataService)
        //    ICSSoft.STORMNET.Business.DataServiceProvider.DataService).GetConnection(); //получение подключения
        //var command = new System.Data.SqlClient.SqlCommand("SELECT SUM(Стоимость) FROM Курс WHERE ДатаНачала >= @FirstDate AND ДатаКонца <= @LastDate", connection); //формирование запроса
        //command.Parameters.AddWithValue("FirstDate", firstDate.Value);
        //command.Parameters.AddWithValue("LastDate", lastDate.Value);
        ////var command = new System.Data.SqlClient.SqlCommand("SELECT SUM(\"Стоимость\") FROM \"Курс\"", connection); //формирование запроса
        //try
        //{
        //    connection.Open();
        //    System.Data.SqlClient.SqlDataReader reader = command.ExecuteReader();
        //    reader.Read();
        //    costSum.Text = reader.GetValue(0).ToString();
        //    reader.Close();
        //}
        //finally
        //{
        //    connection.Close();
        //}
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
        <asp:Button ID="queryButton" Text="Суммарная стоимость" OnClick="RunQuery" runat="server"/>
        <asp:TextBox ID="costSum" runat="server"></asp:TextBox>
    </div>
</asp:Content>
