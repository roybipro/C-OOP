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

        public string ID
        {
            get { return characterID; }
            set { characterID = value; }
        }

        public string Name
        {
            get { return characterName; }
            set { characterName = value; }
        }

        public string AName
        {
            get { return animeName; }
            set { animeName = value; }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Character ID: " + ID);
            Console.WriteLine("Character Name: " + Name);
            Console.WriteLine("Anime Name: " + AName);
        }

        public virtual bool CheckPopularity()
        {
            return false;
        }
    }

}

