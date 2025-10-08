namespace GymMS
{
    partial class Form3_1
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
            coachdeletetextBox1 = new TextBox();
            coachenterid = new Button();
            SuspendLayout();
            // 
            // coachdeletetextBox1
            // 
            coachdeletetextBox1.Location = new Point(114, 80);
            coachdeletetextBox1.Name = "coachdeletetextBox1";
            coachdeletetextBox1.Size = new Size(125, 27);
            coachdeletetextBox1.TabIndex = 0;
            // 
            // coachenterid
            // 
            coachenterid.BackColor = Color.Crimson;
            coachenterid.FlatStyle = FlatStyle.Popup;
            coachenterid.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            coachenterid.ForeColor = Color.White;
            coachenterid.Location = new Point(114, 113);
            coachenterid.Name = "coachenterid";
            coachenterid.Size = new Size(125, 34);
            coachenterid.TabIndex = 20;
            coachenterid.Text = "Enter ID";
            coachenterid.UseVisualStyleBackColor = false;
            coachenterid.Click += coachenterid_Click;
            // 
            // Form3_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(350, 226);
            Controls.Add(coachenterid);
            Controls.Add(coachdeletetextBox1);
            Name = "Form3_1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3_1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox coachdeletetextBox1;
        private Button coachenterid;
    }
}