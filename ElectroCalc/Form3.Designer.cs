namespace ElectroCalc
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(212, 188, 12);
            label2.Location = new Point(43, 40);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 25;
            label2.Text = "Welcome Back,";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(34, 135);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 27;
            label3.Text = "Period";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 8.5F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(36, 156);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 28;
            label4.Text = "Days";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 8.5F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(38, 402);
            label5.Name = "label5";
            label5.Size = new Size(122, 20);
            label5.TabIndex = 30;
            label5.Text = "Grid to Customer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(36, 381);
            label6.Name = "label6";
            label6.Size = new Size(173, 25);
            label6.TabIndex = 29;
            label6.Text = "Import Units /kWh";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(212, 188, 12);
            label1.Location = new Point(40, 59);
            label1.Name = "label1";
            label1.Size = new Size(106, 35);
            label1.TabIndex = 31;
            label1.Text = "Gimhan";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(70, 121, 204);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(56, 628);
            button2.Name = "button2";
            button2.Size = new Size(151, 51);
            button2.TabIndex = 39;
            button2.Text = "Calculate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(243, 243, 243);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(222, 628);
            button1.Name = "button1";
            button1.Size = new Size(136, 51);
            button1.TabIndex = 40;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 8F);
            radioButton1.Location = new Point(46, 186);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 23);
            radioButton1.TabIndex = 41;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pick Days";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 8F);
            radioButton2.Location = new Point(157, 186);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(130, 23);
            radioButton2.TabIndex = 42;
            radioButton2.TabStop = true;
            radioButton2.Text = "Number of Days";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label7.Location = new Point(40, 211);
            label7.Name = "label7";
            label7.Size = new Size(116, 19);
            label7.TabIndex = 43;
            label7.Text = "Last reading date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label8.Location = new Point(42, 258);
            label8.Name = "label8";
            label8.Size = new Size(138, 19);
            label8.TabIndex = 44;
            label8.Text = "Current reading date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label9.Location = new Point(43, 305);
            label9.Name = "label9";
            label9.Size = new Size(39, 19);
            label9.TabIndex = 45;
            label9.Text = "Days";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(45, 325);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(336, 25);
            textBox1.TabIndex = 46;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(45, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 25);
            textBox2.TabIndex = 47;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(46, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 25);
            textBox3.TabIndex = 48;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(46, 230);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 49;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 703);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximumSize = new Size(450, 750);
            MinimumSize = new Size(450, 750);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectroCalc";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Button button2;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MonthCalendar monthCalendar1;
    }
}