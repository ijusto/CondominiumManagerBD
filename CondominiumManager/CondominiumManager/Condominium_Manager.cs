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

        public String Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }
}
