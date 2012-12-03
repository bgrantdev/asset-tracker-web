using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class Asset : System.Web.UI.Page
    {
        private AssetTrackerDataContext db = new AssetTrackerDataContext();
        private Int32 asset_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            asset_id = Convert.ToInt32(Page.RouteData.Values["asset_id"]);

            OptionsMenu.FindItem("EditAsset").NavigateUrl = GetRouteUrl("EditAsset", new { asset_id = asset_id });

            var asset = from a in db.assets
                        where a.id == asset_id
                        select new
                        {
                            Name = a.name,
                            SKU = a.sku,
                            DateAdded = a.add_date.ToShortDateString(),
                            LastScan = a.last_scan.ToShortDateString(),
                        };

            asset selected_asset = (from a in db.assets
                                    where a.id == asset_id
                                    select a).Single();

            facility selected_facility = (from f in db.facilities
                                          where f.id == selected_asset.facility_id
                                          select f).Single();

            room selected_room = (from r in db.rooms
                                  where r.id == selected_asset.room_id
                                  select r).Single();

            FacilityName.Text = selected_facility.name;
            RoomName.Text = selected_room.name;
            AssetDetails.DataSource = asset;
            AssetDetails.DataBind();
        }
    }
}