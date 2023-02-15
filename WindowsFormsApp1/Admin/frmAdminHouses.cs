﻿using System;
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
    public partial class frmAdminHouses : Form
    {
        DataTable tabEmployees, tabBranch, tabHouses, tabHouseFeatures, tabClients;
        DataGridViewCell cell = null;
        int CurrentRow;
        string mode = "";

        public frmAdminHouses()
        {
            InitializeComponent();
        }

        private void ButtonActivation(bool HoseID, bool EmployeeName, bool EmployeeID, bool ClientNamee, bool ClientID, bool Neighbourhood, bool Bed, bool Price, bool Adress,
           bool Description, bool Status, bool BuiltIn, bool Typee, bool BranchNamee, bool branchID, bool Pool, bool elavator, bool Add, bool Edit, bool Delete, bool Save, bool Cancel)
        {
            txtHouseID.ReadOnly = HoseID;
            cmbEmployeeName.Enabled = EmployeeName;
            cboClientName.Enabled = ClientNamee;
            txtClientID.ReadOnly = ClientID;
            txtEmployeeID.ReadOnly = EmployeeID;
            txtNeighbourhood.ReadOnly = Neighbourhood;
            txtBed.ReadOnly = Bed;
            txtPrice.ReadOnly = Price;
            txtAdress.ReadOnly = Adress;
            txtDescription.ReadOnly = Description;
            cboStatus.Enabled = Status;
            txtBuilt.Enabled = BuiltIn;
            cmbType.Enabled = Typee;
            cmbBranchName.Enabled = BranchNamee;
            txtBranchID.ReadOnly = branchID;
            cboPool.Enabled = Pool;
            cboElevator.Enabled = elavator;
            btnAdd.Enabled = Add;
            btnEdit.Enabled = Edit;
            btnDelete.Enabled = Delete;
            btnSave.Enabled = Save;
            btnCancel.Enabled = Cancel;

        }



        private void frmAdminHouses_Load(object sender, EventArgs e)
        {

            ButtonActivation(true, false, true, false, true, true, true, true, true, true, false, false, false, false, true, false, false, true, true, true, false, false);
            tabHouseFeatures = clsGlobal.mySet.Tables["HouseFeatures"];
            tabHouses = clsGlobal.mySet.Tables["Houses"];
            tabBranch = clsGlobal.mySet.Tables["Branches"];
            tabClients = clsGlobal.mySet.Tables["Clients"];
            tabEmployees = clsGlobal.mySet.Tables["Employees"];
            datagridAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];




            foreach (DataRow myRow in tabHouseFeatures.Rows)
            {

                cmbType.Items.Add(myRow["Building Type"]).ToString().Distinct();
                List<object> list = new List<object>();
                foreach (object o in cmbType.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cmbType.Items.Clear();
                cmbType.Items.AddRange(list.ToArray());


               
                cboPool.Items.Add(myRow["Pool"]).ToString().Distinct();
                List<object> list1 = new List<object>();
                foreach (object o in cboPool.Items)
                {
                    if (!list1.Contains(o))
                    {
                        list1.Add(o);
                    }
                }
                cboPool.Items.Clear();
                cboPool.Items.AddRange(list1.ToArray());

             
                cboElevator.Items.Add(myRow["Elevator"]).ToString().Distinct();
                List<object> list2 = new List<object>();
                foreach (object o in cboElevator.Items)
                {
                    if (!list2.Contains(o))
                    {
                        list2.Add(o);
                    }
                }
                cboElevator.Items.Clear();
                cboElevator.Items.AddRange(list2.ToArray());
            }

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

            
            foreach (DataRow myRow in tabHouses.Rows)
            {
                cboStatus.Items.Add(myRow["Status"]).ToString().Distinct();

                
                List<object> list = new List<object>();
                foreach (object o in cboStatus.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cboStatus.Items.Clear();
                cboStatus.Items.AddRange(list.ToArray());

            }

            
            foreach (DataRow Employee in tabEmployees.Rows)
            {
                cmbEmployeeName.Items.Add(Employee["Name"]).ToString();
            }

            
            foreach (DataRow Client in tabClients.Rows)
            {
                cboClientName.Items.Add(Client["ClientName"].ToString());
            }


            cboStatus.SelectedIndex = 0;
            cmbBranchName.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            cboPool.SelectedIndex = 0;
            cboElevator.SelectedIndex = 0;



        }

        
        private void datagridAllHouses_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewCell selectCell in datagridAllHouses.SelectedCells)
            {
                cell = selectCell;

                break;
            }
            try
            {


                if (cell != null)
                {
                    DataGridViewRow myRow = cell.OwningRow;

                    txtHouseID.Text = myRow.Cells["EstateID"].Value.ToString();
                    txtNeighbourhood.Text = myRow.Cells["Neighbourhood"].Value.ToString();
                    txtBed.Text = myRow.Cells["BedRooms"].Value.ToString();
                    txtPrice.Text = myRow.Cells["Price"].Value.ToString();
                    txtBuilt.Text = myRow.Cells["Built in"].Value.ToString();
                    cmbType.Text = myRow.Cells["Building Type"].Value.ToString();
                    cboPool.Text = myRow.Cells["Pool"].Value.ToString();
                    cboElevator.Text = myRow.Cells["Elevator"].Value.ToString();
                    txtAdress.Text = myRow.Cells["Address"].Value.ToString();
                    txtDescription.Text = myRow.Cells["Description"].Value.ToString();


                    
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            foreach (DataRow Clients in tabClients.Rows)
                            {
                                if (Clients["ClientID"].ToString() == Houses["ClientID"].ToString())
                                {
                                    cboClientName.Text = Clients["ClientName"].ToString();
                                    txtClientID.Text = Clients["ClientID"].ToString();
                                }
                            }
                        }
                    }


                    
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            foreach (DataRow Employees in tabEmployees.Rows)
                            {
                                if (Employees["EmployeeID"].ToString() == Houses["EmployeeID"].ToString())
                                {
                                    cmbEmployeeName.Text = Employees["Name"].ToString();
                                }
                            }
                        }
                    }


                    
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            cboStatus.Text = Houses["Status"].ToString();
                            txtBranchID.Text = Houses["BranchID"].ToString();

                        }
                    }

                    
                    foreach (DataRow Houses in tabHouses.Rows)
                    {
                        if (Houses["EstateID"].ToString() == txtHouseID.Text)
                        {
                            foreach (DataRow branch in tabBranch.Rows)
                            {
                                if (Houses["BranchID"].ToString() == branch["BranchID"].ToString())
                                {
                                    cmbBranchName.SelectedItem = branch["Location"].ToString();
                                }
                            }
                        }
                    }


                    CurrentRow = datagridAllHouses.CurrentRow.Index;
                }
            }
            catch
            {

                datagridAllHouses.DataSource = clsGlobal.mySet.Tables["HouseFeatures"];

            }
        }



        private void cmbBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow Branch in tabBranch.Rows)
            {


                if (cmbBranchName.SelectedItem.ToString() == Branch["Location"].ToString())
                {
                    txtBranchID.Text = Branch["BranchID"].ToString();
                }

            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            ButtonActivation(false, true, true, true, true, false, false, false, false, false, true, true, true, true, true, true, true, false, false, false, true, true);
            txtHouseID.Text = txtEmployeeID.Text = cboClientName.Text = txtClientID.Text = cmbEmployeeName.Text = txtNeighbourhood.Text = txtBed.Text = txtPrice.Text = txtBuilt.Text = txtDescription.Text = txtAdress.Text = " ";
            txtHouseID.Focus();

            cboStatus.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            cmbBranchName.SelectedIndex = 0;
            cboPool.SelectedIndex = 0;
            cboElevator.SelectedIndex = 0;
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            ButtonActivation(false, true, true, true, true, false, false, false, false, false, true, true, true, true, true, true, true, false, false, false, true, true);
            cboClientName.Focus();

        }

        
        private void cboClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow Client in tabClients.Rows)
            {
                if (cboClientName.SelectedItem.ToString() == Client["ClientName"].ToString())
                {
                    txtClientID.Text = Client["ClientID"].ToString();
                }
            }
        }



        
        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow employee in tabEmployees.Rows)
            {
                if (cmbEmployeeName.Text == employee["Name"].ToString())
                {
                    txtEmployeeID.Text = employee["EmployeeID"].ToString();
                }
            }

        }

        private void txtEmployeeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSerach_Click(object sender, EventArgs e)
        {

        }

        
        private void cmbBranchName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (DataRow branch in tabBranch.Rows)
            {
                if (cmbBranchName.SelectedItem.ToString() == branch["Location"].ToString())
                {
                    txtBranchID.Text = branch["BranchID"].ToString();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int currentEstate = Convert.ToInt32(txtHouseID.Text);
            if (MessageBox.Show("Are you sure to delete this company ?", "Deletion Warning",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                tabHouses.Rows[CurrentRow].Delete();
                tabHouseFeatures.Rows[CurrentRow].Delete();




                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");
                clsGlobal.mySet.Tables.Remove("Houses");
                clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "Houses");


                myBuilder = new SqlCommandBuilder(clsGlobal.adpHouseFeatures);
                clsGlobal.adpHouseFeatures.Update(clsGlobal.mySet, "HouseFeatures");
                clsGlobal.mySet.Tables.Remove("HouseFeatures");
                clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "HouseFeatures");



                datagridAllHouses.Rows[0].Selected = true;


            }



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow myHouse, myHouseFeature;
            int EstateCheck = Convert.ToInt32(txtHouseID.Text);
            if (mode == "add")
            {


                try
                {

                    if (txtHouseID.Text != " ")
                    {




                        myHouse = tabHouses.NewRow();
                        myHouse["EstateID"] = txtHouseID.Text;
                        myHouse["Status"] = cboStatus.Text;
                        myHouse["ClientID"] = txtClientID.Text;
                        myHouse["EmployeeID"] = txtEmployeeID.Text;
                        myHouse["BranchID"] = txtBranchID.Text;



                        myHouseFeature = tabHouseFeatures.NewRow();
                        myHouseFeature["EstateID"] = txtHouseID.Text;
                        myHouseFeature["Building Type"] = cmbType.Text;
                        myHouseFeature["BedRooms"] = txtBed.Text;
                        myHouseFeature["Built in"] = txtBuilt.Text;
                        myHouseFeature["Neighbourhood"] = txtNeighbourhood.Text;
                        myHouseFeature["Address"] = txtAdress.Text;
                        myHouseFeature["Price"] = txtPrice.Text;
                        myHouseFeature["Description"] = txtDescription.Text;
                        myHouseFeature["Pool"] = cboPool.Text;
                        myHouseFeature["Elevator"] = cboElevator.Text;


                        try
                        {
                            tabHouses.Rows.Add(myHouse); 
                            SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                            clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");
                            clsGlobal.mySet.Tables.Remove("Houses");
                            clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");


                            tabHouseFeatures.Rows.Add(myHouseFeature);
                            myBuilder = new SqlCommandBuilder(clsGlobal.adpHouseFeatures);
                            clsGlobal.adpHouseFeatures.Update(clsGlobal.mySet, "HouseFeatures");
                            clsGlobal.mySet.Tables.Remove("HouseFeatures");
                            clsGlobal.adpHouseFeatures.Fill(clsGlobal.mySet, "HouseFeatures");
                        }
                        catch
                        {
                            MessageBox.Show("This House ID is already exist", "Adding Fails", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtHouseID.Focus();
                            return;
                        }




                    }


                }
                catch
                {
                    MessageBox.Show("Please fill all the textboxes and make sure they are in the correct format.", "Empty Fields Or Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            else
            {


                DataRow MyHouse = tabHouses.Rows[CurrentRow];
                DataRow MyHouseFeature = tabHouseFeatures.Rows[CurrentRow];





                MyHouse["Status"] = cboStatus.Text;
                MyHouse["ClientID"] = txtClientID.Text;
                MyHouse["EmployeeID"] = txtEmployeeID.Text;
                MyHouse["BranchID"] = txtBranchID.Text;




                MyHouseFeature["Building Type"] = cboType.Text;
                MyHouseFeature["BedRooms"] = txtBed.Text;
                MyHouseFeature["Built in"] = txtBuilt.Text;
                MyHouseFeature["Neighbourhood"] = txtNeighbourhood.Text;
                MyHouseFeature["Address"] = txtAdress.Text;
                MyHouseFeature["Price"] = txtPrice.Text;
                MyHouseFeature["Description"] = txtDescription.Text;
                MyHouseFeature["Pool"] = cboPool.Text;
                MyHouseFeature["Elevator"] = cboElevator.Text;


                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpHouses);
                clsGlobal.adpHouses.Update(clsGlobal.mySet, "Houses");
                clsGlobal.mySet.Tables.Remove("Houses");
                clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");



                SqlCommandBuilder myBuilderr = new SqlCommandBuilder(clsGlobal.adpHouseFeatures);
                clsGlobal.adpHouseFeatures.Update(clsGlobal.mySet, "HouseFeatures");
                clsGlobal.mySet.Tables.Remove("HouseFeatures");
                clsGlobal.adpHouseFeatures.Fill(clsGlobal.mySet, "HouseFeatures");
            }

            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = btnCancel.Enabled = false;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            ButtonActivation(true, false, true, false, true, true, true, true, true, true, false, false, false, false, true, false, false, true, true, true, false, false);
            txtHouseID.Text = txtEmployeeID.Text = cboClientName.Text = txtClientID.Text = cmbEmployeeName.Text = txtNeighbourhood.Text = txtBed.Text = txtPrice.Text = txtBuilt.Text = txtDescription.Text = txtAdress.Text = " ";
            txtHouseID.Focus();
            datagridAllHouses.Rows[0].Selected = true;
        }




    }
}
