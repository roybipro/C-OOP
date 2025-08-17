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
            set { this.powerLevel = value; }
        }

        public string IsMainCharacter
        {
            get { return isMainCharacter; }
            set { this.isMainCharacter = value; }
        }

        public int NumberOfEpisodes
        {
            get { return numberOfEpisodes; }
            set { this.numberOfEpisodes = value; }
        }

        public override bool CheckPopularity()
        {
            return IsMainCharacter == "Yes" && PowerLevel > 9000 && NumberOfEpisodes > 150;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Power Level: " + powerLevel);
            Console.WriteLine("Is Main Character: " + isMainCharacter);
            Console.WriteLine("Number of Episodes: " + numberOfEpisodes);
            Console.WriteLine("Popularity: " + (CheckPopularity() ? "Popular" : "Not Popular"));
        }
    }
}


