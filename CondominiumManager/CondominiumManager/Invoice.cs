using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    class Invoice
    {
        private String _Tax_Number;
        private String _Date;
        private String _Amount;
        private String _Description;
        private String _Entity_Name;

        public Invoice(String entity_Name, String tax_Number, String date, String amount, String desc)
        {
            _Entity_Name = entity_Name;
            _Tax_Number = tax_Number;
            _Date = date;
            _Amount = amount;
            _Description = desc;
        }

        public String Entity_Name
        {
            get { return _Entity_Name; }
            set { _Entity_Name = value; }
        }

        public String Tax_Number
        {
            get { return _Tax_Number; }
            set { _Tax_Number = value; }
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
