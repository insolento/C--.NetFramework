using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("All the tiktoks:");
            TikTokManager.Show();
            Console.WriteLine();
            Console.WriteLine("All the tiktoks with hashtag covid:");
            TikTokManager.Show("covid");
            Console.WriteLine();
            Console.WriteLine("All the tiktoks with length longer than 19 sec:");
            TikTokManager.Show(19);
            Console.WriteLine();
            Console.WriteLine("All the tiktoks with the audience for the groups:");
            TikTokManager.Show(Audience.Group);
            Console.WriteLine();
            Console.WriteLine("All the TikToks after testing Initialization");
            TikTokManager.Initialize();
            TikTokManager.Show();
        }
    }
}
