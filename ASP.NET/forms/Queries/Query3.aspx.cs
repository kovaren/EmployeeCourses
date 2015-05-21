using ICSSoft.STORMNET.Business;
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
    public partial class Query3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void RunQuery(object sender, EventArgs e)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService; // Сервис данных.
            var employees = ds.Query<Сотрудник>(Сотрудник.Views.СотрудникL).ToArray();
            var logs = ds.Query<Журнал>(Журнал.Views.ЖурналL).ToArray();
            //var query =
            //     from employee in employees
            //     join log in logs on employee.__PrimaryKey equals log.Сотрудник
            //     select new
            //     {
            //         ТабельныйНомер = employee.ТабельныйНомер,
            //         Фамилия = employee.Фамилия,
            //         Имя = employee.Имя,
            //         Оценка = log.Оценка
            //     };

            var temp =
                employees.Join
                (
                    logs,
                    first => first.__PrimaryKey,
                    second => second.Сотрудник.__PrimaryKey,
                    (emp, log) => new
                    {
                        tab=emp.ТабельныйНомер,
                        roman=log.Оценка
                    }
                ).ToArray();


            //var query = employees
            //    .Join(logs, 
            //    emp => emp.__PrimaryKey, 
            //    l => l.Сотрудник,
            //    (emp, l) => new { emp })
            //    .GroupBy(emp => emp.emp)
            //    .Select(emp => new 
            //    {
            //        ТабельныйНомер = emp.Key.ТабельныйНомер,
            //         Фамилия = emp.Key.Фамилия,
            //         Имя = emp.Key.Имя,
            //    }).Single();


            
            GridView1.DataSource = temp.ToList();
            GridView1.DataBind();
            
            //select ТабельныйНомер as 'Табельный номер', Фамилия, Имя, AVG(Оценка) as 'Средний балл'
            //from Сотрудник inner join Журнал on Сотрудник.primaryKey = Журнал.Сотрудник
            //group by ТабельныйНомер, Фамилия, Имя, Обязательный
            //order by 'Средний балл' desc
        }
    }
}