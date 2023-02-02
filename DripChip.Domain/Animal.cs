using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DripChip.Domain
{
    public class Animal
    {
        public int id { get; set; }
        public long[] animalTypes { get; set; }
        public float weight { get; set; }
        public float length { get; set; }
        public float height { get; set; }
        public string gender { get; set; }
        public string lifeStatus { get; set; }
        public DateTime chippingDateTime { get; set; }
        public int chipperId { get; set; }
        public long chippingLocationId { get; set; }
        public long[] visitedLocations { get; set; }
        public DateTime? deathDateTime { get; set; }


    }
}
