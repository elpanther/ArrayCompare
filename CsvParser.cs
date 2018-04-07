using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


//Mac -  @"/Users/jeff/Desktop/incNow/PossibleSdnList-Updated.csv"
//Windows- C:\Users\Owner\Desktop\inknow\PossibleSdnList-Updated.csv
namespace IncNow_Ofac
{


    public static class CsvParser
    {
        public static ArrayList parseCSV(string csvUrl) {

            ArrayList csvObjectArray = new ArrayList();
            //string response = "";

            using (TextFieldParser parser = new TextFieldParser(csvUrl))
            {                


                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    CsvObject incNowCSV = new CsvObject(fields[0].Trim(),fields[1].Trim(),fields[2].Trim(),fields[3].Trim());
                    csvObjectArray.Add(incNowCSV);

                }

                //Console.WriteLine(csvObjectArray.Count);



               
               // response = csvObjectArray.ToString();
                //for (int i = 1; i < csvObjectArray.Count; i++)
                //{



                //    Console.WriteLine(i + "--" + csvObjectArray[i]);
                //  // response += csvObjectArray[i].ToString().ToLower() + "|";
                //}
            }


            return csvObjectArray;

           


        } 


    }
}
