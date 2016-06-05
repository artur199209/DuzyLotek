using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System;
using System.Collections.Generic;

namespace DuzyLotek
{
    public class InsertFromFile:FileReader
    {
		public static void readFromFileAndInsert(List<String> listofscores)
		{
			FileReader.insertDataToDB(listofscores);
			MessageBox.Show("Dane z pliku zostały wprowadzone.");
		}

        public static int insertDataFromFile()
        {
			try
			{
				List<string> listofscores = returnAllLines();
				string sqldelete = "delete from wyniki;";
				SqlCommand commanddelete = new SqlCommand(sqldelete, DatabaseConnect.conn);
				commanddelete.ExecuteNonQuery();

				readFromFileAndInsert(listofscores);
			}
			catch (Exception ex) {
				MessageBox.Show("Błąd" + ex.Message);
			}
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