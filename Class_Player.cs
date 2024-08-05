using System;
using System.Diagnostics;

namespace Tic_Tac_Toe_Game
{
    class Player
    {
        protected char PlayerSign;
        protected string PlayerName;
        protected int Scores = 0;

        public Player() { }
        public Player(char PrmPlayerSign)
        {
            PlayerSign = PrmPlayerSign;
        }

        public void GetPlyrName(string PrmName) { PlayerName = PrmName; }
        public void AddScore() { Scores += 1; }
        public int ShowScore() { return Scores; }
        public void ResetScore() { Scores = 0; }
        public string GiveSign() { return PlayerSign.ToString(); }
        public string GiveName() { return PlayerName; }
    }
}
