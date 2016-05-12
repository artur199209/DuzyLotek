﻿using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DuzyLotek
{
    public class InsertFromWeb
    {
        private static int InsertDataFromWeb()
        {
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                string sqldelete = "delete from wyniki;";
				
				if(DatabaseConnect.conn.State == ConnectionState.Open)
				{
					SqlCommand commanddelete = new SqlCommand(sqldelete, DatabaseConnect.conn);
					commanddelete.ExecuteNonQuery();
					WebRequest webrequest = WebRequest.Create("http://www.mbnet.com.pl/dl.txt");
					webrequest.Credentials = CredentialCache.DefaultCredentials;
					HttpWebResponse httpwebresponse = (HttpWebResponse)webrequest.GetResponse();
					Stream stream = httpwebresponse.GetResponseStream();
					StreamReader streamreader = new StreamReader(stream);
					string line = "";

					while ((line = streamreader.ReadLine()) != null)
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
					MessageBox.Show("Dane z internetu zostały wprowadzone.");
				}
				else
				{
					MessageBox.Show("Brak połaczenia z bazą danych!");
				}
               
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