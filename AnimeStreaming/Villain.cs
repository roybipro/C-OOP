using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeStreaming
{
   internal class Villain : Character
    {
        private int evilScore;
        private string finalBattleOutcome;

        public Villain() { }

        public Villain(string characterID, string characterName, string animeName,
                       int evilScore, string finalBattleOutcome)
            : base(characterID, characterName, animeName)
        {
            this.evilScore = evilScore;
            this.finalBattleOutcome = finalBattleOutcome;
        }

        public int EvilScore
        {
            get { return evilScore; }
            set { evilScore = value; }
        }

        public string FinalBattleOutcome
        {
            get { return finalBattleOutcome; }
            set { finalBattleOutcome = value; }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Evil Score: " + EvilScore);
            Console.WriteLine("Final Battle Outcome: " + FinalBattleOutcome);
        }
    }

}

