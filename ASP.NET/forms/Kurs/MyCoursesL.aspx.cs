using System;
using ICSSoft.STORMNET.Web.Controls;
using Resources;

namespace IIS.EmployeeCourses
{
    
    public partial class MyCoursesL : BaseListForm<Курс>
    {
        public MyCoursesL()
            : base(Курс.Views.MyCoursesL)
        {
            EditPage = MyCoursesE.FormPath;
        }
    }
}
