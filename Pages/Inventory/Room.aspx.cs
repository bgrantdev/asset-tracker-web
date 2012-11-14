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
        private String s_Facility, s_Room;
        private Int32 i_Facility, i_Room;

        protected void Page_Load(object sender, EventArgs e)
        {
            s_Facility = Page.RouteData.Values["facility_id"] as String;
            s_Room = Page.RouteData.Values["room_id"] as String;

            i_Facility = Int32.Parse(s_Facility);
            i_Room = Int32.Parse(s_Room);

            OptionsMenu.FindItem("AddAsset").NavigateUrl = GetRouteUrl("AddAsset", new { facility_id = s_Facility, room_id = s_Room });

            var room_assets = from a in db.assets
                              where a.room == i_Room &&
                              a.facility == i_Facility
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