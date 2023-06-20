using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Shows
    {
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Host { get; set; }
        public readonly DateTime Time;

        public Shows(string name, string disrc, string host)
        {
            Name = name;
            Discription = disrc;
            Host = host;
            Time = DateTime.Now.ToUniversalTime();
        }

        public virtual string GetInfo() =>
            $"{Discription} {Name}. Ведущий {Host}. Время выхода: {Time}";

    }
}