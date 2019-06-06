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
        private String _Mobile;
        private String _Email;

        public Person() { }

        public Person(String tax_Number, String name, String mobile, String email)
        {
            _Tax_Number = tax_Number;
            _Name = name;
            _Mobile = mobile;
            _Email = email;
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

        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
       
    }
}
