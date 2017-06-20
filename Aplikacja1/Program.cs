using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.ComponentModel;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;


namespace Aplikacja1
{
    class Miasta
    {
        //przypisywanie linków miast
        public void Przypisanie(string[] pom)
        {
            pom[0] = "https://www.wunderground.com/q/zmw:00000.433.WEPLB?MR=1";//Lublin
            pom[1] = "https://www.wunderground.com/us/tx/houston/zmw:77001.1.99999";//Houston
            pom[2] = "https://www.wunderground.com/us/il/chicago/zmw:60290.1.99999";//Chicago
            pom[3] = "https://www.wunderground.com/global/stations/12485.html";//Radom
            pom[4] = "https://www.wunderground.com/q/zmw:00000.87.12372?sp=IWARSAW90&utm_source=HomeCard&utm_content=CurrentCondition&cm_ven=HomeCardCurrentCondition";//Warszawa Śródmieście
            pom[5] = "https://www.wunderground.com/us/ma/boston/zmw:02108.1.99999";//Boston
            pom[6] = "https://www.wunderground.com/cgi-bin/findweather/getForecast?query=pary%C5%BC";//Paryż
            pom[7] = "https://www.wunderground.com/cgi-bin/findweather/getForecast?query=moskwa";//Moskwa
            pom[8] = "https://www.wunderground.com/q/zmw:00000.1.17060";//Stambuł
            pom[9] = "https://www.wunderground.com/q/zmw:00000.1.08221";//Madryt
            pom[10] = "https://www.wunderground.com/q/zmw:00000.1.26849";//Mińsk
            pom[11] = "https://www.wunderground.com/q/zmw:00000.1.33345";//Kijów
            pom[12] = "https://www.wunderground.com/q/zmw:00000.1.15420";//Bukareszt
            pom[13] = "https://www.wunderground.com/q/zmw:00000.1.11034";//Wiedeń
            pom[14] = "https://www.wunderground.com/q/zmw:00000.56.WEDHI";//Hamburg
            pom[15] = "https://www.wunderground.com/q/zmw:00000.2.13274";//Belgrad
            pom[16] = "https://www.wunderground.com/q/zmw:00000.147.12838";//Budapeszt
            pom[17] = "https://www.wunderground.com/q/zmw:00000.17.08181";//Barcelona
            pom[18] = "https://www.wunderground.com/q/zmw:00000.1.34300";//Charków
            pom[19] = "https://www.wunderground.com/q/zmw:00000.1.10866";//Monachium
            pom[20] = "https://www.wunderground.com/q/zmw:00000.1.16066";//Mediolan
            pom[21] = "https://www.wunderground.com/q/zmw:00000.1.15614";//Sofia
            pom[22] = "https://www.wunderground.com/q/zmw:00000.1.40650";//Bagdad
            pom[23] = "https://www.wunderground.com/q/zmw:00000.243.43278";//Madras
            pom[24] = "https://www.wunderground.com/q/zmw:00000.614.50953";//Harbin
            pom[25] = "https://www.wunderground.com/q/zmw:00000.1.62318";//Aleksandria
            pom[26] = "https://www.wunderground.com/q/zmw:00000.187.42809";//Calccuta
            pom[27] = "https://www.wunderground.com/q/zmw:00000.1.17130";//Ankara
            pom[28] = "https://www.wunderground.com/q/zmw:00000.46.13274";//Gizela
            pom[29] = "https://www.wunderground.com/q/zmw:00000.1.63742";//Nairobi
            pom[30] = "https://www.wunderground.com/q/zmw:00000.2.80477";//Hawai
            pom[31] = "https://www.wunderground.com/q/zmw:00000.1.43555";//Male
            pom[32] = "https://www.wunderground.com/global/stations/16742";//Kos
            pom[33] = "https://www.wunderground.com/q/zmw:68501.1.99999";//Lincoln
            pom[34] = "https://www.wunderground.com/q/zmw:00000.268.16289";//Napoli
            pom[35] = "https://www.wunderground.com/q/zmw:00000.1.16059";//Turyn
            pom[36] = "https://www.wunderground.com/q/zmw:19019.1.99999";//Filadelfia
            pom[37] = "https://www.wunderground.com/q/zmw:58102.1.99999";//Fargo
            pom[38] = "https://www.wunderground.com/q/zmw:33101.1.99999";//Miami
            pom[39] = "https://www.wunderground.com/q/zmw:00000.128.16332";//Lecce
            pom[40] = "https://www.wunderground.com/global/stations/78338";//Salvador
            pom[41] = "https://www.wunderground.com/q/zmw:00000.1.61641";//Dakar
            pom[42] = "https://www.wunderground.com/q/zmw:00000.16.94768";//Sydney
            pom[43] = "https://www.wunderground.com/q/zmw:00000.300.58926";//Xianyang
            pom[44] = "https://www.wunderground.com/US/CO/Erie";//Erie
            pom[45] = "https://www.wunderground.com/q/zmw:00000.1.10513";//Kolonia
            pom[46] = "https://www.wunderground.com/q/zmw:44301.1.99999";//Akro
            pom[47] = "https://www.wunderground.com/q/zmw:27513.1.99999";//Cary
            pom[48] = "https://www.wunderground.com/q/zmw:44101.1.99999";//Cleveland
            pom[49] = "https://www.wunderground.com/q/zmw:08817.1.99999";//Edison


        }

