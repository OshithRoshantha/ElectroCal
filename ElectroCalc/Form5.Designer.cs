namespace ElectroCalc
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            userName = new Label();
            panel1 = new Panel();
            bill = new Label();
            chargeOnUnits = new Label();
            units = new Label();
            dateDuration = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(212, 188, 12);
            label1.Location = new Point(41, 62);
            label1.Name = "label1";
            label1.Size = new Size(137, 32);
            label1.TabIndex = 1;
            label1.Text = "Bill history";
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = Color.Transparent;
            userName.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            userName.ForeColor = Color.FromArgb(212, 188, 12);
            userName.Location = new Point(43, 34);
            userName.Name = "userName";
            userName.Size = new Size(0, 28);
            userName.TabIndex = 32;
            userName.Click += userName_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(bill);
            panel1.Controls.Add(chargeOnUnits);
            panel1.Controls.Add(units);
            panel1.Controls.Add(dateDuration);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(31, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 124);
            panel1.TabIndex = 33;
            // 
            // bill
            // 
            bill.AutoSize = true;
            bill.BackColor = Color.Transparent;
            bill.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            bill.Location = new Point(192, 96);
            bill.Name = "bill";
            bill.Size = new Size(76, 18);
            bill.TabIndex = 40;
            bill.Text = "10000.00";
            // 
            // chargeOnUnits
            // 
            chargeOnUnits.AutoSize = true;
            chargeOnUnits.BackColor = Color.Transparent;
            chargeOnUnits.Font = new Font("Microsoft Sans Serif", 8.25F);
            chargeOnUnits.Location = new Point(192, 63);
            chargeOnUnits.Name = "chargeOnUnits";
            chargeOnUnits.Size = new Size(68, 17);
            chargeOnUnits.TabIndex = 39;
            chargeOnUnits.Text = "10000.00";
            // 
            // units
            // 
            units.AutoSize = true;
            units.BackColor = Color.Transparent;
            units.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            units.Location = new Point(192, 34);
            units.Name = "units";
            units.Size = new Size(65, 16);
            units.TabIndex = 38;
            units.Text = "1000 kWh";
            // 
            // dateDuration
            // 
            dateDuration.AutoSize = true;
            dateDuration.BackColor = Color.Transparent;
            dateDuration.Font = new Font("Microsoft Sans Serif", 8.25F);
            dateDuration.Location = new Point(192, 13);
            dateDuration.Name = "dateDuration";
            dateDuration.Size = new Size(165, 17);
            dateDuration.TabIndex = 34;
            dateDuration.Text = "15/07/2024 - 15/08/2024";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(70, 121, 213);
            label4.Location = new Point(20, 30);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 37;
            label4.Text = "Consumed Units";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(253, 57, 149);
            label7.Location = new Point(20, 94);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 36;
            label7.Text = "Monthly Bill /LRK";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.ForeColor = Color.FromArgb(70, 121, 213);
            label3.Location = new Point(20, 61);
            label3.Name = "label3";
            label3.Size = new Size(145, 17);
            label3.TabIndex = 35;
            label3.Text = "Charge on Units /LKR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(70, 121, 213);
            label2.Location = new Point(20, 12);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 34;
            label2.Text = "Period";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(149, 36, 75);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(317, 62);
            button1.Name = "button1";
            button1.Size = new Size(66, 36);
            button1.TabIndex = 42;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 703);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(userName);
            Controls.Add(label1);
            MaximumSize = new Size(450, 750);
            MinimumSize = new Size(450, 750);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectroCal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label userName;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label4;
        private Label units;
        private Label dateDuration;
        private Label chargeOnUnits;
        private Label bill;
        private Button button1;
    }
}