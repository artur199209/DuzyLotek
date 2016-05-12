using System.Net;
using System.IO;

namespace DuzyLotek
{
    class Update
    {
        public string Check()
        {
            string wersja = "1.02";
            if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
            {
                WebRequest rq = WebRequest.Create("http://serwerprogramowanie.cba.pl/version.txt");
                rq.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse rp = (HttpWebResponse)rq.GetResponse();
                Stream st = rp.GetResponseStream();
                StreamReader sr = new StreamReader(st);
                string odpowiedz = sr.ReadToEnd();
                if (wersja != odpowiedz)
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
