using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeStreaming
{
    internal class PositiveCharacter : Character
    {
        public int PowerLevel;
        public string IsMainCharacter;
        public int NumberOfEpisodes;

        public PositiveCharacter()
        {
            
        }
        public PositiveCharacter(string characterID, string characterName, string animeName,
                                 int powerLevel, string isMainCharacter, int numberOfEpisodes)
            : base(characterID, characterName, animeName)
        {
            PowerLevel = powerLevel;
            IsMainCharacter = isMainCharacter;
            NumberOfEpisodes = numberOfEpisodes;
        }

        public override bool CheckPopularity()
        {
            return IsMainCharacter == "Yes" && PowerLevel > 9000 && NumberOfEpisodes > 150;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Power Level: " + PowerLevel);
            Console.WriteLine("Is Main Character: " + IsMainCharacter);
            Console.WriteLine("Number of Episodes: " + NumberOfEpisodes);
            Console.WriteLine("Popularity: " + (CheckPopularity() ? "Popular" : "Not Popular"));
        }
    }

}
