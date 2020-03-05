using System;
using System.IO;
using System.Xml;
using Voxel.Billback.Cron.Proxies.Booking;

namespace XmlToJson.Converters
{
    public static class JsonReader
    {
        private const string jsonPath = @"D:\\Users\\xgarcia\\Repos\\XmlJsonConverter\\XmlToJson\\Json";
        private const string csvPath = @"D:\\Users\\xgarcia\\Repos\\XmlJsonConverter\\XmlToJson\\csv";

        public static string Process()
        {
            try
            {
                var document = @"D:\\Users\\xgarcia\\Repos\\XmlJsonConverter\\XmlToJson\\Json\\bookings.json";

                 var documentPath = CSVDocumentCreator(document);

                 return documentPath;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private static string CSVDocumentCreator(string document)
        {
            var path = Path.Combine(jsonPath, document);
            var jsonContent = File.ReadAllText(path);
            var tempPath = Path.GetTempPath();

            
            var listWriter = new ListCsvWriter(";");

            var bookingDetails = FromJson(jsonContent);
            var outPutFile = tempPath + "bookingsReport_total_" + bookingDetails.Result.Count + ".csv";
            listWriter.Write(bookingDetails, outPutFile, false);

            return outPutFile;
        }

        public static BookingDetails FromJson(string data)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BookingDetails>(data);
        }

      
    }
}
