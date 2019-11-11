using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

namespace XmlToJson.Converters
{
    public static class XmlConverter
    {
        private const string jsonPath = @"C:\katas\XmlToJson\XmlToJson\Json\";
        private const string xmlPath = @"C:\katas\XmlToJson\XmlToJson\Xml\";

        public static void Process()
        {
            try
            {
                var sources = new List<string>()
                {
                    "6262109572_CareOf_True_UT.json",
                    "6262109573_CareOf_True_UT.json",
                    "6262109574_CareOf_False_UT.json"
                };

                foreach (var document in sources)
                {
                    var xmlDocument = XmlDocumentCreator(document);
                    SaveXmlDocument(xmlDocument, document);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private static XmlDocument XmlDocumentCreator(string document)
        {
            var path = Path.Combine(jsonPath, document);
            var jsonContent = File.ReadAllText(path);

            var node = JsonConvert.DeserializeXNode(jsonContent, "Root");

            return new XmlDocument {InnerXml = node.ToString()};
        }

        private static void SaveXmlDocument(XmlDocument xmlDocument, string document)
        {
            var documentName = document.Split('.')[0];

            xmlDocument.Save($"{xmlPath}{documentName}.xml");
        }
    }
}
