using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    internal class Series : Shows
    {
        public string NumberOfSeason { get; set; }
        public string NumberOfEpisode { get; set; }
        public Series(string numberOfSeason, string numberOfEpisode)
        {
            NumberOfSeason = numberOfSeason;
            NumberOfEpisode = numberOfEpisode;
        }

        public override string GetInfo() =>
            $"Number of season: {NumberOfSeason}, number of episode: {NumberOfEpisode}";
    }
}