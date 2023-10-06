using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw_m8
{
    internal class PracticeXML
    {

        private Random Random;
        
        public PracticeXML()
        {
            Random = new Random();
            CreateDocumentXML(AutoFillingXML());
            Console.WriteLine("Document created");
            Console.ReadKey();
        }

        private void CreateDocumentXML(PersonForXML person)
        {
            XElement myPerson = new XElement("Person");
            XElement myAddres = new XElement("Address");
            XElement myStreet = new XElement("Street");
            XElement myHouseNumber = new XElement("HouseNumber");
            XElement myFlatNumber = new XElement("FlatNumber");
            XElement myPhones = new XElement("Phones");
            XElement myMobilePhone = new XElement("MobilePhone");
            XElement myFlatPhone = new XElement("FlatPhone");

            XAttribute xFullName = new XAttribute("name", person.fullName);
            XAttribute xStreet = new XAttribute("street", person.street);
            XAttribute xHouseNumber = new XAttribute("house", person.houseNumber);
            XAttribute xFlatNumber = new XAttribute("flat", person.flatNumber);
            XAttribute xMobilePhone = new XAttribute("mobilePhone", person.mobilePhone);
            XAttribute xFlatPhone = new XAttribute("flatPhone", person.flatPhone);

            myPerson.Add(myAddres, myPhones, xFullName);
            myAddres.Add(myStreet, myHouseNumber, myFlatNumber);
            myPhones.Add(myMobilePhone, myFlatPhone);

            myStreet.Add(xStreet);
            myHouseNumber.Add(xHouseNumber);
            myFlatNumber.Add(xFlatNumber);
            myMobilePhone.Add(xMobilePhone);
            myFlatPhone.Add(xFlatPhone);

            myPerson.Save("_myPerson.xml");

        }

        private PersonForXML AutoFillingXML()
        {
            string[] names = {"Mama Roma", "Papa Johns", "Nemo Undersea", "Santa Claus"};
            string[] street = {"Trafalgar sqr.", "Baker st.", "Crown Passage", "Ryder st."};

            PersonForXML person =  new PersonForXML (names[Random.Next(4)],
                                                     street[Random.Next(4)],
                                                     Random.Next(101),
                                                     Random.Next(101),
                                                     Random.Next(1000000, 9999999).ToString("###-##-##"),
                                                     Random.Next(1000000, 9999999).ToString("###-##-##"));

            return person;

        }
    }
}
