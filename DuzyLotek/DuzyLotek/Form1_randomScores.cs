using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuzyLotek
{
   public partial class Form1:Form, ILotto
    {
       public string randomScores(int n, int k)
       {
           Random rand = new Random();
           string sc = "";
           int[] numbers = new int[n];
           for (int i = 0; i < n; i++)
               numbers[i] = i + 1;

           for (int i = 0; i < k; i++)
           {
               int r = rand.Next(n);
               sc = sc + numbers[r] + " ";
               numbers[r] = numbers[n - 1];
               n--;
           }
           return sc;
       }
    }
}
