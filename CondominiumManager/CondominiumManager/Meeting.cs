using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    public class Meeting : Event
    {
        private string _location;
        private int _index;

        public Meeting() : base() { }

        public Meeting(String name, String date, String desc, String condo, String location, int id, int index)
            : base(name, date, desc, condo, id)
        {
            _index = index;
            _location = location;
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
    }
}
