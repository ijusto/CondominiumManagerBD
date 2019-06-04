using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Services_Provider
    {
        private String _Tax_Number;
        private String _Name;
        private int _Mobile;
        private String _Address;

        public String Tax_Number
        {
            get { return _Tax_Number; }
            set { _Tax_Number = value; }
        }

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public int Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

    }

    class Services_Provider_Type
    {
        private String _ID;
        private String _Description;

        public String ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
