using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class GameForm : Form
    {
        int TieGame = 0, Click = 0;
        Player PlayerOne = new Player('X');
        Player PlayerTwo = new Player('O');
        Player CurrentPlayer;
        bool Player1Turn, Player2Turn, winner;
        string[,] PlayersChoice = new string[3, 3];

        public GameForm(string PlayerOneName, string PlayerTwoName)
        {
            InitializeComponent();
            PlayerOne.GetPlyrName(PlayerOneName);
            PlayerTwo.GetPlyrName(PlayerTwoName);
            lbPlayerTurns.Text = PlayerOneName + "'s turn";
            Player1Turn = true; Player2Turn = false;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            lbPlayerOne.Text = PlayerOne.GiveName() + " Scores";
            lbPlayerTwo.Text = PlayerTwo.GiveName() + " Scores";
            winner = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button1_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button1, 0, 0);
            Game_Condition();
            CheckForTie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button2_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button2, 0, 1);
            Game_Condition();
            CheckForTie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button3_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button3, 0, 2);
            Game_Condition();
            CheckForTie();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button4_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button4, 1, 0);
            Game_Condition();
            CheckForTie();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button5_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button5, 1, 1);
            Game_Condition();
            CheckForTie();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button6_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button6, 1, 2);
            Game_Condition();
            CheckForTie();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button7_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button7, 2, 0);
            Game_Condition();
            CheckForTie();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button8_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);        
            GiveValToArr(button8, 2, 1);
            Game_Condition();
            CheckForTie();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ((Button)sender).Click -= button9_Click;
            CurrentPlayer = PlayerTurnDic(PlayerOne, PlayerTwo);
            GiveValToArr(button9, 2, 2);
            Game_Condition();
            CheckForTie();
        }

        private void buttonRetry_Click(object sender, EventArgs e)
        {
            ResetPlayer();
            ClrArr();
            btnsEnable();
            btnsTxtEmpty();
            Click = 0;
            winner = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //      ------------------|| Functions ||---------------------

        private void GiveValToArr(Button btn, int i, int j)
        {
            PlayersChoice[i, j] = CurrentPlayer.GiveSign();
            btn.Text = PlayersChoice[i, j];
        }

        private Player PlayerTurnDic(Player prmPlayer1, Player prmPlayer2) //   Shifing Turn b/w two Players
        {
            Player CurPlayer = prmPlayer1;

            if(Player1Turn == true)
            {
                Player1Turn = false;
                CurPlayer = prmPlayer1;
                Player2Turn = true;
                lbPlayerTurns.Text = PlayerTwo.GiveName() + "'s Turn";
            }
            else if(Player2Turn == true)
            {
                CurPlayer = prmPlayer2;
                Player2Turn = false;
                Player1Turn = true;
                lbPlayerTurns.Text = PlayerOne.GiveName() + "s Turn";
            }
            return CurPlayer;
        }

        public void ClrArr()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PlayersChoice[i, j] = "";
                }
            }
        }

        public void ResetPlayer()
        {
            Player1Turn = true;
            Player2Turn = false;
            lbPlayerTurns.Text = PlayerOne.GiveName() + "Turn";
        }

        private void Game_Condition()
        {
            if (PlayersChoice[0 , 0] == PlayersChoice[0, 1])
            { 
                if (PlayersChoice[0, 1] == PlayersChoice[0, 2])
                {
                    AddWinnerScore(PlayersChoice[0, 0]);
                }
            }
            if (PlayersChoice[1, 0] == PlayersChoice[1, 1])
            {
                if (PlayersChoice[1, 1] == PlayersChoice[1, 2])
                {
                    AddWinnerScore(PlayersChoice[1, 0]);
                }
            }
            if (PlayersChoice[2, 0] == PlayersChoice[2, 1])
            {
                if (PlayersChoice[2, 1] == PlayersChoice[2, 2])
                {
                    AddWinnerScore(PlayersChoice[2, 0]);
                }
            }
            if (PlayersChoice[0, 0] == PlayersChoice[1, 0])
            {
                if (PlayersChoice[1, 0] == PlayersChoice[2,0])
                {
                    AddWinnerScore(PlayersChoice[0, 0]);
                }
            }
            if (PlayersChoice[0, 1] == PlayersChoice[1, 1])
            {
                if (PlayersChoice[1, 1] == PlayersChoice[2, 1])
                {
                    AddWinnerScore(PlayersChoice[0, 1]);
                }
            }
            if (PlayersChoice[0, 2] == PlayersChoice[1, 2])
            {
                if (PlayersChoice[1, 2] == PlayersChoice[2, 2])
                {
                    AddWinnerScore(PlayersChoice[0, 2]);
                }
            }
            if (PlayersChoice[0, 0] == PlayersChoice[1, 1])
            {
                if (PlayersChoice[1, 1] == PlayersChoice[2, 2])
                {
                    AddWinnerScore(PlayersChoice[0, 0]);
                }
            }
            if (PlayersChoice[0, 2] == PlayersChoice[1, 1])
            {
                if (PlayersChoice[1, 1] == PlayersChoice[2, 0])
                {
                    AddWinnerScore(PlayersChoice[0, 2]);
                }
            }
        }

        private void AddWinnerScore(string BtnText)
        {
            if (BtnText == "X")
            {
                PlayerOne.AddScore();
                DisplayScore();
                GameOver();
                winner = true;
            }
            if (BtnText == "O")
            {
                PlayerTwo.AddScore();
                DisplayScore();
                GameOver();
                winner = true;
            }
            
        }

        private void DisplayScore()
        {
            lbPOneScore.Text = PlayerOne.ShowScore().ToString();
            lbPTwoScore.Text = PlayerTwo.ShowScore().ToString();
        }

        private void GameOver()
        {
            lbPlayerTurns.Text = "<< GAME OVER >>";
            btnsDisable();
            var myMessage = new MyMessage(CurrentPlayer.GiveName(), PlayerOne.GiveName(), PlayerTwo.GiveName(), PlayerOne.ShowScore().ToString(), PlayerTwo.ShowScore().ToString(), TieGame);
            myMessage.ShowDialog();
        }

        private void btnsDisable()
        {
            button1.Click -= button1_Click;
            button2.Click -= button2_Click;
            button3.Click -= button3_Click;
            button4.Click -= button4_Click;
            button5.Click -= button5_Click;
            button6.Click -= button6_Click;
            button7.Click -= button7_Click;
            button8.Click -= button8_Click;
            button9.Click -= button9_Click;
        }

        private void btnsEnable()
        {
            button1.Click += button1_Click;
            button2.Click += button2_Click;
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button5.Click += button5_Click;
            button6.Click += button6_Click;
            button7.Click += button7_Click;
            button8.Click += button8_Click;
            button9.Click += button9_Click;
        }

        private void btnsTxtEmpty()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public int GenRandomNum()
        {
            Random Rand = new Random();
            return Rand.Next(0, 2); ;
        }
        private void CheckForTie()
        {
            Click += 1;
            if (Click == 9 && winner == false)
            {
                lbPlayerTurns.Text = "<< Game Tie >>";
                TieGame += 1;
                lbTieGames.Text = TieGame.ToString();
            }
        }
    }
}