using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    [Serializable()]
    public class Tenant : Person
    {
        private int _index;

        public Tenant() : base() { }

        public Tenant(String tax_Number, String name, String mobile, String email, int index)
           : base(tax_Number, name, mobile, email)
        { 
            _index = index;
        }

        public int Index{
            get { return _index; }
            set { _index = value; }
        }
    }
}
