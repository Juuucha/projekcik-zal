namespace Za_malo_za_duzo
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNewGame = new System.Windows.Forms.Button();
            this.buttonStartPause = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.labelproby = new System.Windows.Forms.Label();
            this.labelLiczba = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.Komentarz = new System.Windows.Forms.Label();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonNewGame
            // 
            this.buttonNewGame.Location = new System.Drawing.Point(30, 40);
            this.buttonNewGame.Name = "buttonNewGame";
            this.buttonNewGame.Size = new System.Drawing.Size(126, 51);
            this.buttonNewGame.TabIndex = 0;
            this.buttonNewGame.Text = "New Game";
            this.buttonNewGame.UseVisualStyleBackColor = true;
            this.buttonNewGame.Click += new System.EventHandler(this.buttonNewGame_Click);
            // 
            // buttonStartPause
            // 
            this.buttonStartPause.Enabled = false;
            this.buttonStartPause.Location = new System.Drawing.Point(224, 40);
            this.buttonStartPause.Name = "buttonStartPause";
            this.buttonStartPause.Size = new System.Drawing.Size(145, 51);
            this.buttonStartPause.TabIndex = 1;
            this.buttonStartPause.Text = "Pause";
            this.buttonStartPause.UseVisualStyleBackColor = true;
            this.buttonStartPause.Click += new System.EventHandler(this.buttonStartPause_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(127, 181);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(145, 35);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Generate Number";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Visible = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(30, 423);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(140, 58);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.Text = "History";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(224, 423);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(145, 58);
            this.buttonInfo.TabIndex = 4;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Enabled = false;
            this.buttonCheck.Location = new System.Drawing.Point(224, 247);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(145, 44);
            this.buttonCheck.TabIndex = 5;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Visible = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(30, 134);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 22);
            this.textBoxOd.TabIndex = 6;
            this.textBoxOd.Text = "Number From";
            this.textBoxOd.Visible = false;
            this.textBoxOd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxOd_MouseClick);
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(269, 134);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 22);
            this.textBoxDo.TabIndex = 7;
            this.textBoxDo.Text = "Number To";
            this.textBoxDo.Visible = false;
            this.textBoxDo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxDo_MouseClick);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Enabled = false;
            this.textBoxNumber.Location = new System.Drawing.Point(30, 247);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumber.TabIndex = 8;
            this.textBoxNumber.Text = "Guess!";
            this.textBoxNumber.Visible = false;
            this.textBoxNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxNumber_MouseClick);
            // 
            // labelproby
            // 
            this.labelproby.AutoSize = true;
            this.labelproby.Location = new System.Drawing.Point(30, 346);
            this.labelproby.Name = "labelproby";
            this.labelproby.Size = new System.Drawing.Size(113, 17);
            this.labelproby.TabIndex = 9;
            this.labelproby.Text = "Number of tries: ";
            this.labelproby.Visible = false;
            // 
            // labelLiczba
            // 
            this.labelLiczba.AutoSize = true;
            this.labelLiczba.Location = new System.Drawing.Point(30, 327);
            this.labelLiczba.Name = "labelLiczba";
            this.labelLiczba.Size = new System.Drawing.Size(138, 17);
            this.labelLiczba.TabIndex = 10;
            this.labelLiczba.Text = "Generated Number: ";
            this.labelLiczba.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(30, 373);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(47, 17);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "Time: ";
            this.labelTime.Visible = false;
            // 
            // Komentarz
            // 
            this.Komentarz.AutoSize = true;
            this.Komentarz.Location = new System.Drawing.Point(30, 274);
            this.Komentarz.Name = "Komentarz";
            this.Komentarz.Size = new System.Drawing.Size(76, 17);
            this.Komentarz.TabIndex = 12;
            this.Komentarz.Text = "Komentarz";
            this.Komentarz.Visible = false;
            // 
            // timerGame
            // 
            this.timerGame.Interval = 1000;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 515);
            this.Controls.Add(this.Komentarz);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelLiczba);
            this.Controls.Add(this.labelproby);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxDo);
            this.Controls.Add(this.textBoxOd);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonStartPause);
            this.Controls.Add(this.buttonNewGame);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.Button buttonStartPause;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label labelproby;
        private System.Windows.Forms.Label labelLiczba;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label Komentarz;
        private System.Windows.Forms.Timer timerGame;
    }
}

