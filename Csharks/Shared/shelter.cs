using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharks.Shared;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Csharks.Shared
{
   
    public class Shelter
    {
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public Properties? Properties { get; set; }
        public Shelter()
        {
            Properties = new Properties();
        }


      


    }


}
