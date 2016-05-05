using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication1.Models;
using AutoMapper;
using WebApplication1.View_Model;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers.API
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {

        private TripRepository trips;

        public TripsController(TripRepository repository)
        {
            trips = repository;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<JsonResult> Get()
        {
            var results = Mapper.Map<IEnumerable<TripViewModel>>(trips);
            return Json(trips.GetAllTrips);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return Trip.Name;
        }

        // POST api/values
        [HttpPost]
        public IEnumerable<JsonResult> Post(TripViewModel trip)
        {
            var newTrip = Mapper.Map<Trip>(trip);
            return Json(trips.InsertData(newTrip));

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
