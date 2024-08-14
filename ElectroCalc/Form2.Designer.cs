namespace ElectroCalc
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            button2 = new Button();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(149, 36, 75);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(36, 36);
            button1.TabIndex = 8;
            button1.Text = "<";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            label2.Location = new Point(98, 141);
            label2.Name = "label2";
            label2.Size = new Size(239, 41);
            label2.TabIndex = 24;
            label2.Text = "Get started free.";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(71, 304);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(296, 34);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(71, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 34);
            textBox1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(71, 273);
            label5.Name = "label5";
            label5.Size = new Size(178, 23);
            label5.TabIndex = 26;
            label5.Text = "NIC/Passport Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 197);
            label4.Name = "label4";
            label4.Size = new Size(147, 23);
            label4.TabIndex = 25;
            label4.Text = "Name with Initials";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F);
            textBox3.Location = new Point(71, 470);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '•';
            textBox3.Size = new Size(296, 34);
            textBox3.TabIndex = 34;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 12F);
            textBox4.Location = new Point(71, 379);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(296, 34);
            textBox4.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 439);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 32;
            label1.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 348);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 31;
            label3.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Light", 7F);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(70, 416);
            label6.Name = "label6";
            label6.Size = new Size(191, 15);
            label6.TabIndex = 35;
            label6.Text = "Your email will also be your username";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI", 12F);
            textBox5.Location = new Point(70, 544);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '•';
            textBox5.Size = new Size(296, 34);
            textBox5.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(70, 513);
            label7.Name = "label7";
            label7.Size = new Size(139, 23);
            label7.TabIndex = 36;
            label7.Text = "Repeat password";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(149, 36, 75);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(67, 609);
            button2.Name = "button2";
            button2.Size = new Size(296, 55);
            button2.TabIndex = 38;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // sqlDataAdapter1
            // 
            sqlDataAdapter1.RowUpdated += sqlDataAdapter1_RowUpdated;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(432, 703);
            Controls.Add(button2);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            MaximumSize = new Size(450, 750);
            MinimumSize = new Size(450, 750);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElectroCal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label3;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
    }
}