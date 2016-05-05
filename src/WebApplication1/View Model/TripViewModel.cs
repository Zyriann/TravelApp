using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.View_Model
{
    public class TripViewModel
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public DateTime Date { get; set; }
        public String UserName { get; set; }
        public ICollection<StopViewModel> Stops { get; set; }
    }
}
