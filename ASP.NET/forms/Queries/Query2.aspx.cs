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
    public partial class Query2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void RunQuery(object sender, EventArgs e)
        {
            var ds = (SQLDataService)DataServiceProvider.DataService; // Сервис данных.
            IQueryable<Курс> courses = ds.Query<Курс>(Курс.Views.КурсL);
            IQueryable<Курс> query =
                from o in courses
                where o.ДатаНачала >= firstDate.Value && o.ДатаКонца <= lastDate.Value
                select o;
            double sum = query.AsEnumerable().Sum(x => x.Стоимость);
            costSum.Text = sum.ToString();
        }
    }
}