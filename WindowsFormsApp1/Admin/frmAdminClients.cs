using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.Admin
{
    public partial class frmAdminClients : Form
    {
        public frmAdminClients()
        {
            InitializeComponent();
        }

        DataTable tabEmployees, tabBranch, tabClients;
        DataGridViewCell cell = null;
        int CurrentRow;
        string mode = "";

        private void ButtonActivation(bool HoseID, bool Name, bool Phone, bool Email, bool BranchName, bool BranchId, bool ClientTitle, bool Add, bool Edit, bool Delete, bool Save, bool Cancel)
        {
            txtClientID.ReadOnly = HoseID;
            txtName.ReadOnly = Name;
            txtPhone.ReadOnly = Phone;
            txtEmail.ReadOnly = Email;
            cmbBranchName.Enabled = BranchName;
            txtBranchID.ReadOnly = BranchId;
            cmbClientTitle.Enabled = ClientTitle;
            btnAdd.Enabled = Add;
            btnEdit.Enabled = Edit;
            btnDelete.Enabled = Delete;
            btnSave.Enabled = Save;
            btnCancel.Enabled = Cancel;

        }


        private void frmAdminClients_Load(object sender, EventArgs e)
        {
            ButtonActivation(true, true, true, true, false, true, false, true, true, true, false, false);


            tabBranch = clsGlobal.mySet.Tables["Branches"];
            tabClients = clsGlobal.mySet.Tables["Clients"];
            tabEmployees = clsGlobal.mySet.Tables["Employees"];
            datagridAllClients.DataSource = clsGlobal.mySet.Tables["Clients"];


            foreach (DataRow myRow in tabBranch.Rows)
            {
                cmbBranchName.Items.Add(myRow["Location"]).ToString().Distinct();

                List<object> list = new List<object>();
                foreach (object o in cmbBranchName.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cmbBranchName.Items.Clear();
                cmbBranchName.Items.AddRange(list.ToArray());

            }

            foreach (DataRow Client in tabClients.Rows)
            {
                cmbClientTitle.Items.Add(Client["ClientStatus"]).ToString().Distinct();


                List<object> list = new List<object>();
                foreach (object o in cmbClientTitle.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cmbClientTitle.Items.Clear();
                cmbClientTitle.Items.AddRange(list.ToArray());

            }
            cmbClientTitle.SelectedIndex = 0;
            cmbBranchName.SelectedIndex = 0;
        }


        private void datagridAllClients_SelectionChanged(object sender, EventArgs e)
        {

            foreach (DataGridViewCell selectCell in datagridAllClients.SelectedCells)
            {
                cell = selectCell;

                break;
            }
            try
            {


                if (cell != null)
                {
                    DataGridViewRow myRow = cell.OwningRow;

                    txtClientID.Text = myRow.Cells["ClientID"].Value.ToString();
                    txtName.Text = myRow.Cells["ClientName"].Value.ToString();
                    cmbClientTitle.Text = myRow.Cells["ClientStatus"].Value.ToString();
                    txtPhone.Text = myRow.Cells["Phone"].Value.ToString();
                    txtEmail.Text = myRow.Cells["E-mail"].Value.ToString();
                    txtBranchID.Text = myRow.Cells["BranchID"].Value.ToString();





                    foreach (DataRow Branch in tabBranch.Rows)
                    {
                        if (Branch["BranchID"].ToString() == txtBranchID.Text)
                        {
                            cmbBranchName.SelectedItem = Branch["Location"].ToString();

                        }
                    }


                    CurrentRow = datagridAllClients.CurrentRow.Index;
                }
            }
            catch
            {

                datagridAllClients.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];

            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            ButtonActivation(false, false, false, false, true, true, true, false, false, false, true, true);
            txtClientID.Text = txtName.Text = txtClientID.Text = txtPhone.Text = txtEmail.Text = txtBranchID.Text = " ";
            txtClientID.Focus();


            cmbClientTitle.SelectedIndex = 0;
            cmbBranchName.SelectedIndex = 0;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            ButtonActivation(true, false, false, false, true, true, true, false, false, false, true, true);
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this Client ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabClients.Rows[CurrentRow].Delete();


                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.mySet, "Clients");
                clsGlobal.mySet.Tables.Remove("Clients");
                clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");


                datagridAllClients.Rows[0].Selected = true;


            }
        }


        private void cmbBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow branch in tabBranch.Rows)
            {
                if (cmbBranchName.SelectedItem.ToString() == branch["Location"].ToString())
                {
                    txtBranchID.Text = branch["BranchID"].ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow MyClient;

            if (mode == "add")
            {


                try
                {

                    if (txtClientID.Text != " ")
                    {




                        MyClient = tabClients.NewRow();
                        MyClient["ClientID"] = txtClientID.Text;
                        MyClient["ClientName"] = txtName.Text;
                        MyClient["ClientStatus"] = cmbClientTitle.Text;
                        MyClient["Phone"] = txtPhone.Text;
                        MyClient["E-mail"] = txtEmail.Text;
                        MyClient["BranchID"] = txtBranchID.Text;



                        try
                        {
                            tabClients.Rows.Add(MyClient);
                            SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClients);
                            clsGlobal.adpClients.Update(clsGlobal.mySet, "Clients");
                            clsGlobal.mySet.Tables.Remove("Clients");
                            clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");


                        }
                        catch
                        {
                            MessageBox.Show("This ID is already exist, sorry", "Adding Fails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtClientID.Focus();
                            return;
                        }


                    }

                }
                catch
                {
                    MessageBox.Show("Please fill all the textboxes after make sure that they are in the correct format please.", "Empty Fields Or Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {

                DataRow Client = tabClients.Rows[CurrentRow];


                Client["ClientName"] = txtName.Text;
                Client["ClientStatus"] = cmbClientTitle.Text;
                Client["Phone"] = txtPhone.Text;
                Client["E-mail"] = txtEmail.Text;
                Client["BranchID"] = txtBranchID.Text;



                SqlCommandBuilder myBuilderr = new SqlCommandBuilder(clsGlobal.adpClients);
                clsGlobal.adpClients.Update(clsGlobal.mySet, "Clients");
                clsGlobal.mySet.Tables.Remove("Clients");
                clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");
            }

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonActivation(true, true, true, true, false, true, false, true, true, true, false, false);
            txtClientID.Text = txtName.Text = txtClientID.Text = txtPhone.Text = txtEmail.Text = txtBranchID.Text = " ";
            txtClientID.Focus();

            datagridAllClients.Rows[0].Selected = true;
        }






    }
 }
       



