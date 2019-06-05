using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondominiumManager
{
    public class Meeting
    {
        public int id;
        public string name;
        public string description;
        public string date;
        public string location;
        public string condo;

        public Meeting(int id, string name, string description, string date, string location, string condo)
        {
            id = this.id;
            name = this.name;
            description = this.description;
            date = this.date;
            location = this.location;
            condo = this.condo;
        }

        public int ID{
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string Condo
        {
            get { return condo; }
            set { condo = value; }
        }
    }
}
