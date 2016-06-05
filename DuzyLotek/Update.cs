using System.Net;
using System.IO;

namespace DuzyLotek
{
    public class Update
    {
		public string getVersion()
		{
			WebRequest rq = WebRequest.Create("http://serwerprogramowanie.cba.pl/version.txt");
			rq.Credentials = CredentialCache.DefaultCredentials;
			HttpWebResponse rp = (HttpWebResponse)rq.GetResponse();
			Stream st = rp.GetResponseStream();
			StreamReader sr = new StreamReader(st);
			string version = sr.ReadToEnd();
			return version;
		}

        public string Check()
        {
            string versionapp = "1.02";
           
			if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
				string ver = getVersion();
				if (versionapp != ver)
                {
                    return "Nowsza wersja tego oprogramowania jest już dostępna.";
                }
                else
                {
                    return "Masz najnowszą wersję oprogramowania.";
                }
            }
            else
            {
                return "Brak połączenia z internetem.";
            }
        }
    }
}
