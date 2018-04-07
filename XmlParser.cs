using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Collections;

namespace IncNow_Ofac
{
    public static class XmlParser
    {
        // " https:www.treasury.gov/ofac/downloads/sdn.xml" 
        public static ArrayList parseXML()
        {
            ArrayList xmlObjectArray = new ArrayList();      
            XmlDocument xml = new XmlDocument();
            xml.Load("https://www.treasury.gov/ofac/downloads/sdn.xml");
            XmlNode root = xml.DocumentElement;
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xml.NameTable);
            nsmgr.AddNamespace("bk", "http://tempuri.org/sdnList.xsd");

            XmlNodeList xnList = xml.SelectNodes("//bk:sdnEntry", nsmgr);
    
            XmlNode node = xml.SelectSingleNode("descendant::bk:sdnEntry/bk:programList", nsmgr);

            string firstName = "";
            string lastName = "";
            string company = "";
            string country = "";


            foreach (XmlNode xn in xnList)
           {             
                if(xn["sdnType"].InnerText == "Entity" )
                {
                    company = xn["lastName"].InnerText;
                    lastName = "";
                }else{
                    lastName = xn["lastName"].InnerText;
                    company = "";
                }
               // string uid = xn["uid"].InnerText;
                if (xn["firstName"] == null){
                    firstName = "";   
                } else {
                     firstName = xn["firstName"].InnerText;
                }

                country = xn.SelectSingleNode("bk:programList", nsmgr).InnerText;
                XmlObject incNowXml = new XmlObject(company, lastName, firstName, country);               
                xmlObjectArray.Add(incNowXml);
            }
            // Console.WriteLine("List Count = " + xnList.Count);

            //Console.WriteLine("Array Count = " + xmlObjectArray.Count);

            //for (int i = 0; i < xmlObjectArray.Count; i++)
            //{
            //    Console.WriteLine(xmlObjectArray[i].ToString());

            //}

            return xmlObjectArray;
        }



    }
}