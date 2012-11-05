using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.Routing;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class Facilities : System.Web.UI.Page
    {

        private AssetTrackerDataContext db = new AssetTrackerDataContext();
        Guid user_id = (Guid)Membership.GetUser(HttpContext.Current.User.Identity.Name).ProviderUserKey;

        protected void Page_Load(object sender, EventArgs e)
        {
            var facilities = from f in db.facilities
                             join r in db.rooms on f.id equals r.facility into rooms
                             join a in db.assets on f.id equals a.facility into assets
                             where f.user_id == user_id
                             select new
                             {
                                 ID = f.id,
                                 Name = f.name,
                                 DateAdded = f.add_date,
                                 Rooms = rooms.Count(),
                                 Assets = assets.Count(),
                             };

            facilityGrid.DataSource = facilities;
            facilityGrid.DataBind();
        }

        protected void facilitySelected(Object sender, EventArgs e)
        {
            GridViewRow selected_row = facilityGrid.SelectedRow;
            String id = selected_row.Cells[1].Text;
            
            Response.RedirectToRoute("FacilityRoute", new { facility_id = id });

        }
    }
}