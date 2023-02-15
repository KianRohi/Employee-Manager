namespace WindowsFormsApp1.Guest
{
    partial class frmGuestHouses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridAllHouses = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel4.Size = new System.Drawing.Size(937, 135);
            this.panel4.TabIndex = 50;
            // 
            // cboPrice
            // 
            this.cboPrice.FormattingEnabled = true;
            this.cboPrice.Location = new System.Drawing.Point(562, 89);
            this.cboPrice.Name = "cboPrice";
            this.cboPrice.Size = new System.Drawing.Size(99, 24);
            this.cboPrice.TabIndex = 40;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(562, 51);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(178, 24);
            this.cboType.TabIndex = 39;
            // 
            // checkPrice
            // 
            this.checkPrice.AutoSize = true;
            this.checkPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPrice.ForeColor = System.Drawing.Color.Black;
            this.checkPrice.Location = new System.Drawing.Point(405, 90);
            this.checkPrice.Name = "checkPrice";
            this.checkPrice.Size = new System.Drawing.Size(161, 22);
            this.checkPrice.TabIndex = 38;
            this.checkPrice.Text = "By Minimum Price";
            this.checkPrice.UseVisualStyleBackColor = true;
            // 
            // checkPropertyType
            // 
            this.checkPropertyType.AutoSize = true;
            this.checkPropertyType.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPropertyType.ForeColor = System.Drawing.Color.Black;
            this.checkPropertyType.Location = new System.Drawing.Point(405, 51);
            this.checkPropertyType.Name = "checkPropertyType";
            this.checkPropertyType.Size = new System.Drawing.Size(152, 22);
            this.checkPropertyType.TabIndex = 37;
            this.checkPropertyType.Text = "By Property Type";
            this.checkPropertyType.UseVisualStyleBackColor = true;
            // 
            // btnSerach
            // 
            this.btnSerach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSerach.FlatAppearance.BorderSize = 0;
            this.btnSerach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerach.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerach.ForeColor = System.Drawing.Color.Black;
            this.btnSerach.Location = new System.Drawing.Point(804, 66);
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
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(401, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(154, 19);
            this.label29.TabIndex = 35;
            this.label29.Text = "Filter Your Search ";
            // 
            // cboBedrooms
            // 
            this.cboBedrooms.FormattingEnabled = true;
            this.cboBedrooms.Location = new System.Drawing.Point(182, 90);
            this.cboBedrooms.Name = "cboBedrooms";
            this.cboBedrooms.Size = new System.Drawing.Size(99, 24);
            this.cboBedrooms.TabIndex = 26;
            // 
            // cboNeighbourhood
            // 
            this.cboNeighbourhood.FormattingEnabled = true;
            this.cboNeighbourhood.Location = new System.Drawing.Point(182, 49);
            this.cboNeighbourhood.Name = "cboNeighbourhood";
            this.cboNeighbourhood.Size = new System.Drawing.Size(178, 24);
            this.cboNeighbourhood.TabIndex = 25;
            // 
            // checkBedrooms
            // 
            this.checkBedrooms.AutoSize = true;
            this.checkBedrooms.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBedrooms.ForeColor = System.Drawing.Color.Black;
            this.checkBedrooms.Location = new System.Drawing.Point(12, 90);
            this.checkBedrooms.Name = "checkBedrooms";
            this.checkBedrooms.Size = new System.Drawing.Size(134, 22);
            this.checkBedrooms.TabIndex = 24;
            this.checkBedrooms.Text = "By Bed Rooms";
            this.checkBedrooms.UseVisualStyleBackColor = true;
            // 
            // checkNeighbourhood
            // 
            this.checkNeighbourhood.AutoSize = true;
            this.checkNeighbourhood.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNeighbourhood.ForeColor = System.Drawing.Color.Black;
            this.checkNeighbourhood.Location = new System.Drawing.Point(12, 51);
            this.checkNeighbourhood.Name = "checkNeighbourhood";
            this.checkNeighbourhood.Size = new System.Drawing.Size(169, 22);
            this.checkNeighbourhood.TabIndex = 23;
            this.checkNeighbourhood.Text = "By Neighbourhood";
            this.checkNeighbourhood.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(955, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 47);
            this.panel1.TabIndex = 51;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(3, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 19);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "Search House By ID";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 1);
            this.label1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.datagridAllHouses);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1583, 560);
            this.panel2.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(802, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Houses";
            // 
            // datagridAllHouses
            // 
            this.datagridAllHouses.BackColor = System.Drawing.Color.Silver;
            this.datagridAllHouses.Location = new System.Drawing.Point(13, 35);
            this.datagridAllHouses.Name = "datagridAllHouses";
            this.datagridAllHouses.Size = new System.Drawing.Size(1556, 516);
            this.datagridAllHouses.TabIndex = 1;
            // 
            // frmGuestHouses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1607, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "frmGuestHouses";
            this.Text = "frmGuestHouses";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel datagridAllHouses;
        private System.Windows.Forms.Label label2;
    }
}