
namespace RoA.ScreenUI
{
    partial class frmScreenUI
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
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblP1Stocks = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblP1Games = new System.Windows.Forms.Label();
            this.lblP1Character = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblP2Stocks = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblP2Games = new System.Windows.Forms.Label();
            this.lblP2Character = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPlayer3 = new System.Windows.Forms.GroupBox();
            this.lblP3Stocks = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblP3Games = new System.Windows.Forms.Label();
            this.lblP3Character = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grpPlayer4 = new System.Windows.Forms.GroupBox();
            this.lblP4Stocks = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblP4Games = new System.Windows.Forms.Label();
            this.lblP4Character = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.grpMatch = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblStocks = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblInMatch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBestOf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bgwSync = new System.ComponentModel.BackgroundWorker();
            this.lblP1Damage = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblP2Damage = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblP3Damage = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblP4Damage = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSaveDirectory = new System.Windows.Forms.Button();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.grpPlayer1.SuspendLayout();
            this.grpPlayer2.SuspendLayout();
            this.grpPlayer3.SuspendLayout();
            this.grpPlayer4.SuspendLayout();
            this.grpMatch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.Controls.Add(this.lblP1Damage);
            this.grpPlayer1.Controls.Add(this.label17);
            this.grpPlayer1.Controls.Add(this.lblP1Stocks);
            this.grpPlayer1.Controls.Add(this.label7);
            this.grpPlayer1.Controls.Add(this.lblP1Games);
            this.grpPlayer1.Controls.Add(this.lblP1Character);
            this.grpPlayer1.Controls.Add(this.label2);
            this.grpPlayer1.Controls.Add(this.label1);
            this.grpPlayer1.Location = new System.Drawing.Point(12, 12);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(190, 89);
            this.grpPlayer1.TabIndex = 0;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "Player 1";
            // 
            // lblP1Stocks
            // 
            this.lblP1Stocks.AutoSize = true;
            this.lblP1Stocks.Location = new System.Drawing.Point(68, 40);
            this.lblP1Stocks.Name = "lblP1Stocks";
            this.lblP1Stocks.Size = new System.Drawing.Size(25, 13);
            this.lblP1Stocks.TabIndex = 5;
            this.lblP1Stocks.Text = "???";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Stocks:";
            // 
            // lblP1Games
            // 
            this.lblP1Games.AutoSize = true;
            this.lblP1Games.Location = new System.Drawing.Point(68, 70);
            this.lblP1Games.Name = "lblP1Games";
            this.lblP1Games.Size = new System.Drawing.Size(25, 13);
            this.lblP1Games.TabIndex = 3;
            this.lblP1Games.Text = "???";
            // 
            // lblP1Character
            // 
            this.lblP1Character.AutoSize = true;
            this.lblP1Character.Location = new System.Drawing.Point(68, 25);
            this.lblP1Character.Name = "lblP1Character";
            this.lblP1Character.Size = new System.Drawing.Size(25, 13);
            this.lblP1Character.TabIndex = 2;
            this.lblP1Character.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Games:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Character:";
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblP2Damage);
            this.grpPlayer2.Controls.Add(this.lblP2Stocks);
            this.grpPlayer2.Controls.Add(this.label20);
            this.grpPlayer2.Controls.Add(this.label8);
            this.grpPlayer2.Controls.Add(this.lblP2Games);
            this.grpPlayer2.Controls.Add(this.lblP2Character);
            this.grpPlayer2.Controls.Add(this.label5);
            this.grpPlayer2.Controls.Add(this.label6);
            this.grpPlayer2.Location = new System.Drawing.Point(208, 12);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(190, 89);
            this.grpPlayer2.TabIndex = 4;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player 2";
            // 
            // lblP2Stocks
            // 
            this.lblP2Stocks.AutoSize = true;
            this.lblP2Stocks.Location = new System.Drawing.Point(68, 40);
            this.lblP2Stocks.Name = "lblP2Stocks";
            this.lblP2Stocks.Size = new System.Drawing.Size(25, 13);
            this.lblP2Stocks.TabIndex = 6;
            this.lblP2Stocks.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Stocks:";
            // 
            // lblP2Games
            // 
            this.lblP2Games.AutoSize = true;
            this.lblP2Games.Location = new System.Drawing.Point(68, 70);
            this.lblP2Games.Name = "lblP2Games";
            this.lblP2Games.Size = new System.Drawing.Size(25, 13);
            this.lblP2Games.TabIndex = 3;
            this.lblP2Games.Text = "???";
            // 
            // lblP2Character
            // 
            this.lblP2Character.AutoSize = true;
            this.lblP2Character.Location = new System.Drawing.Point(68, 25);
            this.lblP2Character.Name = "lblP2Character";
            this.lblP2Character.Size = new System.Drawing.Size(25, 13);
            this.lblP2Character.TabIndex = 2;
            this.lblP2Character.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Games:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Character:";
            // 
            // grpPlayer3
            // 
            this.grpPlayer3.Controls.Add(this.lblP3Damage);
            this.grpPlayer3.Controls.Add(this.lblP3Stocks);
            this.grpPlayer3.Controls.Add(this.label22);
            this.grpPlayer3.Controls.Add(this.label11);
            this.grpPlayer3.Controls.Add(this.lblP3Games);
            this.grpPlayer3.Controls.Add(this.lblP3Character);
            this.grpPlayer3.Controls.Add(this.label9);
            this.grpPlayer3.Controls.Add(this.label10);
            this.grpPlayer3.Location = new System.Drawing.Point(404, 12);
            this.grpPlayer3.Name = "grpPlayer3";
            this.grpPlayer3.Size = new System.Drawing.Size(190, 89);
            this.grpPlayer3.TabIndex = 5;
            this.grpPlayer3.TabStop = false;
            this.grpPlayer3.Text = "Player 3";
            // 
            // lblP3Stocks
            // 
            this.lblP3Stocks.AutoSize = true;
            this.lblP3Stocks.Location = new System.Drawing.Point(68, 40);
            this.lblP3Stocks.Name = "lblP3Stocks";
            this.lblP3Stocks.Size = new System.Drawing.Size(25, 13);
            this.lblP3Stocks.TabIndex = 7;
            this.lblP3Stocks.Text = "???";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Stocks:";
            // 
            // lblP3Games
            // 
            this.lblP3Games.AutoSize = true;
            this.lblP3Games.Location = new System.Drawing.Point(68, 70);
            this.lblP3Games.Name = "lblP3Games";
            this.lblP3Games.Size = new System.Drawing.Size(25, 13);
            this.lblP3Games.TabIndex = 3;
            this.lblP3Games.Text = "???";
            // 
            // lblP3Character
            // 
            this.lblP3Character.AutoSize = true;
            this.lblP3Character.Location = new System.Drawing.Point(68, 25);
            this.lblP3Character.Name = "lblP3Character";
            this.lblP3Character.Size = new System.Drawing.Size(25, 13);
            this.lblP3Character.TabIndex = 2;
            this.lblP3Character.Text = "???";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Games:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Character:";
            // 
            // grpPlayer4
            // 
            this.grpPlayer4.Controls.Add(this.lblP4Damage);
            this.grpPlayer4.Controls.Add(this.lblP4Stocks);
            this.grpPlayer4.Controls.Add(this.label24);
            this.grpPlayer4.Controls.Add(this.label12);
            this.grpPlayer4.Controls.Add(this.lblP4Games);
            this.grpPlayer4.Controls.Add(this.lblP4Character);
            this.grpPlayer4.Controls.Add(this.label13);
            this.grpPlayer4.Controls.Add(this.label14);
            this.grpPlayer4.Location = new System.Drawing.Point(600, 12);
            this.grpPlayer4.Name = "grpPlayer4";
            this.grpPlayer4.Size = new System.Drawing.Size(190, 89);
            this.grpPlayer4.TabIndex = 6;
            this.grpPlayer4.TabStop = false;
            this.grpPlayer4.Text = "Player 4";
            // 
            // lblP4Stocks
            // 
            this.lblP4Stocks.AutoSize = true;
            this.lblP4Stocks.Location = new System.Drawing.Point(68, 40);
            this.lblP4Stocks.Name = "lblP4Stocks";
            this.lblP4Stocks.Size = new System.Drawing.Size(25, 13);
            this.lblP4Stocks.TabIndex = 8;
            this.lblP4Stocks.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Stocks:";
            // 
            // lblP4Games
            // 
            this.lblP4Games.AutoSize = true;
            this.lblP4Games.Location = new System.Drawing.Point(68, 70);
            this.lblP4Games.Name = "lblP4Games";
            this.lblP4Games.Size = new System.Drawing.Size(25, 13);
            this.lblP4Games.TabIndex = 3;
            this.lblP4Games.Text = "???";
            // 
            // lblP4Character
            // 
            this.lblP4Character.AutoSize = true;
            this.lblP4Character.Location = new System.Drawing.Point(68, 25);
            this.lblP4Character.Name = "lblP4Character";
            this.lblP4Character.Size = new System.Drawing.Size(25, 13);
            this.lblP4Character.TabIndex = 2;
            this.lblP4Character.Text = "???";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Games:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Character:";
            // 
            // grpMatch
            // 
            this.grpMatch.Controls.Add(this.lblTime);
            this.grpMatch.Controls.Add(this.label18);
            this.grpMatch.Controls.Add(this.lblStocks);
            this.grpMatch.Controls.Add(this.label16);
            this.grpMatch.Controls.Add(this.lblInMatch);
            this.grpMatch.Controls.Add(this.label4);
            this.grpMatch.Controls.Add(this.lblBestOf);
            this.grpMatch.Controls.Add(this.label3);
            this.grpMatch.Location = new System.Drawing.Point(12, 107);
            this.grpMatch.Name = "grpMatch";
            this.grpMatch.Size = new System.Drawing.Size(200, 100);
            this.grpMatch.TabIndex = 7;
            this.grpMatch.TabStop = false;
            this.grpMatch.Text = "Match";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(68, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(25, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "???";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Time:";
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.Location = new System.Drawing.Point(68, 43);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(25, 13);
            this.lblStocks.TabIndex = 6;
            this.lblStocks.Text = "???";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Stocks:";
            // 
            // lblInMatch
            // 
            this.lblInMatch.AutoSize = true;
            this.lblInMatch.Location = new System.Drawing.Point(68, 78);
            this.lblInMatch.Name = "lblInMatch";
            this.lblInMatch.Size = new System.Drawing.Size(25, 13);
            this.lblInMatch.TabIndex = 5;
            this.lblInMatch.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "In Match:";
            // 
            // lblBestOf
            // 
            this.lblBestOf.AutoSize = true;
            this.lblBestOf.Location = new System.Drawing.Point(68, 26);
            this.lblBestOf.Name = "lblBestOf";
            this.lblBestOf.Size = new System.Drawing.Size(25, 13);
            this.lblBestOf.TabIndex = 4;
            this.lblBestOf.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Best Of:";
            // 
            // bgwSync
            // 
            this.bgwSync.WorkerReportsProgress = true;
            this.bgwSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSync_DoWork);
            this.bgwSync.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSync_ProgressChanged);
            // 
            // lblP1Damage
            // 
            this.lblP1Damage.AutoSize = true;
            this.lblP1Damage.Location = new System.Drawing.Point(68, 55);
            this.lblP1Damage.Name = "lblP1Damage";
            this.lblP1Damage.Size = new System.Drawing.Size(25, 13);
            this.lblP1Damage.TabIndex = 7;
            this.lblP1Damage.Text = "???";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 55);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(50, 13);
            this.label17.TabIndex = 6;
            this.label17.Text = "Damage:";
            // 
            // lblP2Damage
            // 
            this.lblP2Damage.AutoSize = true;
            this.lblP2Damage.Location = new System.Drawing.Point(68, 55);
            this.lblP2Damage.Name = "lblP2Damage";
            this.lblP2Damage.Size = new System.Drawing.Size(25, 13);
            this.lblP2Damage.TabIndex = 9;
            this.lblP2Damage.Text = "???";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Damage:";
            // 
            // lblP3Damage
            // 
            this.lblP3Damage.AutoSize = true;
            this.lblP3Damage.Location = new System.Drawing.Point(68, 55);
            this.lblP3Damage.Name = "lblP3Damage";
            this.lblP3Damage.Size = new System.Drawing.Size(25, 13);
            this.lblP3Damage.TabIndex = 11;
            this.lblP3Damage.Text = "???";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Damage:";
            // 
            // lblP4Damage
            // 
            this.lblP4Damage.AutoSize = true;
            this.lblP4Damage.Location = new System.Drawing.Point(68, 55);
            this.lblP4Damage.Name = "lblP4Damage";
            this.lblP4Damage.Size = new System.Drawing.Size(25, 13);
            this.lblP4Damage.TabIndex = 13;
            this.lblP4Damage.Text = "???";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "Damage:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 170);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "RoAState.json Save Location";
            // 
            // btnSaveDirectory
            // 
            this.btnSaveDirectory.Location = new System.Drawing.Point(642, 188);
            this.btnSaveDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveDirectory.Name = "btnSaveDirectory";
            this.btnSaveDirectory.Size = new System.Drawing.Size(32, 19);
            this.btnSaveDirectory.TabIndex = 10;
            this.btnSaveDirectory.Text = "...";
            this.btnSaveDirectory.UseVisualStyleBackColor = true;
            this.btnSaveDirectory.Click += new System.EventHandler(this.btnSaveDirectory_Click);
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(227, 187);
            this.txtSaveLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(410, 20);
            this.txtSaveLocation.TabIndex = 9;
            this.txtSaveLocation.TabStop = false;
            // 
            // frmScreenUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 241);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnSaveDirectory);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.grpMatch);
            this.Controls.Add(this.grpPlayer4);
            this.Controls.Add(this.grpPlayer3);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Name = "frmScreenUI";
            this.Text = "Screen Rocker";
            this.Load += new System.EventHandler(this.frmScreenUI_Load);
            this.grpPlayer1.ResumeLayout(false);
            this.grpPlayer1.PerformLayout();
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer2.PerformLayout();
            this.grpPlayer3.ResumeLayout(false);
            this.grpPlayer3.PerformLayout();
            this.grpPlayer4.ResumeLayout(false);
            this.grpPlayer4.PerformLayout();
            this.grpMatch.ResumeLayout(false);
            this.grpMatch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.Label lblP1Games;
        private System.Windows.Forms.Label lblP1Character;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.Label lblP2Games;
        private System.Windows.Forms.Label lblP2Character;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpPlayer3;
        private System.Windows.Forms.Label lblP3Games;
        private System.Windows.Forms.Label lblP3Character;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox grpPlayer4;
        private System.Windows.Forms.Label lblP4Games;
        private System.Windows.Forms.Label lblP4Character;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox grpMatch;
        private System.Windows.Forms.Label lblInMatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblBestOf;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker bgwSync;
        private System.Windows.Forms.Label lblP1Stocks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblP2Stocks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblP3Stocks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblP4Stocks;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblP1Damage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblP2Damage;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblP3Damage;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblP4Damage;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSaveDirectory;
        private System.Windows.Forms.TextBox txtSaveLocation;
    }
}

