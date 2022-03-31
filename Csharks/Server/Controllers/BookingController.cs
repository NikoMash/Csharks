using Microsoft.AspNetCore.Mvc;
using Csharks.Shared;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using System;

namespace Csharks.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookingController : Controller
    {
       
            private readonly ILogger<BookingController> _logger;

            public BookingController(ILogger<BookingController> logger)
            {
                _logger = logger;
            }
        [HttpPut]
        public async Task<ActionResult<Booking>> PutAsync(Booking nybooking)
        {
            var client = new MongoClient("mongodb+srv://miniprojekt:MEt76yJQK8a8wlxy@miniprojektcluster.rbz0f.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");
            var collection = database.GetCollection<BsonDocument>("booking");
            try
            {
                var document = new BsonDocument
            {
                //{"_id", nybooking.Id},
                {"navn", nybooking.Fuldenavn},
                //{"t_nr", nybooking.Telefon_nr},
                //{"start_dato", nybooking.Start_Dato},
                //{"slut_dato", nybooking.Slut_Dato},
                {"shelter_id", nybooking.Shelter_id },
            };
                collection.InsertOneAsync(document);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }
            return Ok(nybooking); 
        }
    }
}
