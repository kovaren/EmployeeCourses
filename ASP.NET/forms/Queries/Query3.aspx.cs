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
            //var ds = (SQLDataService)DataServiceProvider.DataService; // Сервис данных.
            //IQueryable<Сотрудник> employees = ds.Query<Сотрудник>(Сотрудник.Views.СотрудникL);
            //IQueryable<Журнал> logs = ds.Query<Журнал>(Журнал.Views.ЖурналL);
            //IQueryable<Сотрудник> query =
            //    from employees
            //    join logs on o.__PrimaryKey equals l.Сотрудник
            //    select o.ТабельныйНомер, Фамилия;
            //double sum = query.AsEnumerable().Sum(x => x.Стоимость);
            //costSum.Text = sum.ToString();

            //select ТабельныйНомер as 'Табельный номер', Фамилия, Имя, AVG(Оценка) as 'Средний балл'
            //from Сотрудник inner join Журнал on Сотрудник.primaryKey = Журнал.Сотрудник
            //group by ТабельныйНомер, Фамилия, Имя, Обязательный
            //order by 'Средний балл' desc
        }
    }
}