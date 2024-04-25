namespace Plane
{
    partial class Form1
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
            panel1 = new Panel();
            ucakIsik = new PictureBox();
            ucak = new PictureBox();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel6 = new Panel();
            sounds_UserControl1 = new Sounds_UserControl();
            panel7 = new Panel();
            button1 = new Button();
            goon = new Button();
            button3 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ucakIsik).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ucak).BeginInit();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(ucakIsik);
            panel1.Controls.Add(ucak);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 377);
            panel1.TabIndex = 0;
            // 
            // ucakIsik
            // 
            ucakIsik.Image = Resource1.isik;
            ucakIsik.Location = new Point(31, 208);
            ucakIsik.Name = "ucakIsik";
            ucakIsik.Size = new Size(29, 32);
            ucakIsik.SizeMode = PictureBoxSizeMode.StretchImage;
            ucakIsik.TabIndex = 3;
            ucakIsik.TabStop = false;
            // 
            // ucak
            // 
            ucak.Image = Resource1.ucak;
            ucak.Location = new Point(3, 246);
            ucak.Name = "ucak";
            ucak.Size = new Size(83, 128);
            ucak.SizeMode = PictureBoxSizeMode.StretchImage;
            ucak.TabIndex = 2;
            ucak.TabStop = false;
            ucak.Click += pictureBox1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Location = new Point(91, 305);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 72);
            panel5.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(91, 208);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 72);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(91, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 72);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(91, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 72);
            panel2.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(sounds_UserControl1);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(117, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(429, 240);
            panel6.TabIndex = 4;
            // 
            // sounds_UserControl1
            // 
            sounds_UserControl1.Location = new Point(0, 0);
            sounds_UserControl1.Name = "sounds_UserControl1";
            sounds_UserControl1.Size = new Size(429, 300);
            sounds_UserControl1.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Location = new Point(0, 242);
            panel7.Name = "panel7";
            panel7.Size = new Size(429, 135);
            panel7.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(120, 312);
            button1.Name = "button1";
            button1.Size = new Size(426, 65);
            button1.TabIndex = 5;
            button1.Text = "Turn on Lights";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // goon
            // 
            goon.BackColor = Color.Silver;
            goon.FlatAppearance.BorderSize = 0;
            goon.FlatStyle = FlatStyle.Flat;
            goon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goon.Location = new Point(120, 242);
            goon.Name = "goon";
            goon.Size = new Size(202, 64);
            goon.TabIndex = 6;
            goon.Text = "Go on";
            goon.UseVisualStyleBackColor = false;
            goon.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(346, 242);
            button3.Name = "button3";
            button3.Size = new Size(200, 64);
            button3.TabIndex = 7;
            button3.Text = "Go Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 379);
            Controls.Add(button3);
            Controls.Add(goon);
            Controls.Add(button1);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ucakIsik).EndInit();
            ((System.ComponentModel.ISupportInitialize)ucak).EndInit();
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel5;
        private PictureBox ucak;
        private Panel panel4;
        private Panel panel3;
        private PictureBox ucakIsik;
        private Panel panel6;
        private Panel panel7;
        private Button button1;
        private Button goon;
        private Button button3;
        private Sounds_UserControl sounds_UserControl1;
        private System.Windows.Forms.Timer timer1;
    }
}
