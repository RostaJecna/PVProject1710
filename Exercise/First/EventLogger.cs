using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVProject1710.Exercise.First
{
    internal class EventLogger
    {
        public List<Event> Events { get; set; }

        public EventLogger(List<Event> events)
        {
            Events = events;
        }

        public void AddEvent(Event @event)
        {
            Events.Add(@event);
        }

        public List<Event> Filter(Type type, Level level)
        {
            if(type == Type.Any && level == Level.Any)
            {
                return Events;
            }

            List<Event> filter = new();

            foreach (Event @event in Events)
            {
                if(@event.Type == type && @event.Level == level)
                {
                    filter.Add(@event);
                }else if (@event.Type == type && level == Level.Any)
                {
                    filter.Add(@event);
                }else if (@event.Type == Type.Any && @event.Level == level)
                {
                    filter.Add(@event);
                }
            }

            return filter;
        }
    }
}
