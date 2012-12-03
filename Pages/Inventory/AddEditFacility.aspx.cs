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
        private Guid user_id = (Guid)Membership.GetUser(HttpContext.Current.User.Identity.Name).ProviderUserKey;
        private facility selected_facility = null;
        private address selected_address = null;
        private int facility_id;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.RouteData.Values["facility_id"] != null)
            {
                facility_id = Convert.ToInt32(Page.RouteData.Values["facility_id"]);
                selected_facility = (from f in db.facilities
                                     where f.id == facility_id
                                     select f).Single();
                selected_address = (from a in db.addresses
                                    where a.id == selected_facility.address_id
                                    select a).Single();

                if (!Page.IsPostBack)
                {
                    FacilityName.Text = selected_facility.name;
                    Address1.Text = selected_address.line_1;
                    Address2.Text = selected_address.line_2;
                    CityName.Text = selected_address.city;
                    StateName.Text = selected_address.state;
                    ZipName.Text = selected_address.zip;
                }
            }
        }

        protected void submitFacility(Object sender, EventArgs e)
        {
            //If null then this is creating a facility to add
            if (selected_facility == null)
            {
                selected_facility = new facility();
                selected_address = new address();
                selected_address.line_1 = Address1.Text;
                selected_address.line_2 = Address2.Text;
                selected_address.city = CityName.Text;
                selected_address.state = StateName.Text;
                selected_address.zip = ZipName.Text;
                db.addresses.InsertOnSubmit(selected_address);
                db.SubmitChanges();
                selected_facility.user_id = user_id;
                selected_facility.name = FacilityName.Text;
                selected_facility.address_id = selected_address.id;
                selected_facility.add_date = DateTime.Now;
                db.facilities.InsertOnSubmit(selected_facility);
                db.SubmitChanges();
                
            }
            //If not then we are editing an existing facility
            else
            {
                selected_facility.name = FacilityName.Text;
                selected_address.line_1 = Address1.Text;
                selected_address.line_2 = Address2.Text;
                selected_address.city = CityName.Text;
                selected_address.state = StateName.Text;
                selected_address.zip = ZipName.Text;
                db.SubmitChanges();
            }
            Response.Redirect("~/Pages/Inventory/Facilities.aspx");           
        }
    }
}