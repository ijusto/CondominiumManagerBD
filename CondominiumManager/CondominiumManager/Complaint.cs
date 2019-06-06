using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    [Serializable()]
    public class Complaint
    {
        private int _index;
        private int _id;
        private String _date;
        private String _desc;
        private String _tname;
        private String _Address;

        public Complaint() { }

        public Complaint(int id, String date, String desc, String tname, int index)
        {
            _id = id;
            _date = date;
            _desc = desc;
            _index = index;
            _tname = tname;
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public String Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public String Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        public String Tname
        {
            get { return _tname; }
            set { _tname = value; }
        }

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}
