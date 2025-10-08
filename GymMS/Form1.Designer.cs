namespace GymMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            loginbtn = new Button();
            exitbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(171, 270);
            label1.Name = "label1";
            label1.Size = new Size(108, 26);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 310);
            label2.Name = "label2";
            label2.Size = new Size(103, 26);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(285, 272);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(285, 305);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Crimson;
            loginbtn.FlatStyle = FlatStyle.Popup;
            loginbtn.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(349, 356);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(94, 34);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "Enter";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += button1_Click;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.Crimson;
            exitbtn.FlatStyle = FlatStyle.Popup;
            exitbtn.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitbtn.ForeColor = Color.White;
            exitbtn.Location = new Point(349, 411);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(94, 34);
            exitbtn.TabIndex = 5;
            exitbtn.Text = "Exit";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1233, 652);
            Controls.Add(exitbtn);
            Controls.Add(loginbtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button loginbtn;
        private Button exitbtn;
    }
}
