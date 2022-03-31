using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharks.Shared
{
    public class Booking
    {
        [BsonElement("_id")]
        public string Id { get; set; }

        [BsonElement("shelter_id")]
        public string Shelter_id { get; set; }

        [BsonElement("navn")]
        public string Fuldenavn { get; set; }

        [BsonElement("t_nr")]
        public string Telefon_nr { get; set; }

        [BsonElement("dato_start")]
        public DateTime Start_Dato { get; set; }

        [BsonElement("dato_slut")]
        public DateTime Slut_Dato { get; set; }


    }
}
