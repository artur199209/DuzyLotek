using System;
using System.Windows.Forms;

namespace DuzyLotek
{
    public partial class Form1:Form, ILotto
    {
        public void UpdateLabel()
        {
            try
            {
                ControlExtensions.InvokeIfRequired(lastScoresLabel, delegate {
                    lastScoresLabel.Text = "Ostatnie wyniki:";
                    lastScoresLabel.Visible = true;
                    lastScoresDate.Text = LastScores.Date2;
                    lastScores.Text = LastScores.Scores;
                });
            }
            catch (Exception ex) { }
       }
    }
}