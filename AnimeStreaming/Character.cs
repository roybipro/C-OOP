using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeStreaming
{
    internal class Character
    {
        public string characterID;
        public string characterName;
        public string animeName;

        public Character()
        {

        }
        public Character(string characterID, string characterName, string animeName)
        {
            this.characterID = ID;
            this.characterName = Name;
            this.animeName = AName;
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

