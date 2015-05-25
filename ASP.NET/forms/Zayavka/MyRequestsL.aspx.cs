using ICSSoft.STORMNET;
using ICSSoft.STORMNET.FunctionalLanguage;
using ICSSoft.STORMNET.FunctionalLanguage.SQLWhere;
using ICSSoft.STORMNET.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace IIS.EmployeeCourses
{
    public partial class MyRequestsL : BaseListForm<Заявка>
    {
        public MyRequestsL() : base(Заявка.Views.MyRequestsL)
        {
            EditPage = MyRequestsE.FormPath;
        }
        public static string FormPath
        {
            get { return "~/forms/Zayavka/MyRequestsL.aspx"; }
        }
        protected override void Preload()
        {
            ICSSoft.Services.CurrentUser user = new ICSSoft.Services.CurrentUser();
            string id = user.Login;
            SQLWhereLanguageDef langdef = SQLWhereLanguageDef.LanguageDef;
            Function lf = langdef.GetFunction(langdef.funcEQ, new VariableDef(langdef.StringType, Information.ExtractPropertyPath<Сотрудник>(x => x.ID), id));
            WebObjectListView1.LimitFunction = lf;
        }
    }
}