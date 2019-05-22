using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Data;

namespace Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "装备信息.xls";

            string connectionString= "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";


            OleDbConnection connection =new OleDbConnection(connectionString);

            connection.Open();

            string sql = "select * from [Sheet1$]";

            OleDbDataAdapter adapter = new OleDbDataAdapter(sql, connection);

            DataSet dataSet = new DataSet();

            adapter.Fill(dataSet);

            connection.Close();

            DataTableCollection tableCollection = dataSet.Tables;

            DataTable table = tableCollection[0];

            DataRowCollection rowCollection = table.Rows;

            foreach (DataRow row in rowCollection)
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(row[i] + " ");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
