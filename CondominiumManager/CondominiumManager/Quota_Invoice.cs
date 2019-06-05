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

        public Quota_Invoice(String entity_Name, String tax_Number, String date, String amount, String desc, String address)
            : base(entity_Name, tax_Number, date, amount, desc)
        {
            _Address = address;
        }

        public String Address
        {
            get{ return _Address; }
            set { _Address = value; }
        }
    }
}
