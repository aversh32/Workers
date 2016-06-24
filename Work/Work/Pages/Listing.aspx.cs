using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Work.Models;
using Work.Models.Repository;

namespace Work.Pages
{
    public partial class Listing : System.Web.UI.Page
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


        protected void Add_Click(object sender, EventArgs e)
        {

                        Response.Redirect(RouteTable.Routes
                            .GetVirtualPath(null, "add", null).VirtualPath);               
            
        }
        protected void Edit_Click(object sender, EventArgs e)
        {
           
                Response.Redirect(RouteTable.Routes
                    .GetVirtualPath(null, "edit", null).VirtualPath);
            
        }
    }
}