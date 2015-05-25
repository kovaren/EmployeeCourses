using ICSSoft.STORMNET.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IIS.EmployeeCourses
{
    public partial class JournalView : BaseListForm<Журнал>
    {
        public JournalView()
            : base(Журнал.Views.JournalView)
        {
        }
        public static string FormPath
        {
            get { return "~/forms/ZHurnal/JournalView.aspx"; }
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