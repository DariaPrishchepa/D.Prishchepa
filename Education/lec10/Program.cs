using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace lec10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 5;
            //string[] tmp = new string[n];
            //StreamWriter str = new StreamWriter(@"D:\Education\teat.txt");
            //for (int i = 0; i < n; i++)
            //{
            //    tmp[i] = Console.ReadLine();
            //    str.WriteLine(tmp[i]);
            //}
            //str.Close();
            //StreamReader strReader = new StreamReader(@"D:\Education\teat.txt");
            //string str1 = strReader.ReadLine();
            //while (str1 != null)
            //{
            //    Console.WriteLine(str1);
            //    str1 = strReader.ReadLine();
            //}
            //strReader.Close();

            /// <summary>
            /// HomeWork 10
            /// </summary>
            /// <returns></returns> 

            StreamReader xmlReader = new StreamReader(@"D:\Education\C_\flowCards.Card.xml");

            string strXML = xmlReader.ReadToEnd();
            xmlReader.Close();
            XDocument doc = XDocument.Parse(strXML);
            XElement contact = doc.Element("Card").Element("Contacts");
            XElement[] contacts = contact.Elements().ToArray();
            Console.WriteLine(contacts.Length);
            using (StreamWriter xmlWriter1 = new StreamWriter(@"D:\Education\C_\IsPromotional_True.txt"))
            using (StreamWriter xmlWriter2 = new StreamWriter(@"D:\Education\C_\IsPromotional_False.txt"))
            {
                for (int i = 0; i < contacts.Length; i++)
                {
                    try
                    {
                        if (contacts[i].Attribute("Description") == null)
                        {
                            if (bool.Parse(contacts[i].Attribute("IsPromotional").Value))
                            {
                                xmlWriter1.WriteLine(
                                    $"<{contacts[i].Name}>[IsPromotional: {contacts[i].Attribute("IsPromotional").Value}]");
                            }
                            else
                                xmlWriter2.WriteLine(
                                    $"<{contacts[i].Name}>[IsPromotional: {contacts[i].Attribute("IsPromotional").Value}]");

                        }
                        else
                        {
                            if (bool.Parse(contacts[i].Attribute("IsPromotional").Value))
                            {
                                xmlWriter1.WriteLine(
                                    $"<{contacts[i].Name}>[{contacts[i].Attribute("Description").Value}]-[IsPromotional: {contacts[i].Attribute("IsPromotional").Value}]");
                            }
                            else xmlWriter2.WriteLine(
                                    $"<{contacts[i].Name}>[{contacts[i].Attribute("Description").Value}]-[IsPromotional: {contacts[i].Attribute("IsPromotional").Value}]");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка: {ex}");
                    }
                    
 
                }
            }
        }

    }
}


