using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    [Serializable()]
    public class Person
    {
        private String _Tax_Number;
        private String _Name;
        private int _Mobile;
        private String _Email;

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

        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public override String ToString()
        {
            return _Name + "   " + Tax_Number;
        }

        public Person() : base()
        {
        }

        public Person(String Name, String LastName, String FirstName) : base()
        {
            this.Name = LastName + ", " + FirstName;
            this.Name = Name;
        }

        public Person(String CompanyName) : base()
        {
            this._Name = Name;
        }
    }
}
