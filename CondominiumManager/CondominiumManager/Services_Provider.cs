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
        private String _Mobile;
        private String _Address;
        private String _Type;
        private int _Index;

        public Services_Provider(String tax_Number, String name, String mobile, String address, String type, int index)
        {
            _Tax_Number= tax_Number;
            _Name = name;
            _Mobile = mobile;
            _Address = address;
            _Type = type;
            _Index = index;
        }
        
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

        public String Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public String Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

    }
}
