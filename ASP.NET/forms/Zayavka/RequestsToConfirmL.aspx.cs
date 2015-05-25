using ICSSoft.STORMNET.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IIS.EmployeeCourses
{
    public partial class RequestsToConfirmL : BaseListForm<Заявка>
    {
        public RequestsToConfirmL() : base(Заявка.Views.RequestsToConfirmL)
        {
            EditPage = RequestsToConfirmL.FormPath;
        }
        public static string FormPath
        {
            get { return "~/forms/Zayavka/RequestsToConfirmL.aspx"; }
        }
    }
}