namespace GymMS
{
    partial class Members
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Members));
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            buttonSearch = new Button();
            textBoxSearchdel = new TextBox();
            btnDelete = new Button();
            IDlabel = new Label();
            textBoxID = new TextBox();
            btnrefresh = new Button();
            btnback = new Button();
            btnReset = new Button();
            btnExit = new Button();
            btnedit = new Button();
            btnadd = new Button();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            label1 = new Label();
            textBoxCoachid = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(344, 161);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(706, 82);
            dataGridView2.TabIndex = 44;
            dataGridView2.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonSearch);
            groupBox1.Controls.Add(textBoxSearchdel);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(344, 68);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 76);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Want to search or delete";
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.Crimson;
            buttonSearch.FlatStyle = FlatStyle.Popup;
            buttonSearch.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(106, 37);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(94, 29);
            buttonSearch.TabIndex = 16;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearchdel
            // 
            textBoxSearchdel.Location = new Point(6, 37);
            textBoxSearchdel.Name = "textBoxSearchdel";
            textBoxSearchdel.PlaceholderText = "Enter MID";
            textBoxSearchdel.Size = new Size(94, 29);
            textBoxSearchdel.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(206, 37);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.BackColor = Color.Transparent;
            IDlabel.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IDlabel.ForeColor = Color.White;
            IDlabel.Location = new Point(19, 68);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(28, 23);
            IDlabel.TabIndex = 42;
            IDlabel.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(19, 91);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(199, 27);
            textBoxID.TabIndex = 41;
            // 
            // btnrefresh
            // 
            btnrefresh.BackColor = Color.Crimson;
            btnrefresh.FlatStyle = FlatStyle.Popup;
            btnrefresh.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = Color.White;
            btnrefresh.Location = new Point(956, 322);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.Size = new Size(94, 34);
            btnrefresh.TabIndex = 40;
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
            btnback.Location = new Point(854, 16);
            btnback.Name = "btnback";
            btnback.Size = new Size(94, 34);
            btnback.TabIndex = 39;
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
            btnReset.Location = new Point(754, 16);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 34);
            btnReset.TabIndex = 38;
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
            btnExit.Location = new Point(955, 16);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 37;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnedit
            // 
            btnedit.BackColor = Color.Crimson;
            btnedit.FlatStyle = FlatStyle.Popup;
            btnedit.Font = new Font("Berlin Sans FB", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnedit.ForeColor = Color.White;
            btnedit.Location = new Point(122, 541);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(94, 34);
            btnedit.TabIndex = 36;
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
            btnadd.Location = new Point(19, 541);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 34);
            btnadd.TabIndex = 35;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 362);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(706, 199);
            dataGridView1.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Berlin Sans FB", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(247, 45, 41);
            label6.Location = new Point(19, 16);
            label6.Name = "label6";
            label6.Size = new Size(177, 46);
            label6.TabIndex = 33;
            label6.Text = "Members";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(19, 334);
            label5.Name = "label5";
            label5.Size = new Size(62, 23);
            label5.TabIndex = 32;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(19, 268);
            label4.Name = "label4";
            label4.Size = new Size(51, 23);
            label4.TabIndex = 31;
            label4.Text = "DOB";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(19, 208);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 30;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 138);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 29;
            label2.Text = "Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(19, 289);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 27);
            dateTimePicker1.TabIndex = 28;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(89, 235);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(82, 23);
            radioButton2.TabIndex = 27;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Font = new Font("Berlin Sans FB", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(19, 235);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(64, 23);
            radioButton1.TabIndex = 26;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(19, 357);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(199, 27);
            textBoxPhone.TabIndex = 25;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(19, 161);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 27);
            textBoxName.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(19, 403);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 46;
            label1.Text = "Coach's ID";
            // 
            // textBoxCoachid
            // 
            textBoxCoachid.Location = new Point(19, 426);
            textBoxCoachid.Name = "textBoxCoachid";
            textBoxCoachid.Size = new Size(199, 27);
            textBoxCoachid.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Berlin Sans FB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 471);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 47;
            label7.Text = "Package";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Body building", "Cardio training", "Athletics" });
            comboBox1.Location = new Point(19, 493);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 48;
            comboBox1.Text = "Select a package";
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 577);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(textBoxCoachid);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(IDlabel);
            Controls.Add(textBoxID);
            Controls.Add(btnrefresh);
            Controls.Add(btnback);
            Controls.Add(btnReset);
            Controls.Add(btnExit);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Name = "Members";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Members";
            Load += Members_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Button buttonSearch;
        private TextBox textBoxSearchdel;
        private Button btnDelete;
        private Label IDlabel;
        private TextBox textBoxID;
        private Button btnrefresh;
        private Button btnback;
        private Button btnReset;
        private Button btnExit;
        private Button btnedit;
        private Button btnadd;
        private DataGridView dataGridView1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private Label label1;
        private TextBox textBoxCoachid;
        private Label label7;
        private ComboBox comboBox1;
    }
}