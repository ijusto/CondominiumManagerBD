using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Quota_Invoice : Invoice
    {
        private String _Address;
        private int _index;

        public Quota_Invoice() : base() { }

        public Quota_Invoice(String entity_Name, String tax_Number, String date, String amount, String desc, String address, int index)
            : base(entity_Name, tax_Number, date, amount, desc)
        {
            _Address = address;
            _index = index;
        }

        public String Address
        {
            get{ return _Address; }
            set { _Address = value; }
        }

        public int index
        {
            get { return _index; }
            set { _index = value; }
        }
    }
}
