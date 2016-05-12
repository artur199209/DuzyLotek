using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuzyLotek
{
	interface ILotto
	{
		string randomScores(int a, int b);
		void UpdateLabel();
		int viewRecordsFromDatabase();
	}
}
