using ICSSoft.STORMNET.Web.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IIS.EmployeeCourses
{
    public partial class RequestsToConfirmE : BaseListForm<Заявка> 
    {
        public RequestsToConfirmE()
            : base(Заявка.Views.RequestsToConfirmE)
        {
        }
    }
    
}