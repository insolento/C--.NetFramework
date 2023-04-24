using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A3
{
    internal static class TikTokManager
    {
        private static List<TikTok> TIKTOKS = new List<TikTok>();

        private static string FILENAME = @"tiktoks.txt";

        static TikTokManager()
        {
            TextReader reader = new StreamReader(FILENAME);
            string line = reader.ReadLine();
            while(line != null)
            { 
                TIKTOKS.Add((TikTok)TikTok.Parse(line));
                line = reader.ReadLine();
            }
        }

        public static void Initialize()
        {
            List<TikTok> TIKTOKS = new List<TikTok>();
            TikTok tikTok1 = new TikTok("kiki",12,"covid",Audience.Special);
            TikTok tikTok2 = new TikTok("loluler",22, "dog",Audience.Group);
            TikTok tikTok3 = new TikTok("chessking",43, "world",Audience.World);
            TikTok tikTok4 = new TikTok("developer",59, "beautiful",Audience.Special);
            TikTok tikTok5 = new TikTok("horses",5, "horse",Audience.World);
            TIKTOKS.Add(tikTok1);
            TIKTOKS.Add(tikTok2);
            TIKTOKS.Add(tikTok3);
            TIKTOKS.Add(tikTok4);
            TIKTOKS.Add(tikTok5);
        }

        public static void Show()
        {
            foreach(TikTok t in TIKTOKS)
            {
                Console.WriteLine(t.ToString());
            }
        }

        public static void Show(string tag)
        {
            foreach (TikTok t in TIKTOKS) { 
                if (t.HashTag == tag)
                {
                    Console.WriteLine(t.ToString());
                }
            }
        }
        
        public static void Show(int length)
        {
            foreach (TikTok t in TIKTOKS)
            {
                if (t.Length > length)
                {
                    Console.WriteLine(t.ToString());
                }
            }
        }

        public static void Show(Audience audience)
        {
            foreach (TikTok t in TIKTOKS)
            {
                if (t.Audience == audience)
                {
                    Console.WriteLine(t.ToString());
                }
            }
        }
    }
}
