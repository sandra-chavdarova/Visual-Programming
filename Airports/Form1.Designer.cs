namespace WindowsFormsApp1
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
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.tbMostExpensiveDestination = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAverageDestination = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.ItemHeight = 16;
            this.lbDestinations.Location = new System.Drawing.Point(575, 48);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(356, 372);
            this.lbDestinations.TabIndex = 0;
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.ItemHeight = 16;
            this.lbAirports.Location = new System.Drawing.Point(114, 48);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(356, 372);
            this.lbAirports.TabIndex = 1;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.lbAirports.SelectedValueChanged += new System.EventHandler(this.lbAirports_SelectedValueChanged);
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(114, 442);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(356, 37);
            this.btnAddAirport.TabIndex = 2;
            this.btnAddAirport.Text = "Додај аеродром";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(114, 503);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(356, 37);
            this.btnDeleteAirport.TabIndex = 3;
            this.btnDeleteAirport.Text = "Избриши аеродром";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Location = new System.Drawing.Point(114, 565);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(356, 37);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Додај дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // tbMostExpensiveDestination
            // 
            this.tbMostExpensiveDestination.Enabled = false;
            this.tbMostExpensiveDestination.Location = new System.Drawing.Point(575, 474);
            this.tbMostExpensiveDestination.Name = "tbMostExpensiveDestination";
            this.tbMostExpensiveDestination.Size = new System.Drawing.Size(356, 22);
            this.tbMostExpensiveDestination.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Најскапа дестинација";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Просечна должина на дестинациите";
            // 
            // tbAverageDestination
            // 
            this.tbAverageDestination.Enabled = false;
            this.tbAverageDestination.Location = new System.Drawing.Point(575, 551);
            this.tbAverageDestination.Name = "tbAverageDestination";
            this.tbAverageDestination.Size = new System.Drawing.Size(356, 22);
            this.tbAverageDestination.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAverageDestination);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMostExpensiveDestination);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.btnDeleteAirport);
            this.Controls.Add(this.btnAddAirport);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.lbDestinations);
            this.Name = "Form1";
            this.Text = "Airports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.TextBox tbMostExpensiveDestination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAverageDestination;
    }
}

