using System;

namespace AnimeStreaming
{
    internal class Character
    {
        private string characterID;
        private string characterName;
        private string animeName;

        public Character() { }

        public Character(string characterID, string characterName, string animeName)
        {
            this.characterID = characterID;
            this.characterName = characterName;
            this.animeName = animeName;
        }

        public string CharacterID
        {
            get { return characterID; }
            set { this.characterID = value; }
        }

        public string CharacterName
        {
            get { return characterName; }
            set { this.characterName = value; }
        }

        public string AnimeName
        {
            get { return animeName; }
            set { this.animeName = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Character ID: " + characterID);
            Console.WriteLine("Character Name: " + characterName);
            Console.WriteLine("Anime Name: " + animeName);
        }

        public virtual bool CheckPopularity()
        {
            return false;
        }
    }

}



