namespace WindowsFormsApp1.Guest
{
    partial class frmGuestEmployee
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
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSerach = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.checkPosition = new System.Windows.Forms.CheckBox();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridAllEmployees = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtSearchID);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnSerach);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cboPosition);
            this.panel4.Controls.Add(this.cboName);
            this.panel4.Controls.Add(this.checkPosition);
            this.panel4.Controls.Add(this.checkName);
            this.panel4.Location = new System.Drawing.Point(12, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(744, 686);
            this.panel4.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 19);
            this.label12.TabIndex = 40;
            this.label12.Text = "Search Employees By ID";
            // 
            // txtSearchID
            // 
            this.txtSearchID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchID.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchID.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchID.Location = new System.Drawing.Point(181, 51);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(249, 19);
            this.txtSearchID.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(187, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 1);
            this.label1.TabIndex = 38;
            // 
            // btnSerach
            // 
            this.btnSerach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSerach.FlatAppearance.BorderSize = 0;
            this.btnSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerach.ForeColor = System.Drawing.Color.Black;
            this.btnSerach.Location = new System.Drawing.Point(571, 77);
            this.btnSerach.Name = "btnSerach";
            this.btnSerach.Size = new System.Drawing.Size(124, 36);
            this.btnSerach.TabIndex = 36;
            this.btnSerach.Text = "Search";
            this.btnSerach.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(305, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 35;
            this.label2.Text = "SEARCH";
            // 
            // cboPosition
            // 
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Location = new System.Drawing.Point(136, 106);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(99, 24);
            this.cboPosition.TabIndex = 26;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(136, 76);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(178, 24);
            this.cboName.TabIndex = 25;
            // 
            // checkPosition
            // 
            this.checkPosition.AutoSize = true;
            this.checkPosition.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPosition.ForeColor = System.Drawing.Color.Black;
            this.checkPosition.Location = new System.Drawing.Point(13, 106);
            this.checkPosition.Name = "checkPosition";
            this.checkPosition.Size = new System.Drawing.Size(102, 23);
            this.checkPosition.TabIndex = 24;
            this.checkPosition.Text = "By Position";
            this.checkPosition.UseVisualStyleBackColor = true;
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkName.ForeColor = System.Drawing.Color.Black;
            this.checkName.Location = new System.Drawing.Point(13, 77);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(93, 23);
            this.checkName.TabIndex = 23;
            this.checkName.Text = "By Name";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridAllEmployees);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Location = new System.Drawing.Point(762, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 686);
            this.panel2.TabIndex = 48;
            // 
            // dataGridAllEmployees
            // 
            this.dataGridAllEmployees.AllowUserToAddRows = false;
            this.dataGridAllEmployees.AllowUserToDeleteRows = false;
            this.dataGridAllEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAllEmployees.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridAllEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAllEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAllEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllEmployees.Location = new System.Drawing.Point(14, 34);
            this.dataGridAllEmployees.MultiSelect = false;
            this.dataGridAllEmployees.Name = "dataGridAllEmployees";
            this.dataGridAllEmployees.ReadOnly = true;
            this.dataGridAllEmployees.RowHeadersWidth = 45;
            this.dataGridAllEmployees.RowTemplate.Height = 24;
            this.dataGridAllEmployees.Size = new System.Drawing.Size(771, 647);
            this.dataGridAllEmployees.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(342, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "All Employees";
            // 
            // frmGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1597, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Name = "frmGuest";
            this.Text = "frmGuest";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSerach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.CheckBox checkPosition;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridAllEmployees;
        private System.Windows.Forms.Label label17;
    }
}