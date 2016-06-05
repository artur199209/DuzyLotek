using System;
using System.Reactive.Linq;
using System.Windows.Forms;

namespace DuzyLotek
{
    public partial class Form1 : Form
    {
        DatabaseConnect cs = DatabaseConnect.getDbInstance();
        Update update = new Update();

        public Form1()
        {
           InitializeComponent();
           progressBar1.Visible = false;
           cs.GetDBConnection();
           System.Threading.Timer timer = new System.Threading.Timer(LastScores.TimerCallback, null, 0, 1000);
           var refresh = Observable.Interval(TimeSpan.FromSeconds(4));
           refresh.Subscribe(tick =>
           {
               UpdateLabel();
           });
        }

		public String returnTextFromlastScoresDate()
		{
			return lastScoresDate.Text;
		}

		public String returnTextFromlastScores()
		{
			return lastScores.Text;
		}

        private void drawScores_Click(object sender, EventArgs e)
        {
			MessageBox.Show(randomScores(49, 6));
        }

        private void loadFromWeb_Click(object sender, EventArgs e)
        {
            InsertFromWeb.insertDataToDatabaseFromWebAsync();
        }

        private void loadFromFile_Click(object sender, EventArgs e)
        {
            InsertFromFile.insertToDatabaseFromFileAsync();
        }

        private void checkUpdatesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(update.Check());
        }

        private void viewDataFromDatabase_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            ViewRecordsFromDatabaseAsync();
        }

        private void sinceDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = sinceDate.Value;
            toDate.Value = d.AddYears(1);
            if (toDate.Value > DateTime.Now)
            {
                toDate.Value = DateTime.Now;
            }
        }
    }
}