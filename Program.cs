using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml.Serialization;

namespace xml_b3_index_report
{
    class Program
    {
        static void Main(string[] args)
        {
            var byteFile = System.IO.File.ReadAllBytes("sample.xml");

            using (var ms = new MemoryStream(byteFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Document2));
                var deserializedXml = (Document2)serializer.Deserialize(ms);

                var json = JsonConvert.SerializeObject(deserializedXml);
                Console.WriteLine(json);
            }
        }
    }
}
