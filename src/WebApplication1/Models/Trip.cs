using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Trip
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public String UserName { get; set; }
        public ICollection<Stop> Stops { get; set; }
    }
    
}
