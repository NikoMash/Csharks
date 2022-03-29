using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharks.Shared
{
    public class geometry
    {
        public string type;
        public double[][] coordinates;

        public geometry()
        {

        }

        public geometry(string t, double[][] c)
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
