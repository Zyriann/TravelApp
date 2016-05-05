using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class TripRepository
    {
        private TripContext db;

        public TripRepository(TripRepository repository)
        {
            db = repository;
        }

        public void GetAllTrips()
        {
            return IEnumerable < Trip > GetAllTrips;
        }

    }
}
