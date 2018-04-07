using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Web;
using System.Xml.Serialization;
using Microsoft.VisualBasic.FileIO;


namespace IncNow_Ofac
{
    class Program


    {
        public static void Main(string[] args)
        {

           string csvUrl = "/Users/jeff/Desktop/incNow/PossibleSdnList-Updated.csv";

              Comparer.compareArrays(csvUrl);

           // CsvParser.parseCSV(csvUrl);


            // Console.WriteLine(CsvParser.parseCSV("/Users/jeff/Desktop/incNow/PossibleSdnList-Updated.csv"));


          // XmlParser.parseXML();



          



        }
    }
}
