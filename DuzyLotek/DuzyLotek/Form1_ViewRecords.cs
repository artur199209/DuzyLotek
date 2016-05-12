using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DuzyLotek
{
	public partial class Form1 : Form, ILotto
	{
		public int viewRecordsFromDatabase()
		{
			try
			{
				ControlExtensions.InvokeIfRequired(DataGridView, delegate
				{
					string sqlsearch = "select * from wyniki where (data >= @a1) and (data <= @a2);";
					DataGridView.Rows.Clear();
					if (DatabaseConnect.conn.State == ConnectionState.Open)
					{
						SqlCommand commandsearch = new SqlCommand(sqlsearch, DatabaseConnect.conn);
						commandsearch.Parameters.AddWithValue("@a1", sinceDate.Value.ToShortDateString());
						commandsearch.Parameters.AddWithValue("@a2", toDate.Value.ToShortDateString());
						SqlDataReader sqlread = commandsearch.ExecuteReader();
						progressBar1.Visible = true;
						progressBar1.Minimum = 1;
						progressBar1.Maximum = sqlread.FieldCount;
						progressBar1.Step = 1;
						progressBar1.Value = 1;

						while (sqlread.Read())
						{
							DataGridView.Rows.Add(sqlread[0], sqlread[1], sqlread[2], sqlread[3], sqlread[4], sqlread[5], sqlread[6]);
							progressBar1.PerformStep();
						}
						sqlread.Close();
						progressBar1.Visible = false;
					}
					else
					{
						MessageBox.Show("Brak połączenia z bazą danych!");
					}
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return 1;
		}

		public async void ViewRecordsFromDatabaseAsync()
		{
			var result = await Task.Run(() => viewRecordsFromDatabase());
		}
	}
}