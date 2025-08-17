using System;

namespace AnimeStreaming
{
    internal class PositiveCharacter : Character
    {
        private int powerLevel;
        private string isMainCharacter;
        private int numberOfEpisodes;

        public PositiveCharacter() { }

        public PositiveCharacter(string characterID, string characterName, string animeName,
                                 int powerLevel, string isMainCharacter, int numberOfEpisodes)
            : base(characterID, characterName, animeName)
        {
            this.powerLevel = powerLevel;
            this.isMainCharacter = isMainCharacter;
            this.numberOfEpisodes = numberOfEpisodes;
        }

        public int PowerLevel
        {
            get { return powerLevel; }
            set { powerLevel = value; }
        }

        public string IsMainCharacter
        {
            get { return isMainCharacter; }
            set { isMainCharacter = value; }
        }

        public int NumberOfEpisodes
        {
            get { return numberOfEpisodes; }
            set { numberOfEpisodes = value; }
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

