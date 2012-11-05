using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class AddEditRoom : System.Web.UI.Page
    {
        private AssetTrackerDataContext db = new AssetTrackerDataContext();
        private int facility_id;
        private String fac_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            //Get the facility id
            fac_id = (String)Page.RouteData.Values["facility_id"] as String;
            facility_id = Int32.Parse(fac_id);
        }

        protected void submitRoom(Object sender, EventArgs e)
        {
            room new_room = new room();
            DateTime date = DateTime.Now;
            String name = RoomName.Text;

            new_room.add_date = date;
            new_room.facility = facility_id;
            new_room.name = name;
            db.rooms.InsertOnSubmit(new_room);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception exception)
            {

            }
            Response.RedirectToRoute("FacilityRoute", new { facility_id = fac_id });

        }
    }
}