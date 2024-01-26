namespace ClickyClicks
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
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            minCpsTb = new TextBox();
            maxCpsTb = new TextBox();
            button1 = new Button();
            Random = new System.Windows.Forms.Timer(components);
            randLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(53, 59);
            trackBar1.Maximum = 20;
            trackBar1.Minimum = 6;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(257, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Value = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(53, 110);
            trackBar2.Maximum = 20;
            trackBar2.Minimum = 6;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(257, 45);
            trackBar2.TabIndex = 1;
            trackBar2.Value = 6;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 33);
            label1.TabIndex = 2;
            label1.Text = "ClickyClicks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(7, 64);
            label2.Name = "label2";
            label2.Size = new Size(48, 14);
            label2.TabIndex = 3;
            label2.Text = "MinCps";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(7, 114);
            label3.Name = "label3";
            label3.Size = new Size(51, 14);
            label3.TabIndex = 4;
            label3.Text = "MaxCps";
            // 
            // minCpsTb
            // 
            minCpsTb.BackColor = Color.FromArgb(66, 69, 73);
            minCpsTb.BorderStyle = BorderStyle.FixedSingle;
            minCpsTb.Font = new Font("Microsoft Sans Serif", 15F);
            minCpsTb.ForeColor = Color.White;
            minCpsTb.Location = new Point(316, 53);
            minCpsTb.Name = "minCpsTb";
            minCpsTb.Size = new Size(31, 30);
            minCpsTb.TabIndex = 5;
            // 
            // maxCpsTb
            // 
            maxCpsTb.BackColor = Color.FromArgb(66, 69, 73);
            maxCpsTb.BorderStyle = BorderStyle.FixedSingle;
            maxCpsTb.Font = new Font("Microsoft Sans Serif", 15F);
            maxCpsTb.ForeColor = Color.White;
            maxCpsTb.Location = new Point(316, 103);
            maxCpsTb.Name = "maxCpsTb";
            maxCpsTb.Size = new Size(31, 30);
            maxCpsTb.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(114, 137, 218);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Roboto", 15F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(98, 186);
            button1.Name = "button1";
            button1.Size = new Size(165, 48);
            button1.TabIndex = 7;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.TextChanged += button1_TextChanged;
            button1.Click += button1_Click;
            // 
            // Random
            // 
            Random.Interval = 150;
            Random.Tick += Random_Tick;
            // 
            // randLabel
            // 
            randLabel.AutoSize = true;
            randLabel.Font = new Font("Roboto", 9F);
            randLabel.ForeColor = Color.White;
            randLabel.Location = new Point(159, 158);
            randLabel.Name = "randLabel";
            randLabel.Size = new Size(51, 14);
            randLabel.TabIndex = 8;
            randLabel.Text = "MaxCps";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 36);
            ClientSize = new Size(371, 273);
            Controls.Add(randLabel);
            Controls.Add(button1);
            Controls.Add(maxCpsTb);
            Controls.Add(minCpsTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox minCpsTb;
        private TextBox maxCpsTb;
        private Button button1;
        private System.Windows.Forms.Timer Random;
        private Label randLabel;
    }
}
