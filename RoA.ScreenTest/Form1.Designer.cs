
namespace RoA.ScreenTest
{
    partial class Form1
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnGetCoords = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnCheckMatch = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.txtScreensBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(10, 10);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(140, 72);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "0,0 Color Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnGetCoords
            // 
            this.btnGetCoords.Location = new System.Drawing.Point(168, 10);
            this.btnGetCoords.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetCoords.Name = "btnGetCoords";
            this.btnGetCoords.Size = new System.Drawing.Size(140, 72);
            this.btnGetCoords.TabIndex = 1;
            this.btnGetCoords.Text = "Get 4CFF00 Coords";
            this.btnGetCoords.UseVisualStyleBackColor = true;
            this.btnGetCoords.Click += new System.EventHandler(this.btnGetCoords_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(325, 10);
            this.txtBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox.Size = new System.Drawing.Size(267, 167);
            this.txtBox.TabIndex = 2;
            this.txtBox.WordWrap = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnCheckMatch
            // 
            this.btnCheckMatch.Location = new System.Drawing.Point(168, 86);
            this.btnCheckMatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckMatch.Name = "btnCheckMatch";
            this.btnCheckMatch.Size = new System.Drawing.Size(140, 72);
            this.btnCheckMatch.TabIndex = 3;
            this.btnCheckMatch.Text = "Check Match";
            this.btnCheckMatch.UseVisualStyleBackColor = true;
            this.btnCheckMatch.Click += new System.EventHandler(this.btnCheckMatch_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            // 
            // txtScreensBox
            // 
            this.txtScreensBox.Location = new System.Drawing.Point(325, 181);
            this.txtScreensBox.Margin = new System.Windows.Forms.Padding(2);
            this.txtScreensBox.Multiline = true;
            this.txtScreensBox.Name = "txtScreensBox";
            this.txtScreensBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScreensBox.Size = new System.Drawing.Size(267, 167);
            this.txtScreensBox.TabIndex = 4;
            this.txtScreensBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtScreensBox);
            this.Controls.Add(this.btnCheckMatch);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnGetCoords);
            this.Controls.Add(this.btnTest);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnGetCoords;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnCheckMatch;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.TextBox txtScreensBox;
    }
}

