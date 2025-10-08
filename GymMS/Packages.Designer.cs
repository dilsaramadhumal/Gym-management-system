namespace GymMS
{
    partial class Packages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Packages));
            label6 = new Label();
            label1 = new Label();
            textBoxfee = new TextBox();
            btnedit = new Button();
            btnadd = new Button();
            label5 = new Label();
            label2 = new Label();
            textBoxgoal = new TextBox();
            textBoxName = new TextBox();
            textBoxdel = new TextBox();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnrefresh = new Button();
            btnback = new Button();
            btnReset = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Berlin Sans FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(247, 45, 41);
            label6.Location = new Point(12, 9);
            label6.Name = "label6";
            label6.Size = new Size(187, 46);
            label6.TabIndex = 34;
            label6.Text = "Packages";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 212);
            label1.Name = "label1";
            label1.Size = new Size(41, 23);
            label1.TabIndex = 60;
            label1.Text = "Fee";
            // 
            // textBoxfee
            // 
            textBoxfee.Location = new Point(20, 235);
            textBoxfee.Name = "textBoxfee";
            textBoxfee.Size = new Size(199, 27);
            textBoxfee.TabIndex = 59;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Crimson;
            btnedit.FlatStyle = FlatStyle.Popup;
            btnedit.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.ForeColor = Color.White;
            btnedit.Location = new Point(122, 294);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 34);
            btnedit.TabIndex = 53;
            btnedit.Text = "Edit";
            btnedit.UseVisualStyleBackColor = false;
            btnedit.Click += btnedit_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.Crimson;
            btnadd.FlatStyle = FlatStyle.Popup;
            btnadd.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadd.ForeColor = Color.White;
            btnadd.Location = new Point(19, 294);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 34);
            btnadd.TabIndex = 52;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(20, 131);
            label5.Name = "label5";
            label5.Size = new Size(49, 23);
            label5.TabIndex = 50;
            label5.Text = "Goal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 61);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 49;
            label2.Text = "Name";
            // 
            // textBoxgoal
            // 
            textBoxgoal.Location = new Point(20, 154);
            textBoxgoal.Name = "textBoxgoal";
            textBoxgoal.Size = new Size(199, 27);
            textBoxgoal.TabIndex = 48;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(20, 84);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 27);
            textBoxName.TabIndex = 47;
            // 
            // textBoxdel
            // 
            textBoxdel.Location = new Point(6, 37);
            textBoxdel.Name = "textBoxdel";
            textBoxdel.PlaceholderText = "Enter PID";
            textBoxdel.Size = new Size(94, 29);
            textBoxdel.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(textBoxdel);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(344, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(207, 72);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Want to delete";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(106, 37);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.Crimson;
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.Location = new Point(956, 315);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(94, 34);
            btnrefresh.TabIndex = 57;
            btnrefresh.Text = "Refresh";
            btnrefresh.UseVisualStyleBackColor = false;
            btnrefresh.Click += btnrefresh_Click;
            // 
            // btnback
            // 
            btnback.BackColor = Color.Crimson;
            btnback.FlatStyle = FlatStyle.Popup;
            btnback.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(854, 9);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 34);
            btnback.TabIndex = 56;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = false;
            btnback.Click += btnback_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Crimson;
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(754, 9);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 34);
            btnReset.TabIndex = 55;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Crimson;
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(955, 9);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 54;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(516, 355);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(535, 199);
            dataGridView1.TabIndex = 51;
            // 
            // Packages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 577);
            Controls.Add(label1);
            Controls.Add(textBoxfee);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBoxgoal);
            Controls.Add(textBoxName);
            Controls.Add(groupBox1);
            Controls.Add(btnrefresh);
            Controls.Add(btnback);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "Packages";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Packages";
            Load += Packages_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label1;
        private TextBox textBoxfee;
        private Button btnedit;
        private Button btnadd;
        private Label label5;
        private Label label2;
        private TextBox textBoxgoal;
        private TextBox textBoxName;
        private TextBox textBoxdel;
        private GroupBox groupBox1;
        private Button btnDelete;
        private Button btnrefresh;
        private Button btnback;
        private Button btnReset;
        private Button btnExit;
        private DataGridView dataGridView1;
    }
}