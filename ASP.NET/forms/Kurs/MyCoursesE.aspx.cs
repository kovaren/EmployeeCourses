using System;
using ICSSoft.STORMNET.Web.Controls;
using Resources;

namespace IIS.EmployeeCourses
{
    
    public partial class MyCoursesE : BaseListForm<Курс>
    {
        public MyCoursesE()
            : base(Курс.Views.MyCoursesE)
        {
        }
        public static string FormPath
        {
            get { return "~/forms/Kurs/MyCoursesE.aspx"; }
        }
    }
}
