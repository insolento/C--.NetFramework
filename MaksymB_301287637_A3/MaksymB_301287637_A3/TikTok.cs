using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaksymB_301287637_A3
{
    enum Audience
    {
        World,
        Group,
        Special
    }

    internal class TikTok
    {
        private static int _ID = 0;

        internal TikTok(string originator, int length, string hashTag, Audience audience)
        {
            Originator = originator;
            Length = length;
            HashTag = hashTag;
            Audience = audience;
            Id = _ID.ToString();
            _ID++;
        }
        private TikTok(string id, string originator, string length, string hashTag, string audience)
        {
            Id = id;
            Originator = originator;
            Length = Convert.ToInt32(length);
            HashTag = hashTag;

            if (audience=="group")
            {
                Audience = Audience.Group;
            } else if (audience == "world")
            {
                Audience= Audience.World;
            } else
            {
                Audience = Audience.Special;
            }
        }

        public string Originator { get; }

        public int Length { get; }

        public string HashTag { get; }

        public Audience Audience { get; }

        public string Id { get; }

        public override string ToString()
        {
            return $"Originator is {Originator}, video length is {Length} second, has #{HashTag} hashtag for the {Audience}, video id is {Id}";
        }

        public static TikTok Parse(string line)
        {
            string[] parsedString = line.Split('\t');

            TikTok tikTok = new TikTok(parsedString[0], parsedString[1], parsedString[2], parsedString[4], parsedString[3]);
            return tikTok;
        }
    }
}
