using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Service_Invoice : Invoice
    {
        private int _ID;
        private String _Address;
        private int _Index;
       

        public Service_Invoice() : base() { }

        public Service_Invoice(int id, String entity_Name, String tax_Number, String date, String amount, String desc, String address, int index )
            : base(entity_Name, tax_Number, date, amount, desc)
        {
            _ID = id;
            _Address = address;
            _Index = index;
           
        }

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

    }
}
