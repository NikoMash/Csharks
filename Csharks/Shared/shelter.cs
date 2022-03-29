using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharks.Shared;
using MongoDB.Bson;

namespace Csharks.Shared
{
    public class Shelter
    {
        public ObjectId Id { get; set; }
        public geometry? Geometry { get; set; }
        public Properties? Properties { get; set; }
    }
}
