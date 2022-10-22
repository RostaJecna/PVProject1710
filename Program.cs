using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PVProject1710.Exercise.First;
using Type = PVProject1710.Exercise.First.Type;

namespace PVProject1710
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region Exercise.Firts
            Console.WriteLine("_Exercise.Firts");

            List<Event> events = new()
            {
                new Event(Type.Application, Level.Warning, "Update the driver for correct work!"),
                new Event(Type.Hardware, Level.Error, "RAM problem."),
                new Event(Type.System, Level.Warning, "Your computer has a low battery!"),
                new Event(Type.Application, Level.Information, "Installation was successful."),
                new Event(Type.System, Level.Information, "The system is successfully launched."),
                new Event(Type.Application, Level.Warning, "PlayZone has gone into minimized mode!"),
                new Event(Type.System, Level.Error, "The required .dll is missing."),
                new Event(Type.Hardware, Level.Information, "I/O device successfully connected."),
                new Event(Type.Application, Level.Information, "Settings applied."),
                new Event(Type.Hardware, Level.Warning, "Low CPU fan speed, voltage level issue!"),
                new Event(Type.System, Level.Error, "Failed to start the system."),
                new Event(Type.Hardware, Level.Error, "Cache memory error."),
                new Event(Type.Application, Level.Error, "The latest JDK version is missing."),
                new Event(Type.System, Level.Information, "Update installed."),
                new Event(Type.Hardware, Level.Information, "POST, computer is ok."),
                new Event(Type.Application, Level.Information, "Successfully completely removed."),
                new Event(Type.Application, Level.Error, "Unknown, try reinstalling.")
            };
            EventLogger eventLogger = new(events);

            List<Event> eventsFilter = eventLogger.Filter(Type.System, Level.Information);
            foreach(Event @event in eventsFilter)
            {
                Console.WriteLine(@event);
            }
            #endregion
        }
    }
}
