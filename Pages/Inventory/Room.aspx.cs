using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class Room : System.Web.UI.Page
    {
        private AssetTrackerDataContext db = new AssetTrackerDataContext();
        private Int32 facility_id, room_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            facility_id = Convert.ToInt32(Page.RouteData.Values["facility_id"]);
            room_id = Convert.ToInt32(Page.RouteData.Values["room_id"]);

            OptionsMenu.FindItem("EditRoom").NavigateUrl = GetRouteUrl("EditRoom", new { room_id = room_id });
            OptionsMenu.FindItem("AddAsset").NavigateUrl = GetRouteUrl("AddAsset", new { facility_id = facility_id, room_id = room_id });

            facility selected_facility = (from f in db.facilities
                                          where f.id == facility_id
                                          select f).Single();

            room selected_room = (from r in db.rooms
                                  where r.id == room_id
                                  select r).Single();

            FacilityName.Text = "Facility: " + selected_facility.name;
            RoomName.Text = "Room: " + selected_room.name;

            var room_assets = from a in db.assets
                              where a.room == room_id &&
                              a.facility == facility_id
                              select new
                              {
                                  ID = a.id,
                                  Name = a.name,
                                  SKU = a.sku,
                                  LastScan = a.last_scan.ToShortDateString(),
                                  DateAdded = a.add_date.ToShortDateString(),
                              };
            assetGrid.DataSource = room_assets;
            assetGrid.DataBind();
        }

        protected void assetSelected(Object sender, EventArgs e)
        {
            GridViewRow selected_row = assetGrid.SelectedRow;
            String selected_asset_id = selected_row.Cells[1].Text;
            Response.RedirectToRoute("ViewAsset", new { asset_id = selected_asset_id });
        }
    }
}