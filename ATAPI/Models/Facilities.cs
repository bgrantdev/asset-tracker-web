using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace ATAPI
{
    [DeserializeAs(Name="facility")] 
    [SerializeAs(Name="facility")]
    public class Facility
    {
        [DeserializeAs(Name="id")]
        [SerializeAs(Name="id")]
        public UInt32 ID { get; set; }

        [DeserializeAs(Name = "user_id")]
        [SerializeAs(Name = "user_id")]
        public UInt32 UserID { get; set; }

        [DeserializeAs(Name = "name")]
        [SerializeAs(Name = "name")]
        public String FacilityName { get; set; }

        [DeserializeAs(Name = "add-date")]
        [SerializeAs(Name = "add-date")]
        public DateTime AddDate { get; set; }

    }

    public class Facilities : IEnumerable<Facility>
    {
        private static Facilities instance;

        [DeserializeAs(Name="facilities")]
        [SerializeAs(Name="facilities")]
        public List<Facility> FacilityList { get; set; }

        IEnumerator<Facility> IEnumerable<Facility>.GetEnumerator()
        {
            foreach (Facility facility in FacilityList)
            {
                yield return facility;
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (Facility facility in FacilityList)
            {
                yield return facility;
            }
        }

    }
}