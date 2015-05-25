using System;
using ICSSoft.STORMNET.Web.Controls;
using Resources;

namespace IIS.EmployeeCourses
{

    public partial class CoursesView : BaseListForm<Курс>
    {
        public CoursesView()
            : base(Курс.Views.CoursesView)
        {
            EditPage = КурсE.FormPath;
        }
        public static string FormPath
        {
            get { return "~/forms/Kurs/KursL.aspx"; }
        }
        protected override void Preload()
        {
            WebObjectListView1.Operations.New = false;
            WebObjectListView1.Operations.Edit = false;
            WebObjectListView1.Operations.Delete = false;
            WebObjectListView1.Operations.DeleteInRow = false;
            WebObjectListView1.Operations.EditOnClickInRow = false;
            WebObjectListView1.Operations.EditInRow = false;
            WebObjectListView1.Operations.LimitEdit = false;
        }
    }
}
