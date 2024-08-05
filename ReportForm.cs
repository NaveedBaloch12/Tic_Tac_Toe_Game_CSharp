using Microsoft.Reporting.WinForms;
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
    public partial class ReportForm : Form
    {
        string POneName, PTwoName, POneScores, PTwoScores;
        int TieGame;
        public ReportForm(string PlayerOneName, string PlayerTwoName ,string P1Scores, string P2Scores, int Ties )
        {
            InitializeComponent();
            POneName = PlayerOneName;
            PTwoName = PlayerTwoName;
            POneScores = P1Scores;
            PTwoScores = P2Scores;
            TieGame = Ties;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportParameter P1Name = new ReportParameter("P1Name", POneName);
            this.reportViewer1.LocalReport.SetParameters(P1Name);

            ReportParameter P2Name = new ReportParameter("P2Name", PTwoName);
            this.reportViewer1.LocalReport.SetParameters(P2Name);

            ReportParameter P1Scores = new ReportParameter("P1Scores", POneScores);
            this.reportViewer1.LocalReport.SetParameters(P1Scores);

            ReportParameter P2Scores = new ReportParameter("P2Scores", PTwoScores);
            this.reportViewer1.LocalReport.SetParameters(P2Scores);

            ReportParameter Ties = new ReportParameter("Ties", TieGame.ToString());
            this.reportViewer1.LocalReport.SetParameters(Ties);

            this.reportViewer1.RefreshReport();
        }
    }
}
