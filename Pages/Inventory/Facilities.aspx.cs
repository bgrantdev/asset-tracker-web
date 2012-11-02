using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class Facilities : System.Web.UI.Page
    {

        private AssetTrackerDataContext db = new AssetTrackerDataContext();
        Guid user_id = (Guid)Membership.GetUser(HttpContext.Current.User.Identity.Name).ProviderUserKey;

        protected void Page_Load(object sender, EventArgs e)
        {
            var facilities = from f in db.facilities
                             where f.user_id == user_id
                             select f;

            facilityGrid.DataSource = facilities;
            facilityGrid.DataBind();
        }
    }
}