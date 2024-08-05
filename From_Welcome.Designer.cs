namespace Tic_Tac_Toe_Game
{
    partial class FrmWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWelcome));
            this.lblWelCom = new System.Windows.Forms.Label();
            this.lblFstName = new System.Windows.Forms.Label();
            this.txtFstName = new System.Windows.Forms.TextBox();
            this.txtSecName = new System.Windows.Forms.TextBox();
            this.lblSecName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pgbStart = new System.Windows.Forms.ProgressBar();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.SuspendLayout();
            // 
            // lblWelCom
            // 
            this.lblWelCom.AutoSize = true;
            this.lblWelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelCom.Location = new System.Drawing.Point(149, 65);
            this.lblWelCom.Name = "lblWelCom";
            this.lblWelCom.Size = new System.Drawing.Size(203, 40);
            this.lblWelCom.TabIndex = 0;
            this.lblWelCom.Text = "WELCOME";
            // 
            // lblFstName
            // 
            this.lblFstName.AutoSize = true;
            this.lblFstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFstName.Location = new System.Drawing.Point(62, 154);
            this.lblFstName.Name = "lblFstName";
            this.lblFstName.Size = new System.Drawing.Size(206, 22);
            this.lblFstName.TabIndex = 1;
            this.lblFstName.Text = "Enter First Player Name:";
            // 
            // txtFstName
            // 
            this.txtFstName.Location = new System.Drawing.Point(66, 208);
            this.txtFstName.Name = "txtFstName";
            this.txtFstName.Size = new System.Drawing.Size(373, 26);
            this.txtFstName.TabIndex = 2;
            // 
            // txtSecName
            // 
            this.txtSecName.Location = new System.Drawing.Point(66, 322);
            this.txtSecName.Name = "txtSecName";
            this.txtSecName.Size = new System.Drawing.Size(373, 26);
            this.txtSecName.TabIndex = 4;
            // 
            // lblSecName
            // 
            this.lblSecName.AutoSize = true;
            this.lblSecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecName.Location = new System.Drawing.Point(62, 268);
            this.lblSecName.Name = "lblSecName";
            this.lblSecName.Size = new System.Drawing.Size(232, 22);
            this.lblSecName.TabIndex = 3;
            this.lblSecName.Text = "Enter Second Player Name:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(176, 382);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 53);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pgbStart
            // 
            this.pgbStart.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.pgbStart.Location = new System.Drawing.Point(66, 469);
            this.pgbStart.Name = "pgbStart";
            this.pgbStart.Size = new System.Drawing.Size(373, 23);
            this.pgbStart.Step = 1000;
            this.pgbStart.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbStart.TabIndex = 6;
            this.pgbStart.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // FrmWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(500, 557);
            this.Controls.Add(this.pgbStart);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtSecName);
            this.Controls.Add(this.lblSecName);
            this.Controls.Add(this.txtFstName);
            this.Controls.Add(this.lblFstName);
            this.Controls.Add(this.lblWelCom);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WELCOME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelCom;
        private System.Windows.Forms.Label lblFstName;
        private System.Windows.Forms.TextBox txtFstName;
        private System.Windows.Forms.TextBox txtSecName;
        private System.Windows.Forms.Label lblSecName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar pgbStart;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

