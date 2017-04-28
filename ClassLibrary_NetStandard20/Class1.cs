using ICSharpCode.SharpZipLib.Zip;
using System;
using System.Data;

namespace ClassLibrary_NetStandard20
{
    public class Class1
    {
        public static string GetData()
        {
            var result = "";
            var dataSet = new DataSet();

            using (var zipFile = new ZipFile(AppDomain.CurrentDomain.BaseDirectory + @"northwind.zip"))
            {
                var entry = zipFile.GetEntry("northwind.xml");
                using (var xmlStream = zipFile.GetInputStream(entry))
                    dataSet.ReadXml(xmlStream);
            }

            var customerTable = dataSet.Tables["Customers"];

            foreach (DataRow row in customerTable.Rows)
            {
                var customerId = Convert.ToString(row["CustomerID"]);
                var contactName = Convert.ToString(row["ContactName"]);
                result += $"{customerId}: {contactName}\r\n";
            }

            return result;
        }
    }
}
