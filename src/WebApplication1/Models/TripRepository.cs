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

        public IEnumerable<Trip> GetAllTrips()
        {
            return db.Trip.ToList;
        }

        public void InsertData(Trip val)
        {
            db.Trip.Add(val);
        }

    }
}
