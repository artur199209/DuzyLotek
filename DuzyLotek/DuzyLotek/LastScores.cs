﻿using System;
using HtmlAgilityPack;
using System.Net;
using System.Threading;

namespace DuzyLotek
{
    public class LastScores
    {
        private static string date2 = "31.10.2010";
        private static string scores = "";

        public static string Scores
        {
            get { return LastScores.scores; }
            set { LastScores.scores = value; }
        }

        public static string Date2
        {
            get { return LastScores.date2; }
            set { LastScores.date2 = value; }
        }

        public static void TimerCallback(Object o)
        {
            Thread myThread = new Thread(() =>
            {
                WebClient webclient = new WebClient();
                string webData = webclient.DownloadString("http://megalotto.pl/");
                HtmlAgilityPack.HtmlDocument html = new HtmlAgilityPack.HtmlDocument();
                html.LoadHtml(webData);

                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable() == true)
                {
                    HtmlNode date = html.DocumentNode.SelectSingleNode("//div[@class='gry']//h5//span");
                    HtmlNodeCollection nodes = html.DocumentNode.SelectNodes("//div[@class='gry']//ul//li//span");

					scores = "";
                    for (int i = 0; i < 6; i++)
                    {
                        scores += nodes[i].InnerHtml + " ";
                    }

                    if (date2 != date.InnerText)
                    {
                        date2 = date.InnerText;
                    }
                }
                else
                { }

            });

            myThread.Start();
        }
    }
}
