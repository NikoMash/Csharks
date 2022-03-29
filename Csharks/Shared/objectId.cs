using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharks.Shared
{
    public class objectId
    {
        public char _id;

        public objectId()
        {

        }

        public objectId(char i)
        {
            _id = i;
        }

        public char Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }

}
