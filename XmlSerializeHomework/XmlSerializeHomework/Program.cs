using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Xml.Serialization;
using Xml2CSharp;

namespace XmlSerializeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string Valuta = client.GetStringAsync(@"https://www.cbar.az/currencies/08.04.2022.xml").Result;
            StringReader stringReader = new StringReader(Valuta);
            XmlSerializer xml = new XmlSerializer(typeof(ValCurs));

            ValCurs valCurs = (ValCurs)xml.Deserialize(stringReader);

            string CurrencyAsJson = JsonConvert.SerializeObject(valCurs);
            StreamWriter sw = new StreamWriter(@"C:\Users\Asus\source\repos\XmlSerializeHomework\XmlSerializeHomework\Files\xml.json");
            sw.Write(CurrencyAsJson);
            sw.Close();

            Console.WriteLine("Zamani qeyd edin: ");
            string date = Console.ReadLine();

            if (date == valCurs.Date)
            {
                StreamWriter sw1 = new StreamWriter(@"C:\Users\Asus\source\repos\XmlSerializeHomework\XmlSerializeHomework\Files\Date.json");
                sw1.Write(CurrencyAsJson);
            }

        }
    }
}