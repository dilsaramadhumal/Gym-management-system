namespace GymMS
{
    partial class Payments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payments));
            label1 = new Label();
            btnedit = new Button();
            btnadd = new Button();
            label5 = new Label();
            label2 = new Label();
            textBoxname = new TextBox();
            textBoxid = new TextBox();
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            textBoxdel = new TextBox();
            btnDelete = new Button();
            btnrefresh = new Button();
            btnback = new Button();
            btnReset = new Button();
            btnExit = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label3 = new Label();
            textBoxpay = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView2 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 219);
            label1.Name = "label1";
            label1.Size = new Size(116, 23);
            label1.TabIndex = 75;
            label1.Text = "Started date";
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Crimson;
            btnedit.FlatStyle = FlatStyle.Popup;
            btnedit.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.ForeColor = Color.White;
            btnedit.Location = new Point(128, 362);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 34);
            btnedit.TabIndex = 68;
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
            btnadd.Location = new Point(25, 362);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 34);
            btnadd.TabIndex = 67;
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
            label5.Location = new Point(23, 138);
            label5.Name = "label5";
            label5.Size = new Size(61, 23);
            label5.TabIndex = 65;
            label5.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 68);
            label2.Name = "label2";
            label2.Size = new Size(28, 23);
            label2.TabIndex = 64;
            label2.Text = "ID";
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(23, 161);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(199, 27);
            textBoxname.TabIndex = 63;
            // 
            // textBoxid
            // 
            textBoxid.Location = new Point(23, 91);
            textBoxid.Name = "textBoxid";
            textBoxid.Size = new Size(199, 27);
            textBoxid.TabIndex = 62;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(textBoxdel);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(347, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(303, 72);
            groupBox1.TabIndex = 73;
            groupBox1.TabStop = false;
            groupBox1.Text = "Want to search or delete";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Crimson;
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(106, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxdel
            // 
            textBoxdel.Location = new Point(6, 37);
            textBoxdel.Name = "textBoxdel";
            textBoxdel.PlaceholderText = "Enter FID";
            textBoxdel.Size = new Size(94, 29);
            textBoxdel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(205, 37);
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
            btnrefresh.Location = new Point(959, 322);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(94, 34);
            btnrefresh.TabIndex = 72;
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
            btnback.Location = new Point(857, 16);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 34);
            btnback.TabIndex = 71;
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
            btnReset.Location = new Point(757, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 34);
            btnReset.TabIndex = 70;
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
            btnExit.Location = new Point(958, 16);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 69;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(518, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(535, 199);
            dataGridView1.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Berlin Sans FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(247, 45, 41);
            label6.Location = new Point(15, 16);
            label6.Name = "label6";
            label6.Size = new Size(196, 46);
            label6.TabIndex = 61;
            label6.Text = "Payments";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 294);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 77;
            label3.Text = "Payments";
            // 
            // textBoxpay
            // 
            textBoxpay.Location = new Point(25, 317);
            textBoxpay.Name = "textBoxpay";
            textBoxpay.Size = new Size(199, 27);
            textBoxpay.TabIndex = 76;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(25, 242);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 27);
            dateTimePicker1.TabIndex = 78;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(518, 183);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(534, 86);
            dataGridView2.TabIndex = 79;
            dataGridView2.Visible = false;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 577);
            Controls.Add(dataGridView2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(textBoxpay);
            Controls.Add(label1);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(textBoxname);
            Controls.Add(textBoxid);
            Controls.Add(groupBox1);
            Controls.Add(btnrefresh);
            Controls.Add(btnback);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "Payments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payments";
            Load += Payments_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnedit;
        private Button btnadd;
        private Label label5;
        private Label label2;
        private TextBox textBoxname;
        private TextBox textBoxid;
        private GroupBox groupBox1;
        private TextBox textBoxdel;
        private Button btnDelete;
        private Button btnrefresh;
        private Button btnback;
        private Button btnReset;
        private Button btnExit;
        private DataGridView dataGridView1;
        private Label label6;
        private Button btnSearch;
        private Label label3;
        private TextBox textBoxpay;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView2;
    }
}