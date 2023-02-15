namespace WindowsFormsApp1.Admin
{
    partial class frmAdminHouses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboPrice = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.checkPrice = new System.Windows.Forms.CheckBox();
            this.checkPropertyType = new System.Windows.Forms.CheckBox();
            this.btnSerach = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.cboBedrooms = new System.Windows.Forms.ComboBox();
            this.cboNeighbourhood = new System.Windows.Forms.ComboBox();
            this.checkBedrooms = new System.Windows.Forms.CheckBox();
            this.checkNeighbourhood = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridAllHouses = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.cboClientName = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtBuilt = new System.Windows.Forms.TextBox();
            this.Elevator = new System.Windows.Forms.Label();
            this.cboElevator = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cboPool = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtBranchID = new System.Windows.Forms.TextBox();
            this.cmbBranchName = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtNeighbourhood = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBed = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.txtHouseID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAllHouses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cboPrice);
            this.panel4.Controls.Add(this.cboType);
            this.panel4.Controls.Add(this.checkPrice);
            this.panel4.Controls.Add(this.checkPropertyType);
            this.panel4.Controls.Add(this.btnSerach);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.cboBedrooms);
            this.panel4.Controls.Add(this.cboNeighbourhood);
            this.panel4.Controls.Add(this.checkBedrooms);
            this.panel4.Controls.Add(this.checkNeighbourhood);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 135);
            this.panel4.TabIndex = 48;
            // 
            // cboPrice
            // 
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(477, 87);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(134, 24);
            this.cboPrice.TabIndex = 40;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(477, 49);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(134, 24);
            this.cboType.TabIndex = 39;
            // 
            // checkPrice
            // 
            this.checkPrice.AutoSize = true;
            this.checkPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPrice.ForeColor = System.Drawing.Color.Black;
            this.checkPrice.Location = new System.Drawing.Point(320, 88);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(152, 21);
            this.checkPrice.TabIndex = 38;
            this.checkPrice.Text = "By Minimum Price";
            this.checkPrice.UseVisualStyleBackColor = true;
            // 
            // checkPropertyType
            // 
            this.checkPropertyType.AutoSize = true;
            this.checkPropertyType.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPropertyType.ForeColor = System.Drawing.Color.Black;
            this.checkPropertyType.Location = new System.Drawing.Point(320, 49);
            this.checkPropertyType.Name = "checkPropertyType";
            this.checkPropertyType.Size = new System.Drawing.Size(138, 21);
            this.checkPropertyType.TabIndex = 37;
            this.checkPropertyType.Text = "By Property Type";
            this.checkPropertyType.UseVisualStyleBackColor = true;
            // 
            // btnSerach
            // 
            this.btnSerach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSerach.FlatAppearance.BorderSize = 0;
            this.btnSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerach.ForeColor = System.Drawing.Color.White;
            this.btnSerach.Location = new System.Drawing.Point(652, 51);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(124, 36);
            this.btnSerach.TabIndex = 36;
            this.btnSerach.Text = "Search";
            this.btnSerach.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(377, -1);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(71, 19);
            this.label29.TabIndex = 35;
            this.label29.Text = "Search ";
            // 
            // cboBedrooms
            // 
            this.cboBedrooms.FormattingEnabled = true;
            this.cboBedrooms.Location = new System.Drawing.Point(168, 90);
            this.cboBedrooms.Name = "cboBedrooms";
            this.cboBedrooms.Size = new System.Drawing.Size(117, 24);
            this.cboBedrooms.TabIndex = 26;
            // 
            // cboNeighbourhood
            // 
            this.cboNeighbourhood.FormattingEnabled = true;
            this.cboNeighbourhood.Location = new System.Drawing.Point(168, 49);
            this.cboNeighbourhood.Name = "cboNeighbourhood";
            this.cboNeighbourhood.Size = new System.Drawing.Size(117, 24);
            this.cboNeighbourhood.TabIndex = 25;
            // 
            // checkBedrooms
            // 
            this.checkBedrooms.AutoSize = true;
            this.checkBedrooms.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBedrooms.ForeColor = System.Drawing.Color.Black;
            this.checkBedrooms.Location = new System.Drawing.Point(13, 90);
            this.checkBedrooms.Name = "checkBedrooms";
            this.checkBedrooms.Size = new System.Drawing.Size(125, 21);
            this.checkBedrooms.TabIndex = 24;
            this.checkBedrooms.Text = "By Bed Rooms";
            this.checkBedrooms.UseVisualStyleBackColor = true;
            // 
            // checkNeighbourhood
            // 
            this.checkNeighbourhood.AutoSize = true;
            this.checkNeighbourhood.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNeighbourhood.ForeColor = System.Drawing.Color.Black;
            this.checkNeighbourhood.Location = new System.Drawing.Point(13, 51);
            this.checkNeighbourhood.Name = "checkNeighbourhood";
            this.checkNeighbourhood.Size = new System.Drawing.Size(154, 21);
            this.checkNeighbourhood.TabIndex = 23;
            this.checkNeighbourhood.Text = "By Neighbourhood";
            this.checkNeighbourhood.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(841, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 47);
            this.panel3.TabIndex = 47;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(40, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 19);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = "Search By ID";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(40, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(251, 1);
            this.label11.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.datagridAllHouses);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(12, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 558);
            this.panel2.TabIndex = 49;
            // 
            // datagridAllHouses
            // 
            this.datagridAllHouses.AllowUserToAddRows = false;
            this.datagridAllHouses.AllowUserToDeleteRows = false;
            this.datagridAllHouses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridAllHouses.BackgroundColor = System.Drawing.Color.Silver;
            this.datagridAllHouses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridAllHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridAllHouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridAllHouses.Location = new System.Drawing.Point(-1, 37);
            this.datagridAllHouses.MultiSelect = false;
            this.datagridAllHouses.Name = "datagridAllHouses";
            this.datagridAllHouses.ReadOnly = true;
            this.datagridAllHouses.RowHeadersWidth = 45;
            this.datagridAllHouses.RowTemplate.Height = 24;
            this.datagridAllHouses.Size = new System.Drawing.Size(819, 516);
            this.datagridAllHouses.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(393, -1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "All";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEmployeeID);
            this.panel1.Controls.Add(this.cboClientName);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.cmbEmployeeName);
            this.panel1.Controls.Add(this.txtClientID);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.txtBuilt);
            this.panel1.Controls.Add(this.Elevator);
            this.panel1.Controls.Add(this.cboElevator);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.cboPool);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.txtBranchID);
            this.panel1.Controls.Add(this.cmbBranchName);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label26);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.cmbType);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtAdress);
            this.panel1.Controls.Add(this.txtNeighbourhood);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtBed);
            this.panel1.Controls.Add(this.cboStatus);
            this.panel1.Controls.Add(this.txtHouseID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(841, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 646);
            this.panel1.TabIndex = 50;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmployeeID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeID.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmployeeID.Location = new System.Drawing.Point(701, 42);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(81, 19);
            this.txtEmployeeID.TabIndex = 59;
            // 
            // cboClientName
            // 
            this.cboClientName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClientName.ForeColor = System.Drawing.Color.DimGray;
            this.cboClientName.FormattingEnabled = true;
            this.cboClientName.Location = new System.Drawing.Point(338, 77);
            this.cboClientName.Name = "cboClientName";
            this.cboClientName.Size = new System.Drawing.Size(140, 28);
            this.cboClientName.TabIndex = 64;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(489, 59);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(23, 18);
            this.label39.TabIndex = 63;
            this.label39.Text = "ID";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.DimGray;
            this.label37.Location = new System.Drawing.Point(653, -573);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 20);
            this.label37.TabIndex = 60;
            this.label37.Text = "ID";
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeName.ForeColor = System.Drawing.Color.DimGray;
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(573, 78);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(154, 28);
            this.cmbEmployeeName.TabIndex = 59;
            // 
            // txtClientID
            // 
            this.txtClientID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClientID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientID.ForeColor = System.Drawing.Color.DimGray;
            this.txtClientID.Location = new System.Drawing.Point(484, 87);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(81, 19);
            this.txtClientID.TabIndex = 62;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.Black;
            this.label36.Location = new System.Drawing.Point(698, 16);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(23, 18);
            this.label36.TabIndex = 58;
            this.label36.Text = "ID";
            // 
            // txtBuilt
            // 
            this.txtBuilt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuilt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuilt.ForeColor = System.Drawing.Color.DimGray;
            this.txtBuilt.Location = new System.Drawing.Point(335, 264);
            this.txtBuilt.Multiline = true;
            this.txtBuilt.Name = "txtBuilt";
            this.txtBuilt.Size = new System.Drawing.Size(143, 27);
            this.txtBuilt.TabIndex = 57;
            // 
            // Elevator
            // 
            this.Elevator.AutoSize = true;
            this.Elevator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elevator.ForeColor = System.Drawing.Color.Black;
            this.Elevator.Location = new System.Drawing.Point(572, 345);
            this.Elevator.Name = "Elevator";
            this.Elevator.Size = new System.Drawing.Size(67, 18);
            this.Elevator.TabIndex = 56;
            this.Elevator.Text = "Elevator";
            // 
            // cboElevator
            // 
            this.cboElevator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboElevator.ForeColor = System.Drawing.Color.DimGray;
            this.cboElevator.FormattingEnabled = true;
            this.cboElevator.Location = new System.Drawing.Point(574, 368);
            this.cboElevator.Name = "cboElevator";
            this.cboElevator.Size = new System.Drawing.Size(164, 28);
            this.cboElevator.TabIndex = 55;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.Black;
            this.label32.Location = new System.Drawing.Point(333, 344);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 18);
            this.label32.TabIndex = 53;
            this.label32.Text = "Pool";
            // 
            // cboPool
            // 
            this.cboPool.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPool.ForeColor = System.Drawing.Color.DimGray;
            this.cboPool.FormattingEnabled = true;
            this.cboPool.Location = new System.Drawing.Point(335, 367);
            this.cboPool.Name = "cboPool";
            this.cboPool.Size = new System.Drawing.Size(143, 28);
            this.cboPool.TabIndex = 52;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(198, 346);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 18);
            this.label27.TabIndex = 50;
            this.label27.Text = "ID";
            // 
            // txtBranchID
            // 
            this.txtBranchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBranchID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBranchID.ForeColor = System.Drawing.Color.DimGray;
            this.txtBranchID.Location = new System.Drawing.Point(202, 366);
            this.txtBranchID.Multiline = true;
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(93, 26);
            this.txtBranchID.TabIndex = 49;
            // 
            // cmbBranchName
            // 
            this.cmbBranchName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranchName.ForeColor = System.Drawing.Color.DimGray;
            this.cmbBranchName.FormattingEnabled = true;
            this.cmbBranchName.Location = new System.Drawing.Point(19, 366);
            this.cmbBranchName.Name = "cmbBranchName";
            this.cmbBranchName.Size = new System.Drawing.Size(148, 28);
            this.cmbBranchName.TabIndex = 47;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(17, 346);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(109, 18);
            this.label28.TabIndex = 46;
            this.label28.Text = "Branch Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(320, 523);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 36);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(176, 434);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(91, 18);
            this.label26.TabIndex = 41;
            this.label26.Text = "Description";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(15, 434);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 18);
            this.label25.TabIndex = 40;
            this.label25.Text = "Adress";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(570, 242);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(108, 18);
            this.label24.TabIndex = 39;
            this.label24.Text = "Property Type";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(335, 241);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 18);
            this.label23.TabIndex = 38;
            this.label23.Text = "Built In";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(15, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 18);
            this.label22.TabIndex = 37;
            this.label22.Text = "House Status";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(569, 135);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 18);
            this.label21.TabIndex = 36;
            this.label21.Text = "Price";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(335, 134);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 18);
            this.label20.TabIndex = 35;
            this.label20.Text = "Roms";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(15, 135);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(125, 18);
            this.label19.TabIndex = 34;
            this.label19.Text = "Neighbourhood";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(571, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 18);
            this.label18.TabIndex = 33;
            this.label18.Text = "By Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(337, 57);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 18);
            this.label16.TabIndex = 32;
            this.label16.Text = "By Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(12, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 18);
            this.label15.TabIndex = 31;
            this.label15.Text = "ID";
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.ForeColor = System.Drawing.Color.DimGray;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(572, 265);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(161, 28);
            this.cmbType.TabIndex = 30;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrice.Location = new System.Drawing.Point(572, 158);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(155, 19);
            this.txtPrice.TabIndex = 28;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescription.Location = new System.Drawing.Point(181, 457);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(174, 19);
            this.txtDescription.TabIndex = 26;
            // 
            // txtAdress
            // 
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdress.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.ForeColor = System.Drawing.Color.DimGray;
            this.txtAdress.Location = new System.Drawing.Point(18, 457);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(149, 19);
            this.txtAdress.TabIndex = 24;
            // 
            // txtNeighbourhood
            // 
            this.txtNeighbourhood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNeighbourhood.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNeighbourhood.ForeColor = System.Drawing.Color.DimGray;
            this.txtNeighbourhood.Location = new System.Drawing.Point(19, 158);
            this.txtNeighbourhood.Name = "txtNeighbourhood";
            this.txtNeighbourhood.Size = new System.Drawing.Size(148, 19);
            this.txtNeighbourhood.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(1001, 523);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 36);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(170, 557);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 36);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit Record";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(464, 557);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(119, 36);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(17, 523);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 36);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtBed
            // 
            this.txtBed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBed.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBed.ForeColor = System.Drawing.Color.DimGray;
            this.txtBed.Location = new System.Drawing.Point(338, 157);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(140, 19);
            this.txtBed.TabIndex = 12;
            // 
            // cboStatus
            // 
            this.cboStatus.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(16, 265);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(151, 28);
            this.cboStatus.TabIndex = 8;
            // 
            // txtHouseID
            // 
            this.txtHouseID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHouseID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHouseID.ForeColor = System.Drawing.Color.DimGray;
            this.txtHouseID.Location = new System.Drawing.Point(19, 86);
            this.txtHouseID.Name = "txtHouseID";
            this.txtHouseID.Size = new System.Drawing.Size(148, 19);
            this.txtHouseID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(435, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADDING";
            // 
            // frmAdminHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1681, 723);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "frmAdminHouses";
            this.Text = "frmAdminHouses";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridAllHouses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboPrice;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.CheckBox checkPrice;
        private System.Windows.Forms.CheckBox checkPropertyType;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboBedrooms;
        private System.Windows.Forms.ComboBox cboNeighbourhood;
        private System.Windows.Forms.CheckBox checkBedrooms;
        private System.Windows.Forms.CheckBox checkNeighbourhood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView datagridAllHouses;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.ComboBox cboClientName;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtBuilt;
        private System.Windows.Forms.Label Elevator;
        private System.Windows.Forms.ComboBox cboElevator;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cboPool;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtBranchID;
        private System.Windows.Forms.ComboBox cmbBranchName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtNeighbourhood;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBed;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.TextBox txtHouseID;
        private System.Windows.Forms.Label label2;
    }
}