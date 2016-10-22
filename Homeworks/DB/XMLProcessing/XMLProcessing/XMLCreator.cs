using System;
using System.IO;
using System.Xml.Linq;

namespace XMLProcessing
{
    public class XMLCreator
    {
        public static void CreatePersonXML()
        {
            StreamReader reader = new StreamReader("../../commands.txt");
            string[] commands = new string[3];
            for (int i = 0; i <= 2; i++)
            {
                commands[i] = reader.ReadLine();
            }

            var persons = new XElement("person",
                new XElement("name", commands[0]),
                new XElement("adress", commands[1]),
                new XElement("phone", commands[2])
            );

            persons.Save("person.xml");

            var currentDir = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDir);


        }
    }
}