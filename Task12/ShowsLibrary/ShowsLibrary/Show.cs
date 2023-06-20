using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShowsLibrary;

namespace ShowsLibrary
{
    public class Show
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Host { get; set; }
        public readonly Frequency Frequency;
        public readonly DateTime Time;
        public Show(string title, string description, string host, Frequency frequency, string time)
        {
            Title = title;
            Description = description;
            Host = host;
            Frequency = frequency;
            Time = DateTime.Parse(time);
        }
        public string GetInfo()
        {
            var frequency = "";

            if (Frequency == Frequency.NonPeriodic)
            {
                frequency = "Not periodic";
                return $"{frequency} {Title} {Description}. Ведущий {Host}. Дата выхода: {Time:g}.";
            }
            else
            {
                frequency = Frequency.ToString(frequency);
                return $"{frequency} {Title} {Description}. Ведущий {Host}. Дата выхода: {Time:d}.";
            }

        }
    }
}