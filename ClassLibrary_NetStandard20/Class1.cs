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
            dataSet.ReadXml(AppDomain.CurrentDomain.BaseDirectory + @"northwind.xml");

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
