﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    public class Event
    {
        private String _Date;
        private String _Name;
        private String _Description;
        public String _Condo;

        public Event() { }

        public Event(String name, String date, String desc, String condo)
        {
            _Name = name;
            _Date = date;
            _Description = desc;
            _Condo = condo;
        }
        

        public String Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public string Condo
        {
            get { return _Condo; }
            set { _Condo = value; }
        }

    }
}
