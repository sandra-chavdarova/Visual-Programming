namespace Weather
{
    partial class AddDay
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
            cbDay = new ComboBox();
            cbMonth = new ComboBox();
            btnCancel = new Button();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cbDay
            // 
            cbDay.FormattingEnabled = true;
            cbDay.Location = new Point(41, 68);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(151, 28);
            cbDay.TabIndex = 0;
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Location = new Point(254, 68);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(151, 28);
            cbMonth.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(41, 131);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 29);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Откажи";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(254, 131);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(151, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Внеси";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 4;
            label1.Text = "Ден:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 45);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 5;
            label2.Text = "Месец:";
            // 
            // AddDay
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 209);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            Controls.Add(cbMonth);
            Controls.Add(cbDay);
            Name = "AddDay";
            Text = "Додај ден";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbDay;
        private ComboBox cbMonth;
        private Button btnCancel;
        private Button btnAdd;
        private Label label1;
        private Label label2;
    }
}