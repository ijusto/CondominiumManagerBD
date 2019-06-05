using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    [Serializable()]
    class Condominium_Manager : Person
    {
        private string _Password;

        public Condominium_Manager(String tax_Number, String name, String mobile, String email, string password)
           : base(tax_Number, name, mobile, email)
        {
            _Password = password;
        }
        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
}
