using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Service_Invoice
    {
        private String _Invoice_ID;
        private String _Date;
        private String _Amount;
        private String _Description;

        public String Invoice_ID
        {
            get { return _Invoice_ID; }
            set { _Invoice_ID = value; }
        }

        public String Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public String Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }
    }
}
