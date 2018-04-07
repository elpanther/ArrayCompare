using System;
namespace IncNow_Ofac
{
    public class XmlObject
    {
        String company;
        String firstName;
        String lastName;
        String country;

        public XmlObject()
        {
           
        }

        public XmlObject(String xmlCompany, String xmlFirstName, String xmlLastName, String xmlCountry)
        {
            this.company = xmlCompany;
            this.firstName = xmlFirstName;
            this.lastName = xmlLastName;
            this.country = xmlCountry;

        }

        public string Company { get => company; set => company = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Country { get => country; set => country = value; }


        public override string ToString()
        {
            return $"Company:{company}, FirstName:{firstName}, LastName:{lastName}, Country:{country}";
        }



    }

}
