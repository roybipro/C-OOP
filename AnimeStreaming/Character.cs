using System;

namespace AnimeStreaming
{
    internal class Character
    {
        private string characterID;
        private string characterName;
        private string animeName;

        // Default constructor
        public Character() { }

        // Parameterized constructor
        public Character(string characterID, string characterName, string animeName)
        {
            this.characterID = characterID;
            this.characterName = characterName;
            this.animeName = animeName;
        }

        // Properties
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

        // Methods
        public void ShowInfo()
        {
            Console.WriteLine("Character ID: " + CharacterID);
            Console.WriteLine("Character Name: " + CharacterName);
            Console.WriteLine("Anime Name: " + AnimeName);
        }

        public bool CheckPopularity()
        {
            // You can later override this in a derived class
            return false;
        }
    }
}
