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
        private Int32 facility_id, room_id, asset_id;
        private asset selected_asset = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            //If contains a room id and a facility id we are creating the asset.
            if (Page.RouteData.Values["room_id"] != null && Page.RouteData.Values["facility_id"] != null)
            {
                facility_id = Convert.ToInt32(Page.RouteData.Values["facility_id"]);
                room_id = Convert.ToInt32(Page.RouteData.Values["room_id"]);
            }
            //If asset id is not null we are editing an asset.
            else if (Page.RouteData.Values["asset_id"] != null)
            {
                asset_id = Convert.ToInt32(Page.RouteData.Values["asset_id"]);
                selected_asset = (from a in db.assets
                                  where a.id == asset_id
                                  select a).Single();

                facility_id = selected_asset.facility_id;
                room_id = selected_asset.room_id;
                if (!Page.IsPostBack)
                {
                    AssetName.Text = selected_asset.name;
                    AssetSku.Text = selected_asset.sku;
                    AssetDescription.Text = selected_asset.description;
                }
            }
        }

        protected void submitAsset(Object sender, EventArgs e)
        {
            //If selected asset is null then creating a new asset.
            if (selected_asset == null)
            {
                selected_asset = new asset();
                selected_asset.facility_id = facility_id;
                selected_asset.room_id = room_id;
                selected_asset.name = AssetName.Text;
                selected_asset.last_scan = DateTime.Now;
                selected_asset.add_date = DateTime.Now;
                selected_asset.sku = AssetSku.Text;
                selected_asset.description = AssetDescription.Text;
                db.assets.InsertOnSubmit(selected_asset);
                db.SubmitChanges();
            }
            //If not null then simply updating the name and sku
            else
            {
                selected_asset.name = AssetName.Text;
                selected_asset.sku = AssetSku.Text;
                selected_asset.description = AssetDescription.Text;
                db.SubmitChanges();
            }

            Response.RedirectToRoute("ViewRoom", new { facility_id = facility_id, room_id = room_id });
        }
    }
}