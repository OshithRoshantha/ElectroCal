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
            userName = new Label();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(212, 188, 12);
            label2.Location = new Point(43, 25);
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
            // userName
            // 
            userName.AutoSize = true;
            userName.BackColor = Color.Transparent;
            userName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            userName.ForeColor = Color.FromArgb(212, 188, 12);
            userName.Location = new Point(40, 43);
            userName.Name = "userName";
            userName.Size = new Size(0, 35);
            userName.TabIndex = 31;
            userName.Click += userName_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(149, 36, 75);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(48, 637);
            button2.Name = "button2";
            button2.Size = new Size(112, 37);
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
            button1.Location = new Point(175, 637);
            button1.Name = "button1";
            button1.Size = new Size(86, 37);
            button1.TabIndex = 40;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(45, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(336, 25);
            textBox2.TabIndex = 47;
            textBox2.Click += textBox2_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(46, 277);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(336, 25);
            textBox3.TabIndex = 48;
            textBox3.Click += textBox3_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(46, 258);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 49;
            monthCalendar1.Visible = false;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(46, 305);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 50;
            monthCalendar2.Visible = false;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe UI", 8F);
            radioButton3.Location = new Point(157, 433);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(132, 23);
            radioButton3.TabIndex = 52;
            radioButton3.TabStop = true;
            radioButton3.Text = "Number of Units";
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe UI", 8F);
            radioButton4.Location = new Point(46, 433);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(85, 23);
            radioButton4.TabIndex = 51;
            radioButton4.TabStop = true;
            radioButton4.Text = "Readings";
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(47, 526);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(336, 25);
            textBox4.TabIndex = 58;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(46, 479);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(336, 25);
            textBox5.TabIndex = 57;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(46, 574);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(336, 25);
            textBox6.TabIndex = 56;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label10.Location = new Point(44, 554);
            label10.Name = "label10";
            label10.Size = new Size(81, 19);
            label10.TabIndex = 55;
            label10.Text = "Units /kWh";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label11.Location = new Point(43, 507);
            label11.Name = "label11";
            label11.Size = new Size(152, 19);
            label11.TabIndex = 54;
            label11.Text = "Current Meter Reading";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label12.Location = new Point(41, 460);
            label12.Name = "label12";
            label12.Size = new Size(158, 19);
            label12.TabIndex = 53;
            label12.Text = "Previous Meter Reading";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI", 8F);
            radioButton2.Location = new Point(110, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(130, 23);
            radioButton2.TabIndex = 42;
            radioButton2.TabStop = true;
            radioButton2.Text = "Number of Days";
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Segoe UI", 8F);
            radioButton1.Location = new Point(0, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(88, 23);
            radioButton1.TabIndex = 41;
            radioButton1.TabStop = true;
            radioButton1.Text = "Pick Days";
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(47, 181);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 27);
            panel1.TabIndex = 60;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(149, 36, 75);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 5F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(212, 188, 12);
            button4.Location = new Point(45, 78);
            button4.Name = "button4";
            button4.Size = new Size(85, 25);
            button4.TabIndex = 62;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(70, 121, 204);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(274, 637);
            button3.Name = "button3";
            button3.Size = new Size(109, 37);
            button3.TabIndex = 63;
            button3.Text = "Bill History";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 703);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(textBox4);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(userName);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            MaximumSize = new Size(450, 750);
            MinimumSize = new Size(450, 750);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectroCal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label userName;
        private Button button2;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label10;
        private Label label11;
        private Label label12;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel1;
        private Button button4;
        private Button button3;
    }
}