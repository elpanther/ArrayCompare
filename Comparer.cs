using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;




namespace IncNow_Ofac
{

    public class Comparer 
    {
       
         public static void compareArrays(string csvUrl){

            ArrayList csvList = new ArrayList(CsvParser.parseCSV(csvUrl));
            ArrayList xmlList = new ArrayList(XmlParser.parseXML());
            bool iExist = false;

            for (int i = 1; i < csvList.Count; i++)
            {

                for (int j = 0; j < xmlList.Count; j++)
                {
                    if (Equals(csvList[i],xmlList[i]))
                    {
                        iExist = true;
                        Console.WriteLine("csvList element: " + csvList[i] + "|" + xmlList[j]);
                    }
                }

                if (iExist == false)
                {
                    Console.WriteLine("csvList element: " + csvList[i] + "notfound" );
                }
                iExist = false;
            }

            //for (int i = 1; i < csvList.Count; i++)
            //{

            //    Console.WriteLine(csvList[i]);
            //} Console.WriteLine(csvList.Count);


            //return list1.parseCSV(csvUrl).ToString();
        }

    } 

} 
