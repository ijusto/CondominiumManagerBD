using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Repair : Event
    {
        private String _Damaged;

        public String Damaged
        {
            get { return _Damaged; }
            set { _Damaged = value; }
        }
    }
}
