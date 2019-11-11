using System;
using XmlToJson.Converters;

namespace XmlToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:\n\n1. JSON To XML\n");
            var option = Console.ReadKey();

            if (option.KeyChar != '2') return;

            XmlConverter.Process();
            Console.WriteLine("\nConverting JSON To XML...\n");
        }
    }
}
