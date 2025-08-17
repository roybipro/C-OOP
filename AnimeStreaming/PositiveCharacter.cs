using System;

namespace AnimeStreaming
{
    // Base Character class
    internal class Character
    {
        private string characterID;
        private string characterName;
        private string animeName;

        public Character() { }

        public Character(string characterID, string characterName, string animeName)
        {
            this.CharacterID = characterID;
            this.CharacterName = characterName;
            this.AnimeName = animeName;
        }

        public string CharacterID
        {
            get { return characterID; }
            set { characterID = value; }
        }

        public string CharacterName
        {
            get { return characterName; }
            set { characterName = value; }
        }

        public string AnimeName
        {
            get { return animeName; }
            set { animeName = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Character ID: " + CharacterID);
            Console.WriteLine("Character Name: " + CharacterName);
            Console.WriteLine("Anime Name: " + AnimeName);
        }

        public virtual bool CheckPopularity()
        {
            return false;
        }
    }

    // Derived PositiveCharacter class
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
            this.PowerLevel = powerLevel;
            this.IsMainCharacter = isMainCharacter;
            this.NumberOfEpisodes = numberOfEpisodes;
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

    // Example usage
    class Program
    {
        static void Main(string[] args)
        {
            PositiveCharacter pc = new PositiveCharacter("C001", "Naruto Uzumaki", "Naruto", 9500, "Yes", 220);
            pc.ShowInfo();
        }
    }
}
