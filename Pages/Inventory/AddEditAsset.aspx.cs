using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class AddEditAsset : System.Web.UI.Page
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
        }

        protected void addAsset(Object sender, EventArgs e)
        {
            asset new_asset = new asset();
            DateTime date = DateTime.Now;
            String name = assetName.Text;
            String sku = assetSku.Text;

            new_asset.name = name;
            new_asset.sku = sku;
            new_asset.add_date = date;
            new_asset.last_scan = date;
            new_asset.room = i_Room;
            new_asset.facility = i_Facility;
            db.assets.InsertOnSubmit(new_asset);
            db.SubmitChanges();
            Response.RedirectToRoute("RoomRoute", new { facility_id = s_Facility, room_id = s_Room });
        }
    }
}