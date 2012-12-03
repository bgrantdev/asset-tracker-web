using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class Facility : System.Web.UI.Page
    {
        private AssetTrackerDataContext db = new AssetTrackerDataContext();
        private int facility_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieve the facility id from passed data
            facility_id = Convert.ToInt32(Page.RouteData.Values["facility_id"]);

            OptionsMenu.FindItem("EditFacility").NavigateUrl = GetRouteUrl("EditFacility", new { facility_id = facility_id });
            OptionsMenu.FindItem("AddRoom").NavigateUrl = GetRouteUrl("AddRoom", new { facility_id = facility_id });

            facility selected_facility = (from f in db.facilities
                                     where f.id == facility_id
                                     select f).Single();

            FacilityName.Text = selected_facility.name;

            var facility_rooms = from r in db.rooms
                        join a in db.assets on r.id equals a.room into rooms
                        where r.facility == facility_id
                        select new
                        {
                            ID = r.id,
                            Name = r.name,
                            DateAdded = r.add_date.ToShortDateString(),
                            Assets = rooms.Count(),
                        };
            
            roomGrid.DataSource = facility_rooms;
            roomGrid.DataBind();
        }

        protected void roomSelected(Object sender, EventArgs e)
        {
            GridViewRow selected_row = roomGrid.SelectedRow;
            String selected_room_id = selected_row.Cells[1].Text;

            Response.RedirectToRoute("ViewRoom", new { facility_id = facility_id, room_id = selected_room_id }); 
        }
    }
}