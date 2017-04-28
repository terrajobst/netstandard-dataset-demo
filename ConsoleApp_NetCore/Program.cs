using System;
using System.Data;

namespace ConsoleApp_NetCore
{
    class Program
    {
        static void Main(string[] args)
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

            Console.Write(result);
        }
    }
}