using System;
using System.Collections.Generic;
using System.Text;

namespace ParksApp.Models
{
    class Park
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public Dimension Size { get; set; }
        public Location Address { get; set; } = new Location();

        public List<Amenity> Amenities { get; set; } = new List<Amenity>();

        public class Amenity
        {
            public int Quantity { get; set; }
            public Types Type { get; set; }
            public string  Description { get; set; }

            public enum Types
            {
                Swing,
                Slide,
                MonkeyBar,
                Bathroom,
                Pool,
                SkatePark,
                IceRink
            }

            public enum Status
            {
                NotStarted = 0,
                Started = 1,
                Finish=2
                
            }

            public enum Response
            {
                Success = 200,
                Redirect = 300,
                NotFound = 404

            }
        }
       
        

        public class Dimension
        {
            public int Width { get; set; }
            public int Length { get; set; }
            public int Height { get; set; }
        }
        public class Location
        {
            public string Number { get; set; }
            public string Street { get; set; }
            public string City { get; set; }
            public string Province { get; set; }
            public string PostalCode { get; set; }
            public string Country { get; set; }
        }
    

    }
}
