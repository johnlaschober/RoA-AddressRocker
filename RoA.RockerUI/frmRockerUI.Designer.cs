
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRockerUI));
            this.lblRockerVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProcessStatus = new System.Windows.Forms.Label();
            this.bgwSync = new System.ComponentModel.BackgroundWorker();
            this.grpPlayer1 = new System.Windows.Forms.GroupBox();
            this.lblSkinIndex1 = new System.Windows.Forms.Label();
            this.lblSkinDesc1 = new System.Windows.Forms.Label();
            this.lblGames1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCharacter1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpPlayer2 = new System.Windows.Forms.GroupBox();
            this.lblSkinIndex2 = new System.Windows.Forms.Label();
            this.lblSkinDesc2 = new System.Windows.Forms.Label();
            this.lblGames2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCharacter2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpMisc = new System.Windows.Forms.GroupBox();
            this.lblInMatch = new System.Windows.Forms.Label();
            this.lblBestOf = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSaveLocation = new System.Windows.Forms.TextBox();
            this.btnSaveDirectory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chkOverrideMD5 = new System.Windows.Forms.CheckBox();
            this.cmbMD5Override = new System.Windows.Forms.ComboBox();
            this.grpPlayer1.SuspendLayout();
            this.grpPlayer2.SuspendLayout();
            this.grpMisc.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRockerVersion
            // 
            this.lblRockerVersion.AutoSize = true;
            this.lblRockerVersion.Location = new System.Drawing.Point(439, 7);
            this.lblRockerVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRockerVersion.Name = "lblRockerVersion";
            this.lblRockerVersion.Size = new System.Drawing.Size(37, 13);
            this.lblRockerVersion.TabIndex = 0;
            this.lblRockerVersion.Text = "v1.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Process Status:";
            // 
            // lblProcessStatus
            // 
            this.lblProcessStatus.AutoSize = true;
            this.lblProcessStatus.Location = new System.Drawing.Point(94, 7);
            this.lblProcessStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcessStatus.Name = "lblProcessStatus";
            this.lblProcessStatus.Size = new System.Drawing.Size(74, 13);
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
            this.grpPlayer1.Controls.Add(this.lblSkinIndex1);
            this.grpPlayer1.Controls.Add(this.lblSkinDesc1);
            this.grpPlayer1.Controls.Add(this.lblGames1);
            this.grpPlayer1.Controls.Add(this.label4);
            this.grpPlayer1.Controls.Add(this.lblCharacter1);
            this.grpPlayer1.Controls.Add(this.label3);
            this.grpPlayer1.Controls.Add(this.label2);
            this.grpPlayer1.Location = new System.Drawing.Point(28, 27);
            this.grpPlayer1.Margin = new System.Windows.Forms.Padding(2);
            this.grpPlayer1.Name = "grpPlayer1";
            this.grpPlayer1.Padding = new System.Windows.Forms.Padding(2);
            this.grpPlayer1.Size = new System.Drawing.Size(218, 96);
            this.grpPlayer1.TabIndex = 3;
            this.grpPlayer1.TabStop = false;
            this.grpPlayer1.Text = "Player 1";
            // 
            // lblSkinIndex1
            // 
            this.lblSkinIndex1.AutoSize = true;
            this.lblSkinIndex1.Location = new System.Drawing.Point(71, 51);
            this.lblSkinIndex1.Name = "lblSkinIndex1";
            this.lblSkinIndex1.Size = new System.Drawing.Size(25, 13);
            this.lblSkinIndex1.TabIndex = 7;
            this.lblSkinIndex1.Text = "???";
            // 
            // lblSkinDesc1
            // 
            this.lblSkinDesc1.AutoSize = true;
            this.lblSkinDesc1.Location = new System.Drawing.Point(71, 37);
            this.lblSkinDesc1.Name = "lblSkinDesc1";
            this.lblSkinDesc1.Size = new System.Drawing.Size(25, 13);
            this.lblSkinDesc1.TabIndex = 6;
            this.lblSkinDesc1.Text = "???";
            // 
            // lblGames1
            // 
            this.lblGames1.AutoSize = true;
            this.lblGames1.Location = new System.Drawing.Point(71, 65);
            this.lblGames1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGames1.Name = "lblGames1";
            this.lblGames1.Size = new System.Drawing.Size(25, 13);
            this.lblGames1.TabIndex = 5;
            this.lblGames1.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Games:";
            // 
            // lblCharacter1
            // 
            this.lblCharacter1.AutoSize = true;
            this.lblCharacter1.Location = new System.Drawing.Point(71, 23);
            this.lblCharacter1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharacter1.Name = "lblCharacter1";
            this.lblCharacter1.Size = new System.Drawing.Size(25, 13);
            this.lblCharacter1.TabIndex = 2;
            this.lblCharacter1.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Skin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Character:";
            // 
            // grpPlayer2
            // 
            this.grpPlayer2.Controls.Add(this.lblSkinIndex2);
            this.grpPlayer2.Controls.Add(this.lblSkinDesc2);
            this.grpPlayer2.Controls.Add(this.lblGames2);
            this.grpPlayer2.Controls.Add(this.label5);
            this.grpPlayer2.Controls.Add(this.lblCharacter2);
            this.grpPlayer2.Controls.Add(this.label8);
            this.grpPlayer2.Controls.Add(this.label9);
            this.grpPlayer2.Location = new System.Drawing.Point(258, 27);
            this.grpPlayer2.Margin = new System.Windows.Forms.Padding(2);
            this.grpPlayer2.Name = "grpPlayer2";
            this.grpPlayer2.Padding = new System.Windows.Forms.Padding(2);
            this.grpPlayer2.Size = new System.Drawing.Size(218, 96);
            this.grpPlayer2.TabIndex = 4;
            this.grpPlayer2.TabStop = false;
            this.grpPlayer2.Text = "Player 2";
            // 
            // lblSkinIndex2
            // 
            this.lblSkinIndex2.AutoSize = true;
            this.lblSkinIndex2.Location = new System.Drawing.Point(71, 51);
            this.lblSkinIndex2.Name = "lblSkinIndex2";
            this.lblSkinIndex2.Size = new System.Drawing.Size(25, 13);
            this.lblSkinIndex2.TabIndex = 8;
            this.lblSkinIndex2.Text = "???";
            // 
            // lblSkinDesc2
            // 
            this.lblSkinDesc2.AutoSize = true;
            this.lblSkinDesc2.Location = new System.Drawing.Point(71, 37);
            this.lblSkinDesc2.Name = "lblSkinDesc2";
            this.lblSkinDesc2.Size = new System.Drawing.Size(25, 13);
            this.lblSkinDesc2.TabIndex = 7;
            this.lblSkinDesc2.Text = "???";
            // 
            // lblGames2
            // 
            this.lblGames2.AutoSize = true;
            this.lblGames2.Location = new System.Drawing.Point(71, 65);
            this.lblGames2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGames2.Name = "lblGames2";
            this.lblGames2.Size = new System.Drawing.Size(25, 13);
            this.lblGames2.TabIndex = 6;
            this.lblGames2.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Games:";
            // 
            // lblCharacter2
            // 
            this.lblCharacter2.AutoSize = true;
            this.lblCharacter2.Location = new System.Drawing.Point(71, 23);
            this.lblCharacter2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCharacter2.Name = "lblCharacter2";
            this.lblCharacter2.Size = new System.Drawing.Size(25, 13);
            this.lblCharacter2.TabIndex = 2;
            this.lblCharacter2.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 37);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Skin:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Character:";
            // 
            // grpMisc
            // 
            this.grpMisc.Controls.Add(this.lblInMatch);
            this.grpMisc.Controls.Add(this.lblBestOf);
            this.grpMisc.Controls.Add(this.label12);
            this.grpMisc.Controls.Add(this.label13);
            this.grpMisc.Location = new System.Drawing.Point(28, 127);
            this.grpMisc.Margin = new System.Windows.Forms.Padding(2);
            this.grpMisc.Name = "grpMisc";
            this.grpMisc.Padding = new System.Windows.Forms.Padding(2);
            this.grpMisc.Size = new System.Drawing.Size(218, 55);
            this.grpMisc.TabIndex = 5;
            this.grpMisc.TabStop = false;
            this.grpMisc.Text = "Match";
            // 
            // lblInMatch
            // 
            this.lblInMatch.AutoSize = true;
            this.lblInMatch.Location = new System.Drawing.Point(71, 35);
            this.lblInMatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInMatch.Name = "lblInMatch";
            this.lblInMatch.Size = new System.Drawing.Size(25, 13);
            this.lblInMatch.TabIndex = 3;
            this.lblInMatch.Text = "???";
            // 
            // lblBestOf
            // 
            this.lblBestOf.AutoSize = true;
            this.lblBestOf.Location = new System.Drawing.Point(71, 17);
            this.lblBestOf.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBestOf.Name = "lblBestOf";
            this.lblBestOf.Size = new System.Drawing.Size(25, 13);
            this.lblBestOf.TabIndex = 2;
            this.lblBestOf.Text = "???";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "In Match:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Best Of:";
            // 
            // txtSaveLocation
            // 
            this.txtSaveLocation.Location = new System.Drawing.Point(28, 206);
            this.txtSaveLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaveLocation.Name = "txtSaveLocation";
            this.txtSaveLocation.ReadOnly = true;
            this.txtSaveLocation.Size = new System.Drawing.Size(410, 20);
            this.txtSaveLocation.TabIndex = 6;
            this.txtSaveLocation.TabStop = false;
            // 
            // btnSaveDirectory
            // 
            this.btnSaveDirectory.Location = new System.Drawing.Point(443, 207);
            this.btnSaveDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveDirectory.Name = "btnSaveDirectory";
            this.btnSaveDirectory.Size = new System.Drawing.Size(32, 19);
            this.btnSaveDirectory.TabIndex = 7;
            this.btnSaveDirectory.Text = "...";
            this.btnSaveDirectory.UseVisualStyleBackColor = true;
            this.btnSaveDirectory.Click += new System.EventHandler(this.btnSaveDirectory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "RoAState.json Save Location";
            // 
            // chkOverrideMD5
            // 
            this.chkOverrideMD5.AutoSize = true;
            this.chkOverrideMD5.Location = new System.Drawing.Point(28, 231);
            this.chkOverrideMD5.Name = "chkOverrideMD5";
            this.chkOverrideMD5.Size = new System.Drawing.Size(178, 17);
            this.chkOverrideMD5.TabIndex = 9;
            this.chkOverrideMD5.Text = "Override MD5-assigned Pointers";
            this.chkOverrideMD5.UseVisualStyleBackColor = true;
            this.chkOverrideMD5.CheckedChanged += new System.EventHandler(this.chkOverrideMD5_CheckedChanged);
            // 
            // cmbMD5Override
            // 
            this.cmbMD5Override.Enabled = false;
            this.cmbMD5Override.FormattingEnabled = true;
            this.cmbMD5Override.Location = new System.Drawing.Point(28, 250);
            this.cmbMD5Override.Name = "cmbMD5Override";
            this.cmbMD5Override.Size = new System.Drawing.Size(410, 21);
            this.cmbMD5Override.TabIndex = 10;
            this.cmbMD5Override.SelectedIndexChanged += new System.EventHandler(this.cmbMD5Override_SelectedIndexChanged);
            // 
            // frmRockerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 281);
            this.Controls.Add(this.cmbMD5Override);
            this.Controls.Add(this.chkOverrideMD5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSaveDirectory);
            this.Controls.Add(this.txtSaveLocation);
            this.Controls.Add(this.grpMisc);
            this.Controls.Add(this.grpPlayer2);
            this.Controls.Add(this.grpPlayer1);
            this.Controls.Add(this.lblProcessStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRockerVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(514, 320);
            this.MinimumSize = new System.Drawing.Size(514, 320);
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
        private System.Windows.Forms.Label lblCharacter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPlayer2;
        private System.Windows.Forms.Label lblCharacter2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpMisc;
        private System.Windows.Forms.Label lblInMatch;
        private System.Windows.Forms.Label lblBestOf;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGames1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGames2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSaveLocation;
        private System.Windows.Forms.Button btnSaveDirectory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSkinDesc1;
        private System.Windows.Forms.Label lblSkinDesc2;
        private System.Windows.Forms.Label lblSkinIndex1;
        private System.Windows.Forms.Label lblSkinIndex2;
        private System.Windows.Forms.CheckBox chkOverrideMD5;
        private System.Windows.Forms.ComboBox cmbMD5Override;
    }
}

