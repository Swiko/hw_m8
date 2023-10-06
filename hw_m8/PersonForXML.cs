using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_m8
{
    internal class PersonForXML
    {

        public string fullName;
        public string street;
        public int houseNumber;
        public int flatNumber;
        public string mobilePhone;
        public string flatPhone;

        public PersonForXML (string fullName, string street, int houseNumber, int flatNumber, string mobilePhone, string flatPhone)
        {
            this.fullName = fullName;
            this.street = street;
            this.houseNumber = houseNumber;
            this.flatNumber = flatNumber;
            this.mobilePhone = mobilePhone;
            this.flatPhone = flatPhone;
        }

        public string printPerson ()
        {
            return ($"{this.fullName}, {this.street}, {this.houseNumber}, {this.flatNumber}, {this.mobilePhone}, {this.flatPhone}");
        }

    }
}
