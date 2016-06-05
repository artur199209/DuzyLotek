using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuzyLotek
{
	public class FileReader
	{
		public static void prepareParametersAndInsert(string date, string[] numbers)
		{
			string sql = "insert into wyniki values (@data, @liczba1,@liczba2,@liczba3,@liczba4,@liczba5,@liczba6);";
			SqlCommand command = new SqlCommand(sql, DatabaseConnect.conn);
			command.Parameters.AddWithValue("@data", date);
			command.Parameters.AddWithValue("@liczba1", numbers[0]);
			command.Parameters.AddWithValue("@liczba2", numbers[1]);
			command.Parameters.AddWithValue("@liczba3", numbers[2]);
			command.Parameters.AddWithValue("@liczba4", numbers[3]);
			command.Parameters.AddWithValue("@liczba5", numbers[4]);
			command.Parameters.AddWithValue("@liczba6", numbers[5]);
			command.ExecuteNonQuery();
		}

		public static void insertDataToDB(List<String> listofscores)
		{
			foreach (string line in listofscores)
			{
				string[] elements = line.Split(' ');
				string[] numbers = elements[2].Split(',');
				string date = elements[1];
				string date2 = "";

				for (int i = 6; i < 10; i++)
				{
					date2 = date2 + date[i];
				}
				date2 = date2 + "-" + date[3] + date[4] + "-" + date[0] + date[1];

				prepareParametersAndInsert(date2, numbers);
			}
		}
	}
}