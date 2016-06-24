using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Work.Models;
using Work.Models.Repository;

namespace Work.Pages
{
    public partial class Edit : System.Web.UI.Page
    {
        private Repository repository = new Repository();

        protected IEnumerable<Worker> GetWorkers()
        {
            return repository.Workers;
        }
        protected IEnumerable<Language> GetLanguage()
        {
            return repository.Language;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            /* if (Request.QueryString[")
             {
                 Response.Redirect(RouteTable.Routes
                     .GetVirtualPath(null, "add", null).VirtualPath);
             }*/
        }
        public void InsertWorker()
        {
            Worker myWorker = new Worker();
            if (TryUpdateModel(myWorker,
                new FormValueProvider(ModelBindingExecutionContext)))
            {
                repository.SaveWorker(myWorker);
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(RouteTable.Routes
    .GetVirtualPath(null, "AddCancel", null).VirtualPath);
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            InsertWorker();
            Response.Redirect(RouteTable.Routes
    .GetVirtualPath(null, "AddConfirm", null).VirtualPath);
        }
    }
}