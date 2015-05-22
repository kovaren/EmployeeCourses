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
    public partial class Query4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService;
            var logs = ds.Query<Журнал>(Журнал.Views.ЖурналL).ToArray();
            double percentage = ((double)logs
                .Where(y => y.Обязательный && y.Оценка < 6)
                .Select(x => x.Сотрудник.__PrimaryKey)
                .Distinct()
                .Count() /
                (double)logs
                .Where(x => x.Обязательный)
                .Select(x => x.Сотрудник.__PrimaryKey)
                .Distinct()
                .Count() * 100);
            percent.Text = Math.Round(percentage, 2).ToString() + "%";
        }
    }
}