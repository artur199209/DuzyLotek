using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System;
using System.Collections.Generic;

namespace DuzyLotek
{
    public class InsertFromFile
    {
        public static int insertDataFromFile()
        {
			try
			{
				List<string> lines = returnAllLines();

				string sqldelete = "delete from wyniki;";
				SqlCommand commanddelete = new SqlCommand(sqldelete, DatabaseConnect.conn);
				commanddelete.ExecuteNonQuery();

				foreach (string line in lines)
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

					string sql = "insert into wyniki values (@data, @liczba1,@liczba2,@liczba3,@liczba4,@liczba5,@liczba6);";
					SqlCommand command = new SqlCommand(sql, DatabaseConnect.conn);

					command.Parameters.AddWithValue("@data", date2);
					command.Parameters.AddWithValue("@liczba1", numbers[0]);
					command.Parameters.AddWithValue("@liczba2", numbers[1]);
					command.Parameters.AddWithValue("@liczba3", numbers[2]);
					command.Parameters.AddWithValue("@liczba4", numbers[3]);
					command.Parameters.AddWithValue("@liczba5", numbers[4]);
					command.Parameters.AddWithValue("@liczba6", numbers[5]);
					command.ExecuteNonQuery();
				}
				MessageBox.Show("Dane z pliku zostały wprowadzone.");
			}
			catch (Exception ex) { }			
            return 1;
        }
       
		public static List<string> returnAllLines()
		{
			List<String> lineList = new List<string>();
			try
			{
				var assembly = Assembly.GetExecutingAssembly();
				var resourceName = "DuzyLotek.dl.txt";

				using (Stream stream = assembly.GetManifestResourceStream(resourceName))
				using (StreamReader reader = new StreamReader(stream))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						lineList.Add(line);
					}
				}
			}
			catch (Exception ex) { }
			return lineList;
		}

        public async static void insertToDatabaseFromFileAsync()
        {
            var result = await Task.Factory.StartNew(() => insertDataFromFile());
        }
    }
}