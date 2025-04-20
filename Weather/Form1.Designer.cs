namespace Weather
{
    partial class formWeather
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbWeather = new ListBox();
            label1 = new Label();
            btnAddDay = new Button();
            btnDeleteDay = new Button();
            tbDate = new TextBox();
            label2 = new Label();
            nudMaxTemperature = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nudMinTemperature = new NumericUpDown();
            label6 = new Label();
            tbDayMaxTemperature = new TextBox();
            label7 = new Label();
            tbDayMinTemperature = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudMaxTemperature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinTemperature).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lbWeather
            // 
            lbWeather.FormattingEnabled = true;
            lbWeather.Location = new Point(25, 64);
            lbWeather.Name = "lbWeather";
            lbWeather.Size = new Size(405, 384);
            lbWeather.TabIndex = 1;
            lbWeather.SelectedIndexChanged += lbWeather_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 2;
            label1.Text = "Прогноза";
            // 
            // btnAddDay
            // 
            btnAddDay.Location = new Point(25, 475);
            btnAddDay.Name = "btnAddDay";
            btnAddDay.Size = new Size(172, 29);
            btnAddDay.TabIndex = 3;
            btnAddDay.Text = "Додај ден";
            btnAddDay.UseVisualStyleBackColor = true;
            btnAddDay.Click += btnAddDay_Click;
            // 
            // btnDeleteDay
            // 
            btnDeleteDay.Location = new Point(258, 475);
            btnDeleteDay.Name = "btnDeleteDay";
            btnDeleteDay.Size = new Size(172, 29);
            btnDeleteDay.TabIndex = 4;
            btnDeleteDay.Text = "Избриши ден";
            btnDeleteDay.UseVisualStyleBackColor = true;
            btnDeleteDay.Click += btnDeleteDay_Click;
            // 
            // tbDate
            // 
            tbDate.Enabled = false;
            tbDate.Location = new Point(667, 64);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(239, 27);
            tbDate.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(585, 67);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 6;
            label2.Text = "Датум:";
            // 
            // nudMaxTemperature
            // 
            nudMaxTemperature.Location = new Point(585, 165);
            nudMaxTemperature.Name = "nudMaxTemperature";
            nudMaxTemperature.Size = new Size(321, 27);
            nudMaxTemperature.TabIndex = 7;
            nudMaxTemperature.ValueChanged += nudMaxTemperature_ValueChanged;
            nudMaxTemperature.Validating += nudMaxTemperature_Validating;
            // 
            // label3
            // 
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(585, 142);
            label4.Name = "label4";
            label4.Size = new Size(193, 20);
            label4.TabIndex = 8;
            label4.Text = "Максимална температура:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(585, 245);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 10;
            label5.Text = "Минимална температура:";
            // 
            // nudMinTemperature
            // 
            nudMinTemperature.Location = new Point(585, 268);
            nudMinTemperature.Minimum = new decimal(new int[] { 30, 0, 0, int.MinValue });
            nudMinTemperature.Name = "nudMinTemperature";
            nudMinTemperature.Size = new Size(321, 27);
            nudMinTemperature.TabIndex = 9;
            nudMinTemperature.ValueChanged += nudMinTemperature_ValueChanged;
            nudMinTemperature.Validating += nudMinTemperature_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(585, 344);
            label6.Name = "label6";
            label6.Size = new Size(317, 20);
            label6.TabIndex = 12;
            label6.Text = "Ден со најголема максимална температура:";
            // 
            // tbDayMaxTemperature
            // 
            tbDayMaxTemperature.Enabled = false;
            tbDayMaxTemperature.Location = new Point(585, 374);
            tbDayMaxTemperature.Name = "tbDayMaxTemperature";
            tbDayMaxTemperature.Size = new Size(321, 27);
            tbDayMaxTemperature.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(585, 445);
            label7.Name = "label7";
            label7.Size = new Size(298, 20);
            label7.TabIndex = 14;
            label7.Text = "Ден со најмала минимална температура:";
            // 
            // tbDayMinTemperature
            // 
            tbDayMinTemperature.Enabled = false;
            tbDayMinTemperature.Location = new Point(585, 475);
            tbDayMinTemperature.Name = "tbDayMinTemperature";
            tbDayMinTemperature.Size = new Size(321, 27);
            tbDayMinTemperature.TabIndex = 13;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // formWeather
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(960, 566);
            Controls.Add(label7);
            Controls.Add(tbDayMinTemperature);
            Controls.Add(label6);
            Controls.Add(tbDayMaxTemperature);
            Controls.Add(label5);
            Controls.Add(nudMinTemperature);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nudMaxTemperature);
            Controls.Add(label2);
            Controls.Add(tbDate);
            Controls.Add(btnDeleteDay);
            Controls.Add(btnAddDay);
            Controls.Add(label1);
            Controls.Add(lbWeather);
            Name = "formWeather";
            Text = "Временска прогноза";
            ((System.ComponentModel.ISupportInitialize)nudMaxTemperature).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinTemperature).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbWeather;
        private Label label1;
        private Button btnAddDay;
        private Button btnDeleteDay;
        private TextBox tbDate;
        private Label label2;
        private NumericUpDown nudMaxTemperature;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudMinTemperature;
        private Label label6;
        private TextBox tbDayMaxTemperature;
        private Label label7;
        private TextBox tbDayMinTemperature;
        private ErrorProvider errorProvider1;
    }
}
