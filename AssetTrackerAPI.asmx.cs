using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace asset_tracker_web
{
    /// <summary>
    /// Summary description for AssetTrackerAPI
    /// </summary>
    [WebService(Description="Service for pushing and pulling data from asset-tracker database for android client to consume", Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AssetTrackerAPI : System.Web.Services.WebService
    {



        [WebMethod]
        public string GetFacilties()
        {
            return "";
        }

        [WebMethod]
        public string GetFacility(int facility_id)
        {
            return "";
        }

        [WebMethod]
        public bool AddFacility()
        {

            return true;
        }

        [WebMethod]
        public bool UpdateFacility()
        {
            return true;
        }


        [WebMethod]
        public string GetRooms(int facility_id)
        {
            return "";
        }


        [WebMethod]
        public string GetRoom(int room_id)
        {
            return "";
        }

        [WebMethod]
        public bool AddRoom(int facility_id)
        {
            return true;
        }

        [WebMethod]
        public bool UpdateRoom(int room_id)
        {
            return true;
        }

        [WebMethod]
        public string GetFacilityAssets(int facility_id)
        {
            return "";
        }

        [WebMethod]
        public string GetRoomAssets(int room_id)
        {
            return "";
        }

        [WebMethod]
        public bool AddAsset(int facility_id, int room_id)
        {
            return true;
        }

        [WebMethod]
        public bool UpdateAsset(int asset_id)
        {
            return true;
        }

    }
}
