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
        private Int32 facility_id;
        private String id;

        protected void Page_Load(object sender, EventArgs e)
        {
            //retrieve the facility id from passed data
            id = Page.RouteData.Values["facility_id"] as String;
            facility_id = Int32.Parse(id);

            OptionsMenu.FindItem("AddRoom").NavigateUrl = GetRouteUrl("AddRoom", new {facility_id = id });

            var facility_rooms = from r in db.rooms
                        join a in db.assets on r.id equals a.room into rooms
                        where r.facility == facility_id
                        select new
                        {
                            ID = r.id,
                            Name = r.name,
                            DateAdded = r.add_date,
                            Assets = rooms.Count(),
                        };
            roomGrid.DataSource = facility_rooms;
            roomGrid.DataBind();
        }

        protected void roomSelected(Object sender, EventArgs e)
        {
            GridViewRow selected_row = roomGrid.SelectedRow;
            String selected_room_id = selected_row.Cells[1].Text;

            Response.RedirectToRoute("RoomRoute", new { facility_id = id, room_id = selected_room_id }); 
        }
    }
}