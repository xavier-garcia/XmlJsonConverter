using Voxel.Billback.Cron.Proxies.Booking;

namespace XmlToJson.Converters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    public class ListCsvWriter
    {
        private readonly string delimiter;

        public ListCsvWriter(string delimiter)
        {
            this.delimiter = delimiter;
        }

        public string Write(BookingDetails bookingDetails, bool includeHeader)
        {
            StringBuilder sb = new StringBuilder();
            Type type = typeof(BookingDetails);

            PropertyInfo[] properties = type.GetProperties();

            if (includeHeader)
            {
                sb.AppendLine(this.CreateCsvHeaderLine(properties));
            }

            foreach (var item in bookingDetails.Result)
            {
                sb.AppendLine(this.CreateCsvLine(item.Reservation_id, properties));
            }

            return sb.ToString();
        }

        public string Write(BookingDetails bookingDetails, string fileName, bool includeHeader)
        {
            string csv = this.Write(bookingDetails, includeHeader);
            this.WriteFile(fileName, csv);
            return csv;
        }

        public void Write(string fileName, byte[] content)
        {
            File.WriteAllBytes(fileName, content);
        }

        public void Delete(string tmpFileName)
        {
            File.Delete(tmpFileName);
        }

        #region "Helpers"

        private string CreateCsvHeaderLine(PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            foreach (var prop in properties)
            {
                string stringformatString = string.Empty;
                string value = prop.Name;

                var attribute = prop.GetCustomAttribute(typeof(DisplayAttribute));
                if (attribute != null)
                {
                    value = (attribute as DisplayAttribute).Name;
                }

                this.CreateCsvStringItem(propertyValues, value);
            }

            return this.CreateCsvLine(propertyValues);
        }

        private string CreateCsvLine(long? value, PropertyInfo[] properties)
        {
            List<string> propertyValues = new List<string>();

            foreach (var prop in properties)
            {
                string stringformatString = string.Empty;

                if (prop.PropertyType == typeof(string))
                {
                    this.CreateCsvStringItem(propertyValues, value);
                }
                else if (prop.PropertyType == typeof(string[]))
                {
                    this.CreateCsvStringArrayItem(propertyValues, value);
                }
                else if (prop.PropertyType == typeof(List<string>))
                {
                    this.CreateCsvStringListItem(propertyValues, value);
                }
                else
                {
                    this.CreateCsvItem(propertyValues, value);
                }
            }

            return this.CreateCsvLine(propertyValues);
        }

        private string CreateCsvLine(List<string> list)
        {
            return string.Join(this.delimiter, list);
        }

        private void CreateCsvItem(List<string> propertyValues, object value)
        {
            if (value != null)
            {
                propertyValues.Add(value.ToString());
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private void CreateCsvStringListItem(List<string> propertyValues, object value)
        {
            string formatString = "\"{0}\"";
            if (value != null)
            {
                value = this.CreateCsvLine((List<string>)value);
                propertyValues.Add(string.Format(formatString, this.ProcessStringEscapeSequence(value)));
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private void CreateCsvStringArrayItem(List<string> propertyValues, object value)
        {
            string formatString = "\"{0}\"";
            if (value != null)
            {
                value = this.CreateCsvLine(((string[])value).ToList());
                propertyValues.Add(string.Format(formatString, this.ProcessStringEscapeSequence(value)));
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private void CreateCsvStringItem(List<string> propertyValues, object value)
        {
            string formatString = "\"{0}\"";
            if (value != null)
            {
                propertyValues.Add(string.Format(formatString, this.ProcessStringEscapeSequence(value)));
            }
            else
            {
                propertyValues.Add(string.Empty);
            }
        }

        private string ProcessStringEscapeSequence(object value)
        {
            return value.ToString().Replace("\"", "\"\"");
        }

        private bool WriteFile(string fileName, string csv)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return false;
            }

            File.WriteAllText(fileName, csv);

            return true;
        }

        #endregion
    }
}

