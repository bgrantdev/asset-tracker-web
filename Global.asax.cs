using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace asset_tracker_web
{
    public class Global : System.Web.HttpApplication
    {

        void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        private void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "FacilityRoute", 
                "Facility/{facility_id}", 
                "~/Pages/Inventory/Facility.aspx", true);

            routes.MapPageRoute(
                "AddRoom",
                "AddRoom/{facility_id}",
                "~/Pages/Inventory/AddEditRoom.aspx", true);

            routes.MapPageRoute(
                "RoomRoute",
                "Room/{facility_id}/{room_id}",
                "~/Pages/Inventory/Room.aspx", true);

            routes.MapPageRoute(
                "AddAsset",
                "AddAsset/{facility_id}/{room_id}",
                "~/Pages/Inventory/AddEditAsset.aspx", true);

            routes.MapPageRoute(
                "ViewAsset",
                "ViewAsset/{asset_id}",
                "~/Pages/Inventory/Asset.aspx", true);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }

        void Session_Start(object sender, EventArgs e)
        {
            // Code that runs when a new session is started

        }

        void Session_End(object sender, EventArgs e)
        {
            // Code that runs when a session ends. 
            // Note: The Session_End event is raised only when the sessionstate mode
            // is set to InProc in the Web.config file. If session mode is set to StateServer 
            // or SQLServer, the event is not raised.

        }

    }
}
