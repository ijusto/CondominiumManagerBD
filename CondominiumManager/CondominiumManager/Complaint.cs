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
        private string _date;
        private string _desc;

        public Complaint(int id, string date, string desc, int index)
        {
            _id = id;
            _date = date;
            _desc = desc;
            _index = index;
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

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }
    }
}
