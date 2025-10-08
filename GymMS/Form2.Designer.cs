namespace GymMS
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
            panel1 = new Panel();
            coachesbtn = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            membersbtn = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            packagesbtn = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            paymentsbtn = new Button();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            exitbtn = new Button();
            logoutbtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 45, 41);
            panel1.Controls.Add(coachesbtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(41, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 397);
            panel1.TabIndex = 0;
            // 
            // coachesbtn
            // 
            coachesbtn.BackColor = Color.Transparent;
            coachesbtn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coachesbtn.Location = new Point(69, 319);
            coachesbtn.Name = "coachesbtn";
            coachesbtn.Size = new Size(94, 29);
            coachesbtn.TabIndex = 4;
            coachesbtn.Text = "Next";
            coachesbtn.UseVisualStyleBackColor = false;
            coachesbtn.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Berlin Sans FB Demi", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(47, 203);
            label1.Name = "label1";
            label1.Size = new Size(152, 43);
            label1.TabIndex = 1;
            label1.Text = "Coaches";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(membersbtn);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(313, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 397);
            panel2.TabIndex = 1;
            // 
            // membersbtn
            // 
            membersbtn.BackColor = Color.Transparent;
            membersbtn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            membersbtn.Location = new Point(68, 319);
            membersbtn.Name = "membersbtn";
            membersbtn.Size = new Size(94, 29);
            membersbtn.TabIndex = 5;
            membersbtn.Text = "Next";
            membersbtn.UseVisualStyleBackColor = false;
            membersbtn.Click += membersbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Berlin Sans FB Demi", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(104, 142, 219);
            label2.Location = new Point(40, 203);
            label2.Name = "label2";
            label2.Size = new Size(168, 43);
            label2.TabIndex = 2;
            label2.Text = "Members";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 163);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(28, 28, 28);
            panel3.Controls.Add(packagesbtn);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(587, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 397);
            panel3.TabIndex = 1;
            // 
            // packagesbtn
            // 
            packagesbtn.BackColor = Color.Transparent;
            packagesbtn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            packagesbtn.Location = new Point(77, 319);
            packagesbtn.Name = "packagesbtn";
            packagesbtn.Size = new Size(94, 29);
            packagesbtn.TabIndex = 6;
            packagesbtn.Text = "Next";
            packagesbtn.UseVisualStyleBackColor = false;
            packagesbtn.Click += packagesbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Berlin Sans FB Demi", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orange;
            label3.Location = new Point(42, 203);
            label3.Name = "label3";
            label3.Size = new Size(177, 43);
            label3.TabIndex = 3;
            label3.Text = "Packages";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(219, 186);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(226, 151, 220);
            panel4.Controls.Add(paymentsbtn);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(859, 75);
            panel4.Name = "panel4";
            panel4.Size = new Size(249, 397);
            panel4.TabIndex = 1;
            // 
            // paymentsbtn
            // 
            paymentsbtn.BackColor = Color.Transparent;
            paymentsbtn.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paymentsbtn.Location = new Point(79, 320);
            paymentsbtn.Name = "paymentsbtn";
            paymentsbtn.Size = new Size(94, 29);
            paymentsbtn.TabIndex = 7;
            paymentsbtn.Text = "Next";
            paymentsbtn.UseVisualStyleBackColor = false;
            paymentsbtn.Click += paymentsbtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Berlin Sans FB Demi", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.WindowText;
            label4.Location = new Point(40, 204);
            label4.Name = "label4";
            label4.Size = new Size(184, 43);
            label4.TabIndex = 4;
            label4.Text = "Payments";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 15);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(219, 186);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.Crimson;
            exitbtn.FlatStyle = FlatStyle.Popup;
            exitbtn.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitbtn.ForeColor = Color.White;
            exitbtn.Location = new Point(110, 497);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(94, 34);
            exitbtn.TabIndex = 6;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += button5_Click;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = Color.Crimson;
            logoutbtn.FlatStyle = FlatStyle.Popup;
            logoutbtn.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutbtn.ForeColor = Color.White;
            logoutbtn.Location = new Point(110, 538);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(94, 34);
            logoutbtn.TabIndex = 7;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += button6_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 632);
            Controls.Add(logoutbtn);
            Controls.Add(exitbtn);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button coachesbtn;
        private Button membersbtn;
        private Button packagesbtn;
        private Button paymentsbtn;
        private Button exitbtn;
        private Button logoutbtn;
    }
}