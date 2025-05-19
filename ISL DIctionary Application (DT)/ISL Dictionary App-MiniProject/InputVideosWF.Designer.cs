namespace CSharp_MiniProject__ISL_Dictionary_
{
    partial class InputVideosWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputVideosWF));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblWN = new System.Windows.Forms.Label();
            this.lblVF = new System.Windows.Forms.Label();
            this.txtWords = new System.Windows.Forms.TextBox();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.axWMP_ISL = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_ISL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(150, 202);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 26);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Upload";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblWN
            // 
            this.lblWN.AutoSize = true;
            this.lblWN.Location = new System.Drawing.Point(9, 16);
            this.lblWN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWN.Name = "lblWN";
            this.lblWN.Size = new System.Drawing.Size(67, 13);
            this.lblWN.TabIndex = 2;
            this.lblWN.Text = "Word Name:";
            // 
            // lblVF
            // 
            this.lblVF.AutoSize = true;
            this.lblVF.Location = new System.Drawing.Point(18, 38);
            this.lblVF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVF.Name = "lblVF";
            this.lblVF.Size = new System.Drawing.Size(56, 13);
            this.lblVF.TabIndex = 3;
            this.lblVF.Text = "Video File:";
            // 
            // txtWords
            // 
            this.txtWords.Location = new System.Drawing.Point(74, 14);
            this.txtWords.Margin = new System.Windows.Forms.Padding(2);
            this.txtWords.Name = "txtWords";
            this.txtWords.Size = new System.Drawing.Size(162, 20);
            this.txtWords.TabIndex = 4;
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.Location = new System.Drawing.Point(74, 38);
            this.lstWords.Margin = new System.Windows.Forms.Padding(2);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(162, 160);
            this.lstWords.TabIndex = 5;
            // 
            // axWMP_ISL
            // 
            this.axWMP_ISL.Enabled = true;
            this.axWMP_ISL.Location = new System.Drawing.Point(250, 16);
            this.axWMP_ISL.Margin = new System.Windows.Forms.Padding(2);
            this.axWMP_ISL.Name = "axWMP_ISL";
            this.axWMP_ISL.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP_ISL.OcxState")));
            this.axWMP_ISL.Size = new System.Drawing.Size(368, 218);
            this.axWMP_ISL.TabIndex = 6;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(74, 202);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(72, 26);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // InputVideosWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 251);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.axWMP_ISL);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.txtWords);
            this.Controls.Add(this.lblVF);
            this.Controls.Add(this.lblWN);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InputVideosWF";
            this.Text = "InputVideosWF";
            ((System.ComponentModel.ISupportInitialize)(this.axWMP_ISL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblWN;
        private System.Windows.Forms.Label lblVF;
        private System.Windows.Forms.TextBox txtWords;
        private System.Windows.Forms.ListBox lstWords;
        private AxWMPLib.AxWindowsMediaPlayer axWMP_ISL;
        private System.Windows.Forms.Button btnPlay;
    }
}