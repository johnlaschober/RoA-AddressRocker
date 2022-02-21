
namespace RoA.RockerUI
{
    partial class frmRockerUI
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
            this.lblRockerVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcessStatus = new System.Windows.Forms.Label();
            this.bgwSync = new System.ComponentModel.BackgroundWorker();
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblSkin1 = new System.Windows.Forms.Label();
            this.lblCharacter1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblSkin2 = new System.Windows.Forms.Label();
            this.lblCharacter2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.lblInMatch = new System.Windows.Forms.Label();
            this.lblFirstTo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGames1 = new System.Windows.Forms.Label();
            this.lblGames2 = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.btnSaveDirectory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.grpPlayer1.SuspendLayout();
            this.grpPlayer2.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRockerVersion
            // 
            this.lblRockerVersion.AutoSize = true;
            this.lblRockerVersion.Location = new System.Drawing.Point(463, 9);
            this.lblRockerVersion.Name = "lblRockerVersion";
            this.lblRockerVersion.Size = new System.Drawing.Size(47, 17);
            this.lblRockerVersion.TabIndex = 0;
            this.lblRockerVersion.Text = "v1.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Status:";
            // 
            // lblProcessStatus
            // 
            this.lblProcessStatus.AutoSize = true;
            this.lblProcessStatus.Location = new System.Drawing.Point(126, 9);
            this.lblProcessStatus.Name = "lblProcessStatus";
            this.lblProcessStatus.Size = new System.Drawing.Size(94, 17);
            this.lblProcessStatus.TabIndex = 2;
            this.lblProcessStatus.Text = "CONNECTED";
            // 
            // bgwSync
            // 
            this.bgwSync.WorkerReportsProgress = true;
            this.bgwSync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwSync_DoWork);
            this.bgwSync.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgwSync_ProgressChanged);
            // 
            // grpPlayer1
            // 
            this.grpPlayer1.Controls.Add(this.lblGames1);
            this.grpPlayer1.Controls.Add(this.label4);
            this.grpPlayer1.Controls.Add(this.lblSkin1);
            this.grpPlayer1.Controls.Add(this.lblCharacter1);
            this.grpPlayer1.Controls.Add(this.label3);
            this.grpPlayer1.Controls.Add(this.label2);
            this.grpPlayer1.Location = new System.Drawing.Point(37, 33);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Size = new System.Drawing.Size(233, 95);
            this.grpPlayer1.TabIndex = 3;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "Player 1";
            // 
            // lblSkin1
            // 
            this.lblSkin1.AutoSize = true;
            this.lblSkin1.Location = new System.Drawing.Point(95, 46);
            this.lblSkin1.Name = "lblSkin1";
            this.lblSkin1.Size = new System.Drawing.Size(32, 17);
            this.lblSkin1.TabIndex = 3;
            this.lblSkin1.Text = "???";
            // 
            // lblCharacter1
            // 
            this.lblCharacter1.AutoSize = true;
            this.lblCharacter1.Location = new System.Drawing.Point(95, 28);
            this.lblCharacter1.Name = "lblCharacter1";
            this.lblCharacter1.Size = new System.Drawing.Size(32, 17);
            this.lblCharacter1.TabIndex = 2;
            this.lblCharacter1.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Skin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Character:";
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblGames2);
            this.grpPlayer2.Controls.Add(this.label5);
            this.grpPlayer2.Controls.Add(this.lblSkin2);
            this.grpPlayer2.Controls.Add(this.lblCharacter2);
            this.grpPlayer2.Controls.Add(this.label8);
            this.grpPlayer2.Controls.Add(this.label9);
            this.grpPlayer2.Location = new System.Drawing.Point(276, 33);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Size = new System.Drawing.Size(233, 95);
            this.grpPlayer2.TabIndex = 4;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player 2";
            // 
            // lblSkin2
            // 
            this.lblSkin2.AutoSize = true;
            this.lblSkin2.Location = new System.Drawing.Point(95, 46);
            this.lblSkin2.Name = "lblSkin2";
            this.lblSkin2.Size = new System.Drawing.Size(32, 17);
            this.lblSkin2.TabIndex = 3;
            this.lblSkin2.Text = "???";
            // 
            // lblCharacter2
            // 
            this.lblCharacter2.AutoSize = true;
            this.lblCharacter2.Location = new System.Drawing.Point(95, 28);
            this.lblCharacter2.Name = "lblCharacter2";
            this.lblCharacter2.Size = new System.Drawing.Size(32, 17);
            this.lblCharacter2.TabIndex = 2;
            this.lblCharacter2.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Skin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Character:";
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.lblInMatch);
            this.grpMisc.Controls.Add(this.lblFirstTo);
            this.grpMisc.Controls.Add(this.label12);
            this.grpMisc.Controls.Add(this.label13);
            this.grpMisc.Location = new System.Drawing.Point(37, 134);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Size = new System.Drawing.Size(233, 95);
            this.grpMisc.TabIndex = 5;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Misc.";
            // 
            // lblInMatch
            // 
            this.lblInMatch.AutoSize = true;
            this.lblInMatch.Location = new System.Drawing.Point(95, 55);
            this.lblInMatch.Name = "lblInMatch";
            this.lblInMatch.Size = new System.Drawing.Size(32, 17);
            this.lblInMatch.TabIndex = 3;
            this.lblInMatch.Text = "???";
            // 
            // lblFirstTo
            // 
            this.lblFirstTo.AutoSize = true;
            this.lblFirstTo.Location = new System.Drawing.Point(95, 28);
            this.lblFirstTo.Name = "lblFirstTo";
            this.lblFirstTo.Size = new System.Drawing.Size(32, 17);
            this.lblFirstTo.TabIndex = 2;
            this.lblFirstTo.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "In Match:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "First To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Games:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Games:";
            // 
            // lblGames1
            // 
            this.lblGames1.AutoSize = true;
            this.lblGames1.Location = new System.Drawing.Point(95, 64);
            this.lblGames1.Name = "lblGames1";
            this.lblGames1.Size = new System.Drawing.Size(32, 17);
            this.lblGames1.TabIndex = 5;
            this.lblGames1.Text = "???";
            // 
            // lblGames2
            // 
            this.lblGames2.AutoSize = true;
            this.lblGames2.Location = new System.Drawing.Point(95, 64);
            this.lblGames2.Name = "lblGames2";
            this.lblGames2.Size = new System.Drawing.Size(32, 17);
            this.lblGames2.TabIndex = 6;
            this.lblGames2.Text = "???";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(37, 263);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(416, 22);
            this.txtSaveLocation.TabIndex = 6;
            this.txtSaveLocation.TabStop = false;
            // 
            // btnSaveDirectory
            // 
            this.btnSaveDirectory.Location = new System.Drawing.Point(459, 263);
            this.btnSaveDirectory.Name = "btnSaveDirectory";
            this.btnSaveDirectory.Size = new System.Drawing.Size(43, 23);
            this.btnSaveDirectory.TabIndex = 7;
            this.btnSaveDirectory.Text = "...";
            this.btnSaveDirectory.UseVisualStyleBackColor = true;
            this.btnSaveDirectory.Click += new System.EventHandler(this.btnSaveDirectory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "RoAState.json Save Location";
            // 
            // frmRockerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 306);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveDirectory);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.lblProcessStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRockerVersion);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 292);
            this.Name = "frmRockerUI";
            this.Text = "Address Rocker";
            this.Load += new System.EventHandler(this.frmRockerUI_Load);
            this.Shown += new System.EventHandler(this.frmRockerUI_Shown);
            this.grpPlayer1.ResumeLayout(false);
            this.grpPlayer1.PerformLayout();
            this.grpPlayer2.ResumeLayout(false);
            this.grpPlayer2.PerformLayout();
            this.grpMisc.ResumeLayout(false);
            this.grpMisc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRockerVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProcessStatus;
        private System.ComponentModel.BackgroundWorker bgwSync;
        private System.Windows.Forms.GroupBox grpPlayer1;
        private System.Windows.Forms.Label lblSkin1;
        private System.Windows.Forms.Label lblCharacter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.Label lblSkin2;
        private System.Windows.Forms.Label lblCharacter2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.Label lblInMatch;
        private System.Windows.Forms.Label lblFirstTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGames1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGames2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.Button btnSaveDirectory;
        private System.Windows.Forms.Label label6;
    }
}

