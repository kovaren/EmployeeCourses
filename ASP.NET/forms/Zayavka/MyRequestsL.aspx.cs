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
    }
}