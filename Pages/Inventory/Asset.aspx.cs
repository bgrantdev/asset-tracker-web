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
        private String s_Asset;
        private Int32 i_Asset;

        protected void Page_Load(object sender, EventArgs e)
        {
            s_Asset = Page.RouteData.Values["asset_id"] as String;
            i_Asset = Int32.Parse(s_Asset);

            var asset = from a in db.assets
                        where a.id == i_Asset
                        select a;

            AssetDetails.DataSource = asset;
            AssetDetails.DataBind();
        }
    }
}