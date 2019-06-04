using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Meeting : Event
    {
        private String _Place;

        public String Place
        {
            get { return _Place; }
            set { _Place = value; }
        }
    }
}
