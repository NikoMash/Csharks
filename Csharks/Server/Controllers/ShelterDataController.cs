using Csharks.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Csharks.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShelterDataController : Controller
    {
        private readonly ILogger<ShelterDataController> _logger;

        public ShelterDataController(ILogger<ShelterDataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Shelter> Get()
        {
            Shelter[] shelters;
            using (StreamReader r = new StreamReader("booking.json"))
            {
                string json = r.ReadToEnd();
                shelters = JsonConvert.DeserializeObject<Shelter[]>(json);
            }
            return shelters;
        }
    }
}
