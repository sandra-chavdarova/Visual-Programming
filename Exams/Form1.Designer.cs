namespace Exams
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
            this.lbExams = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbComment1 = new System.Windows.Forms.TextBox();
            this.tbComment2 = new System.Windows.Forms.TextBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.nudPoints1 = new System.Windows.Forms.NumericUpDown();
            this.nudPoints2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExams
            // 
            this.lbExams.FormattingEnabled = true;
            this.lbExams.ItemHeight = 16;
            this.lbExams.Location = new System.Drawing.Point(40, 53);
            this.lbExams.Name = "lbExams";
            this.lbExams.Size = new System.Drawing.Size(353, 388);
            this.lbExams.TabIndex = 0;
            this.lbExams.SelectedIndexChanged += new System.EventHandler(this.lbExams_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(40, 466);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(353, 30);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Додај испит";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(40, 528);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(353, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Избриши испит";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbComment1
            // 
            this.tbComment1.Location = new System.Drawing.Point(446, 53);
            this.tbComment1.Multiline = true;
            this.tbComment1.Name = "tbComment1";
            this.tbComment1.Size = new System.Drawing.Size(306, 126);
            this.tbComment1.TabIndex = 3;
            // 
            // tbComment2
            // 
            this.tbComment2.Location = new System.Drawing.Point(446, 315);
            this.tbComment2.Multiline = true;
            this.tbComment2.Name = "tbComment2";
            this.tbComment2.Size = new System.Drawing.Size(306, 126);
            this.tbComment2.TabIndex = 4;
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(629, 227);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(123, 30);
            this.btnSave1.TabIndex = 5;
            this.btnSave1.Text = "Зачувај";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(629, 491);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(123, 30);
            this.btnSave2.TabIndex = 6;
            this.btnSave2.Text = "Зачувај";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // nudPoints1
            // 
            this.nudPoints1.Location = new System.Drawing.Point(446, 232);
            this.nudPoints1.Name = "nudPoints1";
            this.nudPoints1.Size = new System.Drawing.Size(157, 22);
            this.nudPoints1.TabIndex = 7;
            // 
            // nudPoints2
            // 
            this.nudPoints2.Location = new System.Drawing.Point(446, 499);
            this.nudPoints2.Name = "nudPoints2";
            this.nudPoints2.Size = new System.Drawing.Size(157, 22);
            this.nudPoints2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Испити";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Прва задача";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Втора задача";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Поени";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Поени";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 591);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPoints2);
            this.Controls.Add(this.nudPoints1);
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.btnSave1);
            this.Controls.Add(this.tbComment2);
            this.Controls.Add(this.tbComment1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lbExams);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbExams;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbComment1;
        private System.Windows.Forms.TextBox tbComment2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.NumericUpDown nudPoints1;
        private System.Windows.Forms.NumericUpDown nudPoints2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

