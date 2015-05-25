using ICSSoft.STORMNET.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICSSoft.STORMNET.Business.LINQProvider;

namespace IIS.EmployeeCourses.forms.Queries
{
    public partial class Query1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void RunQuery()
        {
            //var ds = (SQLDataService)DataServiceProvider.DataService; // Сервис данных.
            //var employees = ds.Query<Журнал>(Журнал.Views.ЖурналL).ToArray();
            //var logs = ds.Query<Курс>(Курс.Views.КурсL).ToArray();
            //var query = employees
            //    .Join(logs,
            //    j => j.Курс.__PrimaryKey,
            //    c => c.__PrimaryKey,
            //    (j, c) => new
            //    {
            //        Курс = c.Название,
            //        Сотрудник = j.Сотрудник,
            //    })
            //    .GroupBy(x => new { x.Курс, x.Сотрудник })
            //    .Select(a => new
            //    {
            //        Курс = a.Key.Курс,
            //        Слушатели = a.Count(y => y.Сотрудник)
            //    })
            //    .OrderByDescending(b => b.Средний_балл)
            //    .ToArray();

            //GridView1.DataSource = query.ToList();
            //GridView1.DataBind();
        }
    }
}