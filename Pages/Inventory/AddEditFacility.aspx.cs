using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace asset_tracker_web.Pages.Inventory
{
    public partial class AddEditFacility : System.Web.UI.Page
    {

        private AssetTrackerDataContext db = new AssetTrackerDataContext();
        Guid user_id = (Guid)Membership.GetUser(HttpContext.Current.User.Identity.Name).ProviderUserKey;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitFacility(Object sender, EventArgs e)
        {
            facility new_facility = new facility();
            DateTime date = DateTime.Now;
            String name = FacilityName.Text;

            new_facility.user_id = user_id;
            new_facility.name = name;
            new_facility.add_date = date;
            db.facilities.InsertOnSubmit(new_facility);
            try
            {
                db.SubmitChanges();
                Response.Redirect("~/Pages/Inventory/Facilities.aspx");
            }
            catch (Exception exception)
            {

            }

        }
    }
}