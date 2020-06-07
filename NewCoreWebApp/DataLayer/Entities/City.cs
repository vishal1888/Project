using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
        public State state { get; set; }
    }
}
