using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Admin;
using WindowsFormsApp1.Guest;
using WindowsFormsApp1.Agent;
using WindowsFormsApp1.Class;


namespace WindowsFormsApp1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public static DataTable tabEmployees, tabBranch;
        public static string currentAgent, currentAdmin;
        public static DataTable Ep = new DataTable();

        clsManager mg = new clsManager();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "User Name")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;

            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "User Name";


            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";


            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";

 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimaiz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }




        public void LoginAdmin(string username, string password)
        {
            string cmd = "SELECT * FROM Employees WHERE Username = @username  AND Pin = @password";
            clsGlobal.adpEmployees = new SqlDataAdapter("SELECT * FROM Employees WHERE Username ='" + username + "' AND Pin ='" + password + "' ", clsGlobal.myCon);



            try
            {

                clsGlobal.myCon = new SqlConnection(@"Data Source=DESKTOP-2R9T45K\SQLEXPRESS;Initial Catalog=Remax;Integrated Security=True");
                clsGlobal.myCon.Open();

                clsGlobal.myCmd = new SqlCommand(cmd, clsGlobal.myCon);
                clsGlobal.myCmd.Parameters.AddWithValue("@username", username);
                clsGlobal.myCmd.Parameters.AddWithValue("@password", password);
                SqlDataReader empReader = clsGlobal.myCmd.ExecuteReader(CommandBehavior.SingleRow);
                clsGlobal.adpEmployees.Fill(Ep);




                if (empReader.Read())
                {


                    if (empReader["Username"].ToString() != username || empReader["Pin"].ToString() != password)
                    {
                        MessageBox.Show("Username or Password is not correct! please try again.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Text = " ";
                        txtPass.Text = "";
                        txtUser.Focus();
                    }
                    else
                    {
                        if (empReader["Position"].ToString() != "Admin")
                        {
                            MessageBox.Show("You are not a Manager! please try other options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            radioBtnGuest.Checked.ToString();

                        }
                        else
                        {
                            tabBranch = clsGlobal.mySet.Tables["Branches"];

                            foreach (DataRow myRow in tabBranch.Rows)
                            {
                                if (empReader["BranchID"].ToString() == myRow["BranchID"].ToString())
                                {
                                    string selectBranch = myRow["Location"].ToString();

                                    if (cmbBranch.SelectedItem.ToString() == selectBranch.ToString())
                                    {
                                        mg.EmployeeID = empReader["EmployeeID"].ToString();
                                        mg.Name = empReader["Name"].ToString();
                                        tabEmployees = clsGlobal.mySet.Tables["Employees"];


                                        frmAdmin fc = new frmAdmin();
                                        fc.Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("This Manager is not exist in this branch! Please select other branches", "Manager Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }

                                }
                            }


                        }
                    }

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Something is wrong! please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }



        public void LoginAgent(string username, string password)
        {
            string cmd = "SELECT * FROM Employees WHERE Username = @username  AND Pin = @password";
            tabEmployees = clsGlobal.mySet.Tables["Employees"];
            try
            {

                clsGlobal.myCon = new SqlConnection(@"Data Source=DESKTOP-2R9T45K\SQLEXPRESS;Initial Catalog=Remax;Integrated Security=True");
                clsGlobal.myCon.Open();

                clsGlobal.myCmd = new SqlCommand(cmd, clsGlobal.myCon);
                clsGlobal.myCmd.Parameters.AddWithValue("@username", username);
                clsGlobal.myCmd.Parameters.AddWithValue("@password", password);
                SqlDataReader empReader = clsGlobal.myCmd.ExecuteReader(CommandBehavior.SingleRow);



                if (empReader.Read())
                {


                    if (empReader["Username"].ToString() != username || empReader["Pin"].ToString() != password)
                    {
                        MessageBox.Show("Username or Password is not correct! please try again.", "Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Text = " ";
                        txtPass.Text = "";
                        txtUser.Focus();
                    }
                    else
                    {
                        if (empReader["Position"].ToString() != "Agent")
                        {
                            MessageBox.Show("You are not an Agent! please try other options.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            radioBtnGuest.Checked.ToString();

                        }
                        else
                        {
                            tabBranch = clsGlobal.mySet.Tables["Branches"];

                            foreach (DataRow myRow in tabBranch.Rows)
                            {
                                if (empReader["BranchID"].ToString() == myRow["BranchID"].ToString())
                                {
                                    string selectBranch = myRow["Location"].ToString();

                                    if (cmbBranch.SelectedItem.ToString() == selectBranch.ToString())
                                    {

                                        foreach (DataRow Employee in tabEmployees.Rows)
                                        {
                                            if (empReader["Username"].ToString() == Employee["Username"].ToString())
                                            {
                                                currentAgent = Employee["EmployeeID"].ToString();
                                            }
                                        }


                                        frmAgent Ag = new frmAgent();
                                        Ag.Show();

                                    }
                                    else
                                    {
                                        MessageBox.Show("This Agent is not exist in this branch! Please select other branches", "Manager Not Exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }

                                }
                            }


                        }
                    }

                }
                empReader.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Something is wrong! please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }



        private void btnLogin_Click(object sender, EventArgs e)
        {


            if (radioBtnAdmin.Checked)
            {
                if (txtUser.Text != "User Name")
                {
                    if (txtPass.Text != "Password")
                    {
                        LoginAdmin(txtUser.Text, txtPass.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your User Name and Password.", "Fields Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioBtnAgent.Checked)
            {
                if (txtUser.Text != "User Name")
                {
                    if (txtPass.Text != "Password")
                    {
                        LoginAgent(txtUser.Text, txtPass.Text);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter your User Name and Password.", "Fields Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (radioBtnGuest.Checked)
            {
                frmGuest GU = new frmGuest();
                GU.Show();
            }





        }

        private void radioBtnGuest_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.ReadOnly = true;
            txtUser.ReadOnly = true;
            txtPass.Text = "Guest";
            txtUser.Text = "Guest";
        }

        private void radioBtnAgent_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.ResetText();
            txtPass.ResetText();
            txtPass.ReadOnly = false;
            txtUser.ReadOnly = false;
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";

            }
            if (txtUser.Text == "")
            {
                txtUser.Text = "User Name";

            }
        }

        private void radioBtnAdmin_CheckedChanged(object sender, EventArgs e)
        {
            txtUser.ResetText();
            txtPass.ResetText();
            txtPass.ReadOnly = false;
            txtUser.ReadOnly = false;
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.DimGray;
                txtPass.UseSystemPasswordChar = false;
   
            }
            if (txtUser.Text == "")
            {
                txtUser.Text = "User Name";
                txtUser.ForeColor = Color.DimGray;
      
            }
        }

        

        private void LoginPage_Load_1(object sender, EventArgs e)
        {
            clsGlobal.mySet = new DataSet();

            clsGlobal.myCon = new SqlConnection(@"Data Source=DESKTOP-2R9T45K\SQLEXPRESS;Initial Catalog=Remax;Integrated Security=True");
            clsGlobal.myCon.Open();


            SqlCommand myCmd = new SqlCommand("SELECT * FROM Branches", clsGlobal.myCon);
            clsGlobal.adpBranches = new SqlDataAdapter(myCmd);
            clsGlobal.adpBranches.Fill(clsGlobal.mySet, "Branches");



            myCmd = new SqlCommand("SELECT * FROM Clients", clsGlobal.myCon);
            clsGlobal.adpClients = new SqlDataAdapter(myCmd);
            clsGlobal.adpClients.Fill(clsGlobal.mySet, "Clients");



            myCmd = new SqlCommand("SELECT * FROM Employees", clsGlobal.myCon);
            clsGlobal.adpEmployees = new SqlDataAdapter(myCmd);
            clsGlobal.adpEmployees.Fill(clsGlobal.mySet, "Employees");



            myCmd = new SqlCommand("SELECT * FROM Houses", clsGlobal.myCon);
            clsGlobal.adpHouses = new SqlDataAdapter(myCmd);
            clsGlobal.adpHouses.Fill(clsGlobal.mySet, "Houses");


            myCmd = new SqlCommand("SELECT * FROM HouseFeatures", clsGlobal.myCon);
            clsGlobal.adpHouseFeatures = new SqlDataAdapter(myCmd);
            clsGlobal.adpHouseFeatures.Fill(clsGlobal.mySet, "HouseFeatures");



            tabBranch = clsGlobal.mySet.Tables["Branches"];


            foreach (DataRow myRow in tabBranch.Rows)
            {
                cmbBranch.Items.Add(myRow["Location"]).ToString().Distinct();
                List<object> list = new List<object>();
                foreach (object o in cmbBranch.Items)
                {
                    if (!list.Contains(o))
                    {
                        list.Add(o);
                    }
                }
                cmbBranch.Items.Clear();
                cmbBranch.Items.AddRange(list.ToArray());

            }




            cmbBranch.SelectedIndex = 0;
        }

       
        


    }
}
