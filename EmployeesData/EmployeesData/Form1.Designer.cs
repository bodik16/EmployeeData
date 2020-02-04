namespace EmployeesData
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SackAnEmployeeButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._salarynumericUpDownAdd = new System.Windows.Forms.NumericUpDown();
            this._idtextBoxAdd = new System.Windows.Forms.NumericUpDown();
            this._salaryLabel = new System.Windows.Forms.Label();
            this._salarynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.AverageSalaryValueLabel = new System.Windows.Forms.Label();
            this.CountOfEmployeesLabel = new System.Windows.Forms.Label();
            this.CountOfEmployeesValueLabel = new System.Windows.Forms.Label();
            this.AverageSalaryLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._firstNametextBoxAdd = new System.Windows.Forms.TextBox();
            this._lastNametextBoxAdd = new System.Windows.Forms.TextBox();
            this._fathersNametextBoxAdd = new System.Windows.Forms.TextBox();
            this.Hirebutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddEmployeegroupBox = new System.Windows.Forms.GroupBox();
            this._lastNameLabel = new System.Windows.Forms.Label();
            this._fathersNameLabel = new System.Windows.Forms.Label();
            this._firstNameLabel = new System.Windows.Forms.Label();
            this._idLabel = new System.Windows.Forms.Label();
            this._idtextBox = new System.Windows.Forms.TextBox();
            this._firstNametextBox = new System.Windows.Forms.TextBox();
            this._lastNametextBox = new System.Windows.Forms.TextBox();
            this._fathersNametextBox = new System.Windows.Forms.TextBox();
            this._editcheckBox = new System.Windows.Forms.CheckBox();
            this._editButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SerializationgroupBox = new System.Windows.Forms.GroupBox();
            this.SerializeButton = new System.Windows.Forms.Button();
            this.DeserializeButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._salarynumericUpDownAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._idtextBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._salarynumericUpDown)).BeginInit();
            this.AddEmployeegroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SerializationgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddEmployeeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeButton.Location = new System.Drawing.Point(12, 265);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(346, 75);
            this.AddEmployeeButton.TabIndex = 10;
            this.AddEmployeeButton.Text = "Hire new employee";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::EmployeesData.Properties.Resources.kisspng_x_mark_drawing_red_check_mark_cross_5ab88d63d7dd76_4974117815220442598842;
            this.pictureBox2.Location = new System.Drawing.Point(1244, 676);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "An epmloyee will be deleted from Data Base");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // SackAnEmployeeButton
            // 
            this.SackAnEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SackAnEmployeeButton.Enabled = false;
            this.SackAnEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SackAnEmployeeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SackAnEmployeeButton.Location = new System.Drawing.Point(1056, 675);
            this.SackAnEmployeeButton.Name = "SackAnEmployeeButton";
            this.SackAnEmployeeButton.Size = new System.Drawing.Size(181, 49);
            this.SackAnEmployeeButton.TabIndex = 24;
            this.SackAnEmployeeButton.Text = "Sack an employee";
            this.toolTip1.SetToolTip(this.SackAnEmployeeButton, "An epmloyee will be deleted from Data Base");
            this.SackAnEmployeeButton.UseVisualStyleBackColor = true;
            this.SackAnEmployeeButton.Click += new System.EventHandler(this.SackAnEmployeeButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchTextBox.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.SearchTextBox.Location = new System.Drawing.Point(686, 4);
            this.SearchTextBox.Multiline = true;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(646, 59);
            this.SearchTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.SearchTextBox, "You can find employees by:\r\n-First Name: \"Lionel\"\r\n-Last Name: \"Messi\"\r\n-ID: \"134" +
        "54898\"");
            this.SearchTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Image = global::EmployeesData.Properties.Resources.SearchLogo;
            this.pictureBox1.Location = new System.Drawing.Point(580, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "You can find employees by:\r\n-First Name: \"Lionel\"\r\n-Last Name: \"Messi\"\r\n-ID: \"134" +
        "54898\"");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Salary";
            this.toolTip1.SetToolTip(this.label2, "Salary per. Hour");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            this.toolTip1.SetToolTip(this.label1, "Employee ID should be unique");
            // 
            // _salarynumericUpDownAdd
            // 
            this._salarynumericUpDownAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._salarynumericUpDownAdd.Location = new System.Drawing.Point(159, 189);
            this._salarynumericUpDownAdd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._salarynumericUpDownAdd.Name = "_salarynumericUpDownAdd";
            this._salarynumericUpDownAdd.ReadOnly = true;
            this._salarynumericUpDownAdd.Size = new System.Drawing.Size(165, 29);
            this._salarynumericUpDownAdd.TabIndex = 16;
            this.toolTip1.SetToolTip(this._salarynumericUpDownAdd, "Salary per. Hour");
            this._salarynumericUpDownAdd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _idtextBoxAdd
            // 
            this._idtextBoxAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._idtextBoxAdd.Location = new System.Drawing.Point(159, 43);
            this._idtextBoxAdd.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this._idtextBoxAdd.Minimum = new decimal(new int[] {
            10000001,
            0,
            0,
            0});
            this._idtextBoxAdd.Name = "_idtextBoxAdd";
            this._idtextBoxAdd.ReadOnly = true;
            this._idtextBoxAdd.Size = new System.Drawing.Size(165, 29);
            this._idtextBoxAdd.TabIndex = 23;
            this.toolTip1.SetToolTip(this._idtextBoxAdd, "Employee ID should be unique");
            this._idtextBoxAdd.Value = new decimal(new int[] {
            10000001,
            0,
            0,
            0});
            this._idtextBoxAdd.ValueChanged += new System.EventHandler(this._idtextBoxAdd_ValueChanged);
            // 
            // _salaryLabel
            // 
            this._salaryLabel.AutoSize = true;
            this._salaryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._salaryLabel.Location = new System.Drawing.Point(23, 174);
            this._salaryLabel.Name = "_salaryLabel";
            this._salaryLabel.Size = new System.Drawing.Size(67, 24);
            this._salaryLabel.TabIndex = 8;
            this._salaryLabel.Text = "Salary";
            this.toolTip1.SetToolTip(this._salaryLabel, "Salary per. Hour");
            // 
            // _salarynumericUpDown
            // 
            this._salarynumericUpDown.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._salarynumericUpDown.Location = new System.Drawing.Point(175, 171);
            this._salarynumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._salarynumericUpDown.Name = "_salarynumericUpDown";
            this._salarynumericUpDown.ReadOnly = true;
            this._salarynumericUpDown.Size = new System.Drawing.Size(165, 32);
            this._salarynumericUpDown.TabIndex = 12;
            this.toolTip1.SetToolTip(this._salarynumericUpDown, "Salary per. Hour");
            this._salarynumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(580, 675);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(405, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show all employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AverageSalaryValueLabel
            // 
            this.AverageSalaryValueLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AverageSalaryValueLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageSalaryValueLabel.Location = new System.Drawing.Point(386, 265);
            this.AverageSalaryValueLabel.Name = "AverageSalaryValueLabel";
            this.AverageSalaryValueLabel.Size = new System.Drawing.Size(174, 138);
            this.AverageSalaryValueLabel.TabIndex = 29;
            this.AverageSalaryValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AverageSalaryValueLabel.Click += new System.EventHandler(this.AverageSalaryValueLabel_Click);
            // 
            // CountOfEmployeesLabel
            // 
            this.CountOfEmployeesLabel.AutoSize = true;
            this.CountOfEmployeesLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfEmployeesLabel.Location = new System.Drawing.Point(382, 39);
            this.CountOfEmployeesLabel.Name = "CountOfEmployeesLabel";
            this.CountOfEmployeesLabel.Size = new System.Drawing.Size(178, 24);
            this.CountOfEmployeesLabel.TabIndex = 26;
            this.CountOfEmployeesLabel.Text = "Count of employees";
            this.CountOfEmployeesLabel.Click += new System.EventHandler(this.CountOfEmployeesLabel_Click);
            // 
            // CountOfEmployeesValueLabel
            // 
            this.CountOfEmployeesValueLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.CountOfEmployeesValueLabel.Font = new System.Drawing.Font("Times New Roman", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfEmployeesValueLabel.Location = new System.Drawing.Point(386, 72);
            this.CountOfEmployeesValueLabel.Name = "CountOfEmployeesValueLabel";
            this.CountOfEmployeesValueLabel.Size = new System.Drawing.Size(174, 138);
            this.CountOfEmployeesValueLabel.TabIndex = 27;
            this.CountOfEmployeesValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountOfEmployeesValueLabel.Click += new System.EventHandler(this.CountOfEmployeesValueLabel_Click);
            // 
            // AverageSalaryLabel
            // 
            this.AverageSalaryLabel.AutoSize = true;
            this.AverageSalaryLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageSalaryLabel.Location = new System.Drawing.Point(403, 235);
            this.AverageSalaryLabel.Name = "AverageSalaryLabel";
            this.AverageSalaryLabel.Size = new System.Drawing.Size(137, 24);
            this.AverageSalaryLabel.TabIndex = 28;
            this.AverageSalaryLabel.Text = "Average salary";
            this.AverageSalaryLabel.Click += new System.EventHandler(this.AverageSalaryLabel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 17;
            this.label4.Text = "Father`s Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name";
            // 
            // _firstNametextBoxAdd
            // 
            this._firstNametextBoxAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._firstNametextBoxAdd.Location = new System.Drawing.Point(159, 78);
            this._firstNametextBoxAdd.Name = "_firstNametextBoxAdd";
            this._firstNametextBoxAdd.Size = new System.Drawing.Size(165, 29);
            this._firstNametextBoxAdd.TabIndex = 20;
            this._firstNametextBoxAdd.TextChanged += new System.EventHandler(this._firstNametextBoxAdd_TextChanged);
            // 
            // _lastNametextBoxAdd
            // 
            this._lastNametextBoxAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lastNametextBoxAdd.Location = new System.Drawing.Point(159, 116);
            this._lastNametextBoxAdd.Name = "_lastNametextBoxAdd";
            this._lastNametextBoxAdd.Size = new System.Drawing.Size(165, 29);
            this._lastNametextBoxAdd.TabIndex = 21;
            this._lastNametextBoxAdd.TextChanged += new System.EventHandler(this._lastNametextBoxAdd_TextChanged);
            // 
            // _fathersNametextBoxAdd
            // 
            this._fathersNametextBoxAdd.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._fathersNametextBoxAdd.Location = new System.Drawing.Point(159, 154);
            this._fathersNametextBoxAdd.Name = "_fathersNametextBoxAdd";
            this._fathersNametextBoxAdd.Size = new System.Drawing.Size(165, 29);
            this._fathersNametextBoxAdd.TabIndex = 22;
            this._fathersNametextBoxAdd.TextChanged += new System.EventHandler(this._fathersNametextBoxAdd_TextChanged);
            // 
            // Hirebutton
            // 
            this.Hirebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Hirebutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hirebutton.Location = new System.Drawing.Point(159, 224);
            this.Hirebutton.Name = "Hirebutton";
            this.Hirebutton.Size = new System.Drawing.Size(165, 69);
            this.Hirebutton.TabIndex = 13;
            this.Hirebutton.Text = "Hire";
            this.Hirebutton.UseVisualStyleBackColor = true;
            this.Hirebutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(11, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 69);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddEmployeegroupBox
            // 
            this.AddEmployeegroupBox.Controls.Add(this.button2);
            this.AddEmployeegroupBox.Controls.Add(this._idtextBoxAdd);
            this.AddEmployeegroupBox.Controls.Add(this.Hirebutton);
            this.AddEmployeegroupBox.Controls.Add(this._salarynumericUpDownAdd);
            this.AddEmployeegroupBox.Controls.Add(this._fathersNametextBoxAdd);
            this.AddEmployeegroupBox.Controls.Add(this._lastNametextBoxAdd);
            this.AddEmployeegroupBox.Controls.Add(this._firstNametextBoxAdd);
            this.AddEmployeegroupBox.Controls.Add(this.label1);
            this.AddEmployeegroupBox.Controls.Add(this.label2);
            this.AddEmployeegroupBox.Controls.Add(this.label3);
            this.AddEmployeegroupBox.Controls.Add(this.label4);
            this.AddEmployeegroupBox.Controls.Add(this.label5);
            this.AddEmployeegroupBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeegroupBox.Location = new System.Drawing.Point(12, 346);
            this.AddEmployeegroupBox.Name = "AddEmployeegroupBox";
            this.AddEmployeegroupBox.Size = new System.Drawing.Size(346, 299);
            this.AddEmployeegroupBox.TabIndex = 11;
            this.AddEmployeegroupBox.TabStop = false;
            this.AddEmployeegroupBox.Text = "Add employee";
            this.AddEmployeegroupBox.Visible = false;
            this.AddEmployeegroupBox.Enter += new System.EventHandler(this.AddEmployeegroupBox_Enter);
            // 
            // _lastNameLabel
            // 
            this._lastNameLabel.AutoSize = true;
            this._lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lastNameLabel.Location = new System.Drawing.Point(23, 98);
            this._lastNameLabel.Name = "_lastNameLabel";
            this._lastNameLabel.Size = new System.Drawing.Size(104, 24);
            this._lastNameLabel.TabIndex = 5;
            this._lastNameLabel.Text = "Last Name";
            // 
            // _fathersNameLabel
            // 
            this._fathersNameLabel.AutoSize = true;
            this._fathersNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._fathersNameLabel.Location = new System.Drawing.Point(23, 136);
            this._fathersNameLabel.Name = "_fathersNameLabel";
            this._fathersNameLabel.Size = new System.Drawing.Size(140, 24);
            this._fathersNameLabel.TabIndex = 7;
            this._fathersNameLabel.Text = "Father`s Name";
            // 
            // _firstNameLabel
            // 
            this._firstNameLabel.AutoSize = true;
            this._firstNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._firstNameLabel.Location = new System.Drawing.Point(23, 60);
            this._firstNameLabel.Name = "_firstNameLabel";
            this._firstNameLabel.Size = new System.Drawing.Size(107, 24);
            this._firstNameLabel.TabIndex = 4;
            this._firstNameLabel.Text = "First Name";
            // 
            // _idLabel
            // 
            this._idLabel.AutoSize = true;
            this._idLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._idLabel.Location = new System.Drawing.Point(23, 22);
            this._idLabel.Name = "_idLabel";
            this._idLabel.Size = new System.Drawing.Size(33, 24);
            this._idLabel.TabIndex = 6;
            this._idLabel.Text = "ID";
            // 
            // _idtextBox
            // 
            this._idtextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._idtextBox.Location = new System.Drawing.Point(175, 19);
            this._idtextBox.Name = "_idtextBox";
            this._idtextBox.ReadOnly = true;
            this._idtextBox.Size = new System.Drawing.Size(165, 32);
            this._idtextBox.TabIndex = 9;
            // 
            // _firstNametextBox
            // 
            this._firstNametextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._firstNametextBox.Location = new System.Drawing.Point(175, 57);
            this._firstNametextBox.Name = "_firstNametextBox";
            this._firstNametextBox.ReadOnly = true;
            this._firstNametextBox.Size = new System.Drawing.Size(165, 32);
            this._firstNametextBox.TabIndex = 10;
            // 
            // _lastNametextBox
            // 
            this._lastNametextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._lastNametextBox.Location = new System.Drawing.Point(175, 95);
            this._lastNametextBox.Name = "_lastNametextBox";
            this._lastNametextBox.ReadOnly = true;
            this._lastNametextBox.Size = new System.Drawing.Size(165, 32);
            this._lastNametextBox.TabIndex = 11;
            // 
            // _fathersNametextBox
            // 
            this._fathersNametextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this._fathersNametextBox.Location = new System.Drawing.Point(175, 133);
            this._fathersNametextBox.Name = "_fathersNametextBox";
            this._fathersNametextBox.ReadOnly = true;
            this._fathersNametextBox.Size = new System.Drawing.Size(165, 32);
            this._fathersNametextBox.TabIndex = 12;
            // 
            // _editcheckBox
            // 
            this._editcheckBox.AutoSize = true;
            this._editcheckBox.Location = new System.Drawing.Point(27, 209);
            this._editcheckBox.Name = "_editcheckBox";
            this._editcheckBox.Size = new System.Drawing.Size(66, 28);
            this._editcheckBox.TabIndex = 14;
            this._editcheckBox.Text = "Edit";
            this._editcheckBox.UseVisualStyleBackColor = true;
            this._editcheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // _editButton
            // 
            this._editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this._editButton.Location = new System.Drawing.Point(175, 209);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(165, 28);
            this._editButton.TabIndex = 15;
            this._editButton.Text = "Edit";
            this._editButton.UseVisualStyleBackColor = true;
            this._editButton.Visible = false;
            this._editButton.Click += new System.EventHandler(this._editButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this._salarynumericUpDown);
            this.groupBox1.Controls.Add(this._editButton);
            this.groupBox1.Controls.Add(this._editcheckBox);
            this.groupBox1.Controls.Add(this._fathersNametextBox);
            this.groupBox1.Controls.Add(this._lastNametextBox);
            this.groupBox1.Controls.Add(this._firstNametextBox);
            this.groupBox1.Controls.Add(this._idtextBox);
            this.groupBox1.Controls.Add(this._idLabel);
            this.groupBox1.Controls.Add(this._salaryLabel);
            this.groupBox1.Controls.Add(this._firstNameLabel);
            this.groupBox1.Controls.Add(this._fathersNameLabel);
            this.groupBox1.Controls.Add(this._lastNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 247);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(580, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(753, 600);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseMove);
            // 
            // SerializationgroupBox
            // 
            this.SerializationgroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SerializationgroupBox.Controls.Add(this.button3);
            this.SerializationgroupBox.Controls.Add(this.SerializeButton);
            this.SerializationgroupBox.Controls.Add(this.DeserializeButton);
            this.SerializationgroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SerializationgroupBox.Location = new System.Drawing.Point(12, 645);
            this.SerializationgroupBox.Name = "SerializationgroupBox";
            this.SerializationgroupBox.Size = new System.Drawing.Size(346, 79);
            this.SerializationgroupBox.TabIndex = 30;
            this.SerializationgroupBox.TabStop = false;
            this.SerializationgroupBox.Text = "Export/Import";
            // 
            // SerializeButton
            // 
            this.SerializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SerializeButton.Location = new System.Drawing.Point(6, 19);
            this.SerializeButton.Name = "SerializeButton";
            this.SerializeButton.Size = new System.Drawing.Size(115, 54);
            this.SerializeButton.TabIndex = 0;
            this.SerializeButton.Text = "Serialize";
            this.SerializeButton.UseVisualStyleBackColor = true;
            this.SerializeButton.Click += new System.EventHandler(this.SerializeButton_Click);
            // 
            // DeserializeButton
            // 
            this.DeserializeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeserializeButton.Location = new System.Drawing.Point(127, 19);
            this.DeserializeButton.Name = "DeserializeButton";
            this.DeserializeButton.Size = new System.Drawing.Size(115, 54);
            this.DeserializeButton.TabIndex = 31;
            this.DeserializeButton.Text = "Deserialize";
            this.DeserializeButton.UseVisualStyleBackColor = true;
            this.DeserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(248, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 54);
            this.button3.TabIndex = 32;
            this.button3.Text = "Save to txt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1345, 734);
            this.Controls.Add(this.SerializationgroupBox);
            this.Controls.Add(this.AverageSalaryValueLabel);
            this.Controls.Add(this.AverageSalaryLabel);
            this.Controls.Add(this.CountOfEmployeesValueLabel);
            this.Controls.Add(this.CountOfEmployeesLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SackAnEmployeeButton);
            this.Controls.Add(this.AddEmployeegroupBox);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._salarynumericUpDownAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._idtextBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._salarynumericUpDown)).EndInit();
            this.AddEmployeegroupBox.ResumeLayout(false);
            this.AddEmployeegroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SerializationgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button SackAnEmployeeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label AverageSalaryValueLabel;
        private System.Windows.Forms.Label CountOfEmployeesLabel;
        private System.Windows.Forms.Label CountOfEmployeesValueLabel;
        private System.Windows.Forms.Label AverageSalaryLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _firstNametextBoxAdd;
        private System.Windows.Forms.TextBox _lastNametextBoxAdd;
        private System.Windows.Forms.TextBox _fathersNametextBoxAdd;
        private System.Windows.Forms.NumericUpDown _salarynumericUpDownAdd;
        private System.Windows.Forms.Button Hirebutton;
        private System.Windows.Forms.NumericUpDown _idtextBoxAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox AddEmployeegroupBox;
        private System.Windows.Forms.Label _lastNameLabel;
        private System.Windows.Forms.Label _fathersNameLabel;
        private System.Windows.Forms.Label _firstNameLabel;
        private System.Windows.Forms.Label _salaryLabel;
        private System.Windows.Forms.Label _idLabel;
        private System.Windows.Forms.TextBox _idtextBox;
        private System.Windows.Forms.TextBox _firstNametextBox;
        private System.Windows.Forms.TextBox _lastNametextBox;
        private System.Windows.Forms.TextBox _fathersNametextBox;
        private System.Windows.Forms.CheckBox _editcheckBox;
        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.NumericUpDown _salarynumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.GroupBox SerializationgroupBox;
        private System.Windows.Forms.Button SerializeButton;
        private System.Windows.Forms.Button DeserializeButton;
        private System.Windows.Forms.Button button3;
    }
}

