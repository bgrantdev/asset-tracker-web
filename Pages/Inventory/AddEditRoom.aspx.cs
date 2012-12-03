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
        private int facility_id, room_id;
        private room selected_room = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //If facility_id in values creating a new room
            if (Page.RouteData.Values["facility_id"] != null)
            {
                facility_id = Convert.ToInt32(Page.RouteData.Values["facility_id"]);

            }
            //If room id in values then we are editing an existing rooom
            else if (Page.RouteData.Values["room_id"] != null)
            {
                room_id = Convert.ToInt32(Page.RouteData.Values["room_id"]);
                selected_room = (from r in db.rooms
                                 where r.id == room_id
                                 select r).Single();

                facility_id = selected_room.facility_id;
                if (!Page.IsPostBack)
                {
                    RoomName.Text = selected_room.name;
                }
            }
        }

        protected void submitRoom(Object sender, EventArgs e)
        {
            //If selected room is null then creating a new room to add
            if (selected_room == null)
            {
                selected_room = new room();
                selected_room.facility_id = facility_id;
                selected_room.name = RoomName.Text;
                selected_room.add_date = DateTime.Now;
                db.rooms.InsertOnSubmit(selected_room);
                db.SubmitChanges();
            }
            //If not null then we are editing an existing room
            else
            {
                selected_room.name = RoomName.Text;
                db.SubmitChanges();
            }
            Response.RedirectToRoute("ViewFacility", new { facility_id = facility_id });
        }
    }
}