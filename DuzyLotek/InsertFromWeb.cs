using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace DuzyLotek
{
    public class InsertFromWeb:FileReader
    {
		static List<String> listOfLines = new List<string>();

		public static List<String> readFromFileToList()
		{
			listOfLines.Clear();
			WebRequest webrequest = WebRequest.Create("http://www.mbnet.com.pl/dl.txt");
			webrequest.Credentials = CredentialCache.DefaultCredentials;
			HttpWebResponse httpwebresponse = (HttpWebResponse)webrequest.GetResponse();
			Stream stream = httpwebresponse.GetResponseStream();
			StreamReader streamreader = new StreamReader(stream);
			string line = "";
								 
			while ((line = streamreader.ReadLine()) != null)
			{
				listOfLines.Add(line);
			}
			return listOfLines;
		}

        public static int InsertDataFromWeb()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                string sqldelete = "delete from wyniki;";

				try
				{
					if (DatabaseConnect.conn.State == ConnectionState.Open)
					{
						SqlCommand commanddelete = new SqlCommand(sqldelete, DatabaseConnect.conn);
						commanddelete.ExecuteNonQuery();
						readFromFileToList();
						FileReader.insertDataToDB(listOfLines);
						MessageBox.Show("Dane z internetu zostały wprowadzone.");
					}
					else
					{
						MessageBox.Show("Brak połaczenia z bazą danych!");
					}
				}
				catch (Exception ex) { }
               
                return 1;
            }
            else
            {
                MessageBox.Show("Brak połączenia z internetem.");
                return -1;
            }
        }

        public async static void insertDataToDatabaseFromWebAsync()
        {
            var result = await Task.Factory.StartNew(() => InsertDataFromWeb());
        }
    }
}