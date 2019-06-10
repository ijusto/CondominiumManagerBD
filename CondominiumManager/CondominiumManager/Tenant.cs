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
        private List<String> _fracao;

        public Tenant() : base() { }

        public Tenant(String tax_Number, String name, String mobile, String email, int index, List<String> fracao)
           : base(tax_Number, name, mobile, email)
        { 
            _index = index;
            _fracao = fracao;
        }

        public int Index{
            get { return _index; }
            set { _index = value; }
        }

        public List<String> fracao
        {
            get { return _fracao; }
            set { _fracao = value; }
        }

        public override bool Equals(object obj)
        {
            var objt = obj as Tenant;

            if (objt == null)
            {
                return false;
            }

            return this.Tax_Number.Equals(objt.Tax_Number);
        }

    }
}
