using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharks.Shared;
using System.Security;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


[assembly: AllowPartiallyTrustedCallers()]
namespace Csharks.Shared
{
   
    public class Shelter
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public Geometry? Geometry { get; set; }
        public Properties? Properties { get; set; }
    }
}
