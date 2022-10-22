using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVProject1710.Exercise.First
{
    internal class Event
    {
        public Type Type { get; set; }
        public Level Level { get; set; }
        public string Description { get; set; }

        public Event(Type type, Level level, string description)
        {
            Type = type;
            Level = level;
            Description = description;
        }

        public override string ToString()
        {
            return "Event: " + Type + "." + Level + "\n[" + Description +"]";
        }
    }
}
