using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;

namespace Work.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "",
                                        "~/Pages/Listing.aspx");
            routes.MapPageRoute("add", "add", "~/Pages/Add.aspx");
            routes.MapPageRoute("AddCancel", "AddCancel", "~/Pages/Listing.aspx");
            routes.MapPageRoute("AddConfirm", "AddConfirm", "~/Pages/Listing.aspx");
            routes.MapPageRoute("edit", "edit", "~/Pages/Edit.aspx");
        }
    }
}