namespace ElectroCalc
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            datePeriod = new Label();
            days = new Label();
            unit1 = new Label();
            unit2 = new Label();
            unit3 = new Label();
            unit4 = new Label();
            unit5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(212, 188, 12);
            label1.Location = new Point(58, 67);
            label1.Name = "label1";
            label1.Size = new Size(318, 32);
            label1.TabIndex = 0;
            label1.Text = "Electricity Cost Breakdown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(70, 121, 213);
            label2.Location = new Point(58, 187);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Period";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(70, 121, 213);
            label3.Location = new Point(58, 277);
            label3.Name = "label3";
            label3.Size = new Size(93, 40);
            label3.TabIndex = 2;
            label3.Text = "Import \r\nCharge /LKR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(188, 183);
            label4.Name = "label4";
            label4.Size = new Size(176, 20);
            label4.TabIndex = 3;
            label4.Text = "Tariff Scheme: D-2024/07";
            // 
            // datePeriod
            // 
            datePeriod.AutoSize = true;
            datePeriod.BackColor = Color.Transparent;
            datePeriod.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datePeriod.Location = new Point(188, 203);
            datePeriod.Name = "datePeriod";
            datePeriod.Size = new Size(174, 20);
            datePeriod.TabIndex = 4;
            datePeriod.Text = "2024-08-14 - 2024-08-13";
            // 
            // days
            // 
            days.AutoSize = true;
            days.BackColor = Color.Transparent;
            days.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            days.ForeColor = Color.FromArgb(70, 121, 213);
            days.Location = new Point(189, 232);
            days.Name = "days";
            days.Size = new Size(56, 20);
            days.TabIndex = 5;
            days.Text = "5 Days";
            // 
            // unit1
            // 
            unit1.AutoSize = true;
            unit1.BackColor = Color.Transparent;
            unit1.Location = new Point(189, 280);
            unit1.Name = "unit1";
            unit1.Size = new Size(176, 20);
            unit1.TabIndex = 6;
            unit1.Text = "Tariff Scheme: D-2024/07";
            // 
            // unit2
            // 
            unit2.AutoSize = true;
            unit2.BackColor = Color.Transparent;
            unit2.Location = new Point(189, 300);
            unit2.Name = "unit2";
            unit2.Size = new Size(176, 20);
            unit2.TabIndex = 7;
            unit2.Text = "Tariff Scheme: D-2024/07";
            // 
            // unit3
            // 
            unit3.AutoSize = true;
            unit3.BackColor = Color.Transparent;
            unit3.Location = new Point(189, 320);
            unit3.Name = "unit3";
            unit3.Size = new Size(176, 20);
            unit3.TabIndex = 8;
            unit3.Text = "Tariff Scheme: D-2024/07";
            // 
            // unit4
            // 
            unit4.AutoSize = true;
            unit4.BackColor = Color.Transparent;
            unit4.Location = new Point(189, 340);
            unit4.Name = "unit4";
            unit4.Size = new Size(176, 20);
            unit4.TabIndex = 9;
            unit4.Text = "Tariff Scheme: D-2024/07";
            // 
            // unit5
            // 
            unit5.AutoSize = true;
            unit5.BackColor = Color.Transparent;
            unit5.Location = new Point(189, 360);
            unit5.Name = "unit5";
            unit5.Size = new Size(176, 20);
            unit5.TabIndex = 10;
            unit5.Text = "Tariff Scheme: D-2024/07";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 703);
            Controls.Add(unit5);
            Controls.Add(unit4);
            Controls.Add(unit3);
            Controls.Add(unit2);
            Controls.Add(unit1);
            Controls.Add(days);
            Controls.Add(datePeriod);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(450, 750);
            MinimumSize = new Size(450, 750);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectroCal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label datePeriod;
        private Label days;
        private Label unit1;
        private Label unit2;
        private Label unit3;
        private Label unit4;
        private Label unit5;
    }
}