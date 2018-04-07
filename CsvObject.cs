using System;
namespace IncNow_Ofac
{
    public class CsvObject
    {
        String company;
        String firstName;
        String lastName;
        String country;

        public CsvObject()
        {
           
        }
        public CsvObject(String csvCompany, String csvFirstName, String csvLastName, String csvCountry)
        {
            this.company = csvCompany;
            this.firstName = csvFirstName;
            this.lastName = csvLastName;
            this.country = csvCountry;
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
