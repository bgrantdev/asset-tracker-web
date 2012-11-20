using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp.Deserializers;
using RestSharp.Serializers;

namespace ATAPI
{
    [DeserializeAs(Name="room")]
    [SerializeAs(Name="room")]
    public class Room
    {
        [DeserializeAs(Name = "id")]
        [SerializeAs(Name = "id")]
        public UInt32 ID { get; set; }

        [DeserializeAs(Name = "facility_id")]
        [SerializeAs(Name = "facility_id")]
        public UInt32 FacilityID { get; set; }

        [DeserializeAs(Name = "name")]
        [SerializeAs(Name = "name")]
        public String RoomName { get; set; }

        [DeserializeAs(Name = "add-date")]
        [SerializeAs(Name = "add-date")]
        public DateTime AddDate { get; set; }
    }

    public class Rooms
    {
        private static Rooms instance;

        [DeserializeAs(Name = "rooms")]
        [SerializeAs(Name = "rooms")]
        public List<Room> RoomList { get; set; }

        IEnumerator<Room> IEnumerable<Room>.GetEnumerator()
        {
            foreach (Room room in RoomList)
            {
                yield return room;
            }

        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            foreach (Room room in RoomList)
            {
                yield return room;
            }
        }
    }
}