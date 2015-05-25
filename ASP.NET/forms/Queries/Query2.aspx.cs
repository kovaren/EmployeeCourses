using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICSSoft.STORMNET.Business;
using ICSSoft.STORMNET.Business.LINQProvider;
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
using ICSSoft.STORMNET.FunctionalLanguage;
using ICSSoft.STORMNET;

namespace IIS.EmployeeCourses.forms.Queries
{
    public partial class Query2 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        public void RunQuery(object sender, EventArgs e)
        {
            Курс course = new Курс();
            SQLWhereLanguageDef langdef = SQLWhereLanguageDef.LanguageDef;
            Function lf =
                langdef.GetFunction(langdef.funcAND,
                langdef.GetFunction(langdef.funcGEQ, new VariableDef(
                    langdef.DateTimeType, Information.ExtractPropertyPath<Курс>(x => x.ДатаНачала)), firstDate.Value),
                langdef.GetFunction(langdef.funcLEQ, new VariableDef(
                    langdef.DateTimeType, Information.ExtractPropertyPath<Курс>(x => x.ДатаКонца)), lastDate.Value));

            ICSSoft.STORMNET.Business.LoadingCustomizationStruct lcs =
                    ICSSoft.STORMNET.Business.LoadingCustomizationStruct.GetSimpleStruct(typeof(Курс), Курс.Views.КурсL);
            lcs.LoadingTypes = new Type[] { typeof(Курс) };
            lcs.LimitFunction = lf;
            ICSSoft.STORMNET.DataObject[] objs = ICSSoft.STORMNET.Business.DataServiceProvider.DataService.LoadObjects(lcs);
            var query = DataServiceProvider.DataService.LoadObjects(lcs).Cast<Курс>();
            double sum = query.AsEnumerable().Sum(c => c.Стоимость);
            costSum.Text = sum.ToString();
        }
    }
}