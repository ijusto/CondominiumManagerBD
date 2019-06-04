using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Event
    {
        private String _ID;
        private String _Date;
        private String _Name;
        private String _Description;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public String Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

    }
}
