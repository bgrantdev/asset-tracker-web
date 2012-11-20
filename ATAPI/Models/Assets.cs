using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp.Serializers;
using RestSharp.Deserializers;

namespace asset_tracker_web.AssetTrackerAPI.Models
{
    [DeserializeAs(Name="asset")]
    [SerializeAs(Name="asset")]
    public class Asset
    {
        [DeserializeAs(Name="id")]
        [SerializeAs(Name="id")]
        public UInt32 ID { get; set; }

        [DeserializeAs(Name = "facility-id")]
        [SerializeAs(Name = "facility-id")]
        public UInt32 FacilityID { get; set; }

        [DeserializeAs(Name = "room-id")]
        [SerializeAs(Name = "room-id")]
        public UInt32 RoomID { get; set; }

        [DeserializeAs(Name = "name")]
        [SerializeAs(Name = "name")]
        public String AssetName { get; set; }

        [DeserializeAs(Name = "sku")]
        [SerializeAs(Name = "sku")]
        public String SKU { get; set; }

        [DeserializeAs(Name = "add-date")]
        [SerializeAs(Name = "add-date")]
        public DateTime AddDate { get; set; }

        [DeserializeAs(Name = "last-scan")]
        [SerializeAs(Name = "last-scan")]
        public DateTime LastScan { get; set; }

    }

    public class Assets
    {
        private static Assets instance;

        [DeserializeAs(Name = "assets")]
        [SerializeAs(Name = "assets")]
        public List<Asset> AssetList { get; set; }

        IEnumerator<Asset> IEnumerable<Asset>.GetEnumerator()
        {
            foreach (Asset asset in AssetList)
            {
                yield return asset;
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (Asset asset in AssetList)
            {
                yield return asset;
            }
        }
    }
}