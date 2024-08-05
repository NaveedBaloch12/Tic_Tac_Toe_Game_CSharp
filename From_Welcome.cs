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
    public partial class FrmWelcome : Form
    {
        static string P1Name, P2Name;
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Click -= btnStart_Click; // Disable Click Event After First Click
            if (txtFstName.Text != "" && txtSecName.Text != "")     // Check Fields are Filled
            {
                Progress();
            }
            else if (txtFstName.Text != "" || txtSecName.Text != "")
            {
                MessageBox.Show("Enter Players Name", "Invalid");
                btnStart.Click += btnStart_Click;
            }
            else
            {
                txtFstName.Text = "Player One";
                txtSecName.Text = "Player Two";
                Progress();
            }

            P1Name = txtFstName.Text;
            P2Name = txtSecName.Text;
        }

        private async void Progress()
        {
            Random rand = new Random(); 

            await Task.Delay(50);
            pgbStart.Visible = true;

            for (int i = 0; i <= 100; i++)
            {
                pgbStart.Value = i;
                await Task.Delay(1);
                if (i == rand.Next(20, 92))
                    await Task.Delay(800);
            }

            await Task.Delay(800);
            var gameform = new GameForm(txtFstName.Text, txtSecName.Text);  // To Open GameForm
            OpenForm(gameform);
        }

        private void OpenForm(Form PrmForm) // Hide Current form and Open New Form
        {
            this.Hide();
            PrmForm.FormClosed += (s, argz) => this.Close();
            PrmForm.Show();
        }
    }
}
