using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBezverkhnii_301287637
{
    enum MedalColor
    {
        Bronze,
        Silver,
        Gold
    }

    class Medal
    {
        public Medal(string name, string theEvent, MedalColor color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;

        }

        public string Name
        {
            get; private set;
        }
        public string TheEvent
        {
            get; private set;
        }
        public MedalColor Color
        {
            get; private set;
        }
        public int Year
        {
            get; private set;
        }
        public bool IsRecord
        {
            get; private set;
        }

        public override string ToString()
        {

            if (IsRecord)
            {
                return $"{Year} - {TheEvent}(R) {Name}({Color})";
            }
            else
            {
                return $"{Year} - {TheEvent} {Name}({Color})";
            }
        }
    }
}
