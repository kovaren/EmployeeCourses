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
            var ds = (SQLDataService)DataServiceProvider.DataService; // Сервис данных.
            var logs = ds.Query<Журнал>(Журнал.Views.ЖурналL).ToArray();
            percent.Text = ((double)logs.Count(x => x.Обязательный && x.Оценка < 6) /
                (double)logs.Count(x => x.Обязательный) * 100).ToString() + "%";
        }
    }
}