using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Game
{
    public partial class MyMessage : Form
    {
        string PlayerOneName, PlayerTwoName, P1Scores, P2Scores;
        int TieGames;
        public MyMessage(string Winner,string PlayerOneName,string PlayerTwoName, string P1S, string P2S,int Ties)
        {
            InitializeComponent();
            lbWinner.Text = Winner + " WIN's";
            this.PlayerOneName = PlayerOneName;
            this.PlayerTwoName = PlayerTwoName;
            P1Scores = P1S;
            P2Scores = P2S;
            TieGames = Ties;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var formReport = new ReportForm(PlayerOneName, PlayerTwoName, P1Scores, P2Scores, TieGames);
            formReport.ShowDialog();
            this.Hide();
        }
    }
}
