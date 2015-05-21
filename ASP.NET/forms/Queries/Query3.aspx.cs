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
            RunQuery();
        }

        public void RunQuery()
        {
            var ds = (SQLDataService)DataServiceProvider.DataService; // Сервис данных.
            var employees = ds.Query<Сотрудник>(Сотрудник.Views.СотрудникL).ToArray();
            var logs = ds.Query<Журнал>(Журнал.Views.ЖурналL).ToArray();
            var query = employees
                .Join(logs,
                emp => emp.__PrimaryKey,
                log => log.Сотрудник.__PrimaryKey,
                (emp, log) => new
                {
                    ТабельныйНомер = emp.ТабельныйНомер,
                    ФИО = emp.Фамилия + " " + emp.Имя + " " + emp.Отчество,
                    Оценка = log.Оценка
                })
                .GroupBy(x => new { x.ТабельныйНомер, x.ФИО })
                .Select(a => new
                {
                    Табельный_номер = a.Key.ТабельныйНомер,
                    ФИО = a.Key.ФИО,
                    Средний_балл = a.Average(y => y.Оценка)
                })
                .OrderByDescending(b => b.Средний_балл)
                .ToArray();

            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}