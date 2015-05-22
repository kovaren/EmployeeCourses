using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;

namespace IIS.EmployeeCourses.forms.Queries
{
    public partial class Query5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RunQuery();
        }
        protected void RunQuery()
        {
            var table = new System.Data.DataTable();
            using (var connection = (System.Data.SqlClient.SqlConnection)((ICSSoft.STORMNET.Business.SQLDataService)
                ICSSoft.STORMNET.Business.DataServiceProvider.DataService).GetConnection()) //получение подключения
            {
                var command = new System.Data.SqlClient.SqlCommand(
                                @"select ТабельныйНомер as 'Табельный номер', Фамилия + ' ' + Имя + ' ' + Отчество as 'ФИО', AVG(Оценка) as 'Средний балл'
                                from Сотрудник inner join Журнал on Сотрудник.primaryKey = Журнал.Сотрудник
                                where Сотрудник.primaryKey in
                                (select distinct Сотрудник from Заявка)
                                group by ТабельныйНомер, Фамилия, Имя, Отчество
                                order by 'Средний балл' desc", connection);

                System.Data.SqlClient.SqlDataAdapter adapt = new System.Data.SqlClient.SqlDataAdapter(command);
                adapt.Fill(table);
            }
            GridView1.DataSource = table.DefaultView;
            GridView1.DataBind();
        }
    }
}