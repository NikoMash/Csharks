using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharks.Shared
{
    [TypeConverter(typeof(Geometry))]

    public class Geometry
    {
        public string type;
        public double[][] coordinates;

        public Geometry()
        {

        }

        public Geometry(string t, double[][] c)
        {
            type = t;
            coordinates = c;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double[][] Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }
    }
   

}
