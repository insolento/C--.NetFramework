using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBezverkhnii_301287637
{
    class Program
    {
        private static void Main(string[] args)
        {
            //create a medal object
            Medal m1 = new Medal("Horace Gwynne", "Boxing", MedalColor.Gold, 2012, true);
            //print the object
            Console.WriteLine(m1);
            //print only the name of the medal holder
            Console.WriteLine(m1.Name);


            //create another object
            Medal m2 = new Medal("Michael Phelps", "Swimming", MedalColor.Gold, 2012, false);
            //print the updated m2
            Console.WriteLine(m2);





            //create a list to store the medal objects
            List<Medal> medals = new List<Medal>() { m1, m2 };

            medals.Add(new Medal("Ryan Cochrane", "Swimming", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Adam van Koeverden", "Canoeing", MedalColor.Silver, 2012, false));
            medals.Add(new Medal("Rosie MacLennan", "Gymnastics", MedalColor.Gold, 2012, false));
            medals.Add(new Medal("Christine Girard", "Weightlifting", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Charles Hamelin", "Short Track", MedalColor.Gold, 2014, true));
            medals.Add(new Medal("Alexandre Bilodeau", "Freestyle skiing", MedalColor.Gold, 2012, true));
            medals.Add(new Medal("Jennifer Jones", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Charle Cournoyer", "Short Track", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Mark McMorris", "Snowboarding", MedalColor.Bronze, 2014, false));
            medals.Add(new Medal("Sidney Crosby ", "Ice Hockey", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Brad Jacobs", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Ryan Fry", "Curling", MedalColor.Gold, 2014, false));
            medals.Add(new Medal("Antoine Valois-Fortier", "Judo", MedalColor.Bronze, 2012, false));
            medals.Add(new Medal("Brent Hayden", "Swimming", MedalColor.Bronze, 2012, false));


            //prints a numbered list of 16 medals.
            Console.WriteLine("\n\nAll 16 medals");
            int numberMedal = 0;
            foreach (Medal medal in medals)
            {
                numberMedal += 1;
                Console.WriteLine(numberMedal + ". " + medal);
            }

            //prints a numbered list of 16 names (ONLY)
            Console.WriteLine("\n\nAll 16 names");
            int numberMedal1 = 0;
            foreach (Medal medal in medals)
            {
                numberMedal1 += 1;
                Console.WriteLine(numberMedal1 + ". " + medal.Name);
            }

            //prints a numbered list of 9 gold medals
            Console.WriteLine("\n\nAll 9 gold medals");
            int numberMedal2 = 0;
            foreach (Medal medal in medals)
            {
                if (medal.Color == MedalColor.Gold)
                {
                    numberMedal2 += 1;
                    Console.WriteLine(numberMedal2 + ". " + medal);
                }
            }


            //prints a numbered list of 9 medals in 2012
            Console.WriteLine("\n\nAll 9 medals");
            int numberMedal3 = 0;
            foreach (Medal medal in medals)
            {
                if (medal.Year == 2012)
                {
                    numberMedal3 += 1;
                    Console.WriteLine(numberMedal3 + ". " + medal);
                }

            }


            //prints a numbered list of 4 gold medals in 2012
            Console.WriteLine("\n\nAll 4 gold medals");
            int numberMedal4 = 0;
            foreach (Medal medal in medals)
            {
                if ((medal.Color == MedalColor.Gold) & (medal.Year == 2012))
                {
                    numberMedal4 += 1;
                    Console.WriteLine(numberMedal4 + ". " + medal);
                }

            }


            //prints a numbered list of 3 world record medals
            Console.WriteLine("\n\nAll 3 records");
            int numberMedal5 = 0;
            foreach (Medal medal in medals)
            {
                if (medal.IsRecord)
                {
                    numberMedal5 += 1;
                    Console.WriteLine(numberMedal5 + ". " + medal);
                }
            
            }
        }
    }
}
