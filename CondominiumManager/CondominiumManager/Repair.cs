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
        private int _index;

        public Repair() : base() { }

        public Repair(String name, String date, String desc, String condo, String damage, int index, int id)
            : base(name, date, desc, condo, id)
        {
            _index = index;
            _Damaged = damage;
        }

        public String Damaged
        {
            get { return _Damaged; }
            set { _Damaged = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
    }
}
