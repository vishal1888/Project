using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public ICollection<City> cities { get; set; }
    }
}
