using System;
using XmlToJson.Converters;

namespace XmlToJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option:\n\n1. JSON To XML\n2. JSON To csv");
            var option = Console.ReadKey();

            if (option.KeyChar == '1')
            {
                XmlConverter.Process();
                Console.WriteLine("\nConverting JSON To XML...\n");
            }

            if (option.KeyChar != '2') return;
            var file = JsonReader.Process();

            Console.WriteLine("\nConverting Bookings JSON To CSV...\n" + file);

            Console.ReadKey();
        }
    }
}
