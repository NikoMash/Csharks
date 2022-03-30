using Csharks.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Csharks.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShelterController : ControllerBase
    {


        private readonly ILogger<ShelterController> _logger;

        public ShelterController(ILogger<ShelterController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<Shelter>> GetAsync()
        {
            var client = new MongoClient("mongodb+srv://miniprojekt:MEt76yJQK8a8wlxy@miniprojektcluster.rbz0f.mongodb.net/test");
            var database = client.GetDatabase("shelterdb");
            var collection = database.GetCollection<BsonDocument>("shelters");
            var list = await collection.Find(_ => true).ToListAsync();

            List<Shelter> shelters = new List<Shelter>();
            foreach (var item in list)
            {
                Shelter shelter = new Shelter();
                shelter.Id = item["_id"].ToString();
                shelter.Properties.Cvr_navn = item["cvr_navn"].ToString();
                shelter.Properties.Navn = item["navn"].ToString();
               
            };
          
            return shelters;
        }
    }
}
