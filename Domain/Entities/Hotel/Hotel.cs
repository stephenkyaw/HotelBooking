﻿using Domain.Common;

namespace Domain.Entities
{
    public class Hotel : BaseAuditEntity
    {
        public string HotelId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        public string Phone_1 { get; set; }
        public string Phone_2 { get; set; }
        public string Phone_3 { get; set; }

        public string CityId { get; set; }
        public City City { get; set; }

        public string TownshipId { get; set; }
        public Township Township { get; set; }
        public IEnumerable<HotelPhoto> HotelPhotos { get; set; } = new List<HotelPhoto>();

        public virtual IEnumerable<Room> Rooms { get; set; }
        public Hotel()
        {
            HotelId = Guid.NewGuid().ToString();
            CreatedDate = DateTime.Now;
        }
    }
}
