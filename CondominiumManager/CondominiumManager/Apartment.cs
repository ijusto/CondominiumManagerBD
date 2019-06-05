using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    public class Apartment
    {
        private String _Address;
        private String _Refer;
        private String _Permil;
        private String _ReadGas;
        private String _ReadWater;
        private String _ReadLight;
        private int _Index;
        private Tenant _owner;

        public Apartment()
        {
        }

        public Apartment(String address, String refer, String permil, String readGas, String readWater, String readLight, int index, Tenant owner)
        {
            _Address = address;
            _Refer = refer;
            _Permil = permil;
            _ReadGas = readGas;
            _ReadWater = readWater;
            _ReadLight = readLight;
            _Index = index;
            _owner = owner;
        }

        public String Address
        {
            get{ return _Address; }
            set { _Address = value; }
        }
        public String Refer
        {
            get { return _Refer; }
            set { _Refer = value; }
        }
        public String Permil
        {
            get { return _Permil; }
            set { _Permil = value; }
        }
        public String ReadGas
        {
            get { return _ReadGas; }
            set { _ReadGas = value; }
        }
        public String ReadWater
        {
            get { return _ReadWater; }
            set { _ReadWater = value; }
        }
        public String ReadLight
        {
            get { return _ReadLight; }
            set { _ReadLight = value; }
        }
        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }
        public Tenant owner
        {
            get { return _owner;}
            set { _owner = value; }
        }
    }
}