        //odczytywanie temperatury miast
        public void Odcz(WebClient p, string[] l, string[] m, double[] t)
        {
            for (int k = 0; k < 1; k++)
            {
                Console.WriteLine("Pobieranie danych....");
                    for (int i = 0; i < 50; i++)
                    {
                        try
                        {
                            Stream temp = p.OpenRead(l[i]);
                            StreamReader odcz = new StreamReader(temp);
                            string z = odcz.ReadToEnd();
                            string[] linie = z.Split('\n');
                            string linia22 = linie[21];
                            string[] tempp = linia22.Split(',', '|', '&', '"', ' ');
                            string miasto = tempp[5];
                            string strtemp = tempp[10];
                            strtemp = strtemp.Replace(".", ",");
                            double temperatura = Double.Parse(strtemp);
                            m[i] = miasto;
                            t[i] = temperatura;
                            
                    }
                        catch (WebException e)
                        {

                        }
                    Console.WriteLine(i+1 + "/50");
                }
                Console.WriteLine("Zakonczono. \n");
            }
        }

        //sortowanie według temperatury
        public void Sort(double[] te, string[]mi)
        {
            for (int j = 0; j < 50; j++)
            {
                for (int i = 49; i > 0; i--)
                {
                    if (te[i] > te[i - 1])
                    {
                        double tmp = te[i];
                        te[i] = te[i - 1];
                        te[i - 1] = tmp;
                        string mia = mi[i];
                        mi[i] = mi[i - 1];
                        mi[i - 1] = mia;
                    }
                }
            }
        }

        //wyśiwtlanie 20 miast
        public void Wys(double[] tem,string[] mia)
        {
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine("\n");
            }

            Console.WriteLine("20 miast o najwyższej temperaturze: \n");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(tem[i] + " " + mia[i] );
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] link = new string[50];
            string[] lismiasta = new string[50];
            double[] listemp = new double[50];
            WebClient pogoda = new WebClient();
            Miasta miasto = new Miasta();
            miasto.Przypisanie(link);
            miasto.Odcz(pogoda, link, lismiasta, listemp);
            miasto.Sort(listemp, lismiasta);
            miasto.Wys(listemp, lismiasta);
            Console.WriteLine("\n");
            Console.WriteLine("Nacisnij enter aby zakonczyc program.");
            Console.ReadLine();
        }
        
    }
}
