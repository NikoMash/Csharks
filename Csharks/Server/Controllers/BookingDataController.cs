using Csharks.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Csharks.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingDataController : Controller
    {
        private readonly ILogger<BookingDataController> _logger;

        public BookingDataController(ILogger<BookingDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Booking>> GetAsync()
        {
            var client = new MongoClient("mongodb+srv://miniprojekt:MEt76yJQK8a8wlxy@miniprojektcluster.rbz0f.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");
            var collection = database.GetCollection<BsonDocument>("booking");
            var list = await collection.Find(_ => true).ToListAsync();

            List<Booking> bookingList = new List<Booking>();
            foreach (var item in list)
            {
                Booking bookings = new Booking();
                {
                    bookings.Shelter_id = item["_id"].ToString();
  
                    bookings.Fuldenavn = item["navn"].ToString();

                    bookings.Telefon_nr = item["t_nr"].ToString();

                    bookings.Start_Dato = (DateTime)item["start_dato"];

                    bookings.Slut_Dato = (DateTime)item["slut_dato"];
                };
                bookingList.Add(bookings);

            }

            return bookingList;

        }
    }
}

    

