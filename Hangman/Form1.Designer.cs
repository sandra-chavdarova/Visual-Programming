namespace Hangman
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
            this.components = new System.ComponentModel.Container();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbTrialsLeft = new System.Windows.Forms.ProgressBar();
            this.pbTimeLeft = new System.Windows.Forms.ProgressBar();
            this.tbGuessedLetters = new System.Windows.Forms.TextBox();
            this.lbWord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetter.Location = new System.Drawing.Point(54, 183);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(105, 61);
            this.tbLetter.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(190, 183);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(101, 61);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(667, 33);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(91, 36);
            this.lbTimer.TabIndex = 2;
            this.lbTimer.Text = "02:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbTrialsLeft
            // 
            this.pbTrialsLeft.Location = new System.Drawing.Point(54, 362);
            this.pbTrialsLeft.Name = "pbTrialsLeft";
            this.pbTrialsLeft.Size = new System.Drawing.Size(704, 23);
            this.pbTrialsLeft.TabIndex = 3;
            // 
            // pbTimeLeft
            // 
            this.pbTimeLeft.Location = new System.Drawing.Point(54, 427);
            this.pbTimeLeft.Name = "pbTimeLeft";
            this.pbTimeLeft.Size = new System.Drawing.Size(704, 23);
            this.pbTimeLeft.TabIndex = 4;
            // 
            // tbGuessedLetters
            // 
            this.tbGuessedLetters.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGuessedLetters.Location = new System.Drawing.Point(54, 295);
            this.tbGuessedLetters.Name = "tbGuessedLetters";
            this.tbGuessedLetters.Size = new System.Drawing.Size(704, 38);
            this.tbGuessedLetters.TabIndex = 5;
            // 
            // lbWord
            // 
            this.lbWord.AutoSize = true;
            this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWord.Location = new System.Drawing.Point(48, 99);
            this.lbWord.Name = "lbWord";
            this.lbWord.Size = new System.Drawing.Size(104, 32);
            this.lbWord.TabIndex = 6;
            this.lbWord.Text = "lbWord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Погодени букви";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbWord);
            this.Controls.Add(this.tbGuessedLetters);
            this.Controls.Add(this.pbTimeLeft);
            this.Controls.Add(this.pbTrialsLeft);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbLetter);
            this.Name = "Form1";
            this.Text = "Бесилка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbTrialsLeft;
        private System.Windows.Forms.ProgressBar pbTimeLeft;
        private System.Windows.Forms.TextBox tbGuessedLetters;
        private System.Windows.Forms.Label lbWord;
        private System.Windows.Forms.Label label2;
    }
}

