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

namespace JungleKingdomThemePark_System
{
    public partial class frmStaff : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SAVAG3-SAV1OUR;Initial Catalog=JungleKingdomRecords;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataReader reader;
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jungleKingdomRecordsDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.jungleKingdomRecordsDataSet.STAFF);
            groupBox1.Hide();
            btnConfirmDelete.Hide();
            btnConfirmUpdate.Hide();
            lsbOutput.Hide();
            btnReturn.Hide();

            sTAFFBindingNavigator.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)//Add New Staff
        {
            groupBox1.Show();
            cmbStaffID.Enabled = false;
            btnAdd.Enabled = false;
            btnConfirmAdd.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            pbName.Hide();
            pbSurname.Hide();
            pbPassword.Hide();
            pbConfirm.Hide();
            lblConfirm.Hide();
            lblCreate.Hide();
            lblName.Hide();
            lblSurname.Hide();
            lblRole.Hide();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)//Confirm add
        {
            string name, surname, createP, confirmP, finalPassword;
            string role;

            name = txbFirstName.Text;
            surname = txbSurname.Text;
            createP = txbCreate.Text;
            confirmP = txbConfirm.Text;
            role = cmbRole.Text;
            finalPassword = "";


            if ((name != "") && (surname != "") && (createP != "")
                && (confirmP != "") && (role != ""))
            {
                if (createP.Length < 8)//Password Validation
                {
                    lblCreate.Show();
                    pbPassword.Show();
                    lblCreate.Text = "*password needs to be at least 8 characters long";
                }
                else
                {
                    if (createP == confirmP)
                    {
                        finalPassword = createP;
                        try
                        {
                            this.sTAFFTableAdapter.InsertStaff(name, surname, finalPassword, role);
                            MessageBox.Show("New Staff Member added");
                            this.sTAFFTableAdapter.Fill(this.jungleKingdomRecordsDataSet.STAFF);

                            txbFirstName.Clear();
                            txbSurname.Clear();
                            txbCreate.Clear();
                            txbConfirm.Clear();
                            cmbRole.Text = "";

                            btnConfirmAdd.Hide();
                            btnAdd.Enabled = true;
                            btnDelete.Show();
                            btnUpdate.Show();
                            groupBox1.Hide();

                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                    else if (createP != confirmP)
                    {
                        lblConfirm.Show();
                        pbConfirm.Show();
                        lblConfirm.Text = "Passwords do not match";
                    }
                }
            }
            else
            {
                if ((name == "") || (surname == "") || (createP == "")
                    || (confirmP == "") || cmbRole.SelectedIndex == 0)
                {
                    if (name == "")
                    {
                        pbName.Show();
                        lblName.Show();
                    }
                    if (surname == "")
                    {
                        pbSurname.Show();
                        lblSurname.Show();
                    }
                    if (createP == "")
                    {
                        pbPassword.Show();
                        lblCreate.Show();
                        lblCreate.Text = "Insert Password";
                    }
                    if (confirmP == "")
                    {
                        pbConfirm.Show();
                        lblConfirm.Show();
                        lblCreate.Text = "Insert Password";
                    }
                    if (cmbRole.SelectedIndex == 0)
                    {
                        lblRole.Show();
                    }
                }
            }

        }

        private void txbFirstName_TextChanged(object sender, EventArgs e)
        {
            lblName.Hide();
            lblSurname.Hide();
            lblCreate.Hide();
            lblConfirm.Hide();
            pbName.Hide();
            pbPassword.Hide();
            pbConfirm.Hide();
            pbSurname.Hide();
        }

        private void txbSurname_TextChanged(object sender, EventArgs e)
        {
            lblName.Hide();
            lblSurname.Hide();
            lblCreate.Hide();
            lblConfirm.Hide();
            pbName.Hide();
            pbPassword.Hide();
            pbConfirm.Hide();
            pbSurname.Hide();
        }

        private void txbCreate_TextChanged(object sender, EventArgs e)
        {
            lblName.Hide();
            lblSurname.Hide();
            lblCreate.Hide();
            lblConfirm.Hide();
            pbName.Hide();
            pbPassword.Hide();
            pbConfirm.Hide();
            pbSurname.Hide();
        }

        private void txbConfirm_TextChanged(object sender, EventArgs e)
        {
            lblName.Hide();
            lblSurname.Hide();
            lblCreate.Hide();
            lblConfirm.Hide();
            pbName.Hide();
            pbPassword.Hide();
            pbConfirm.Hide();
            pbSurname.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)//Update
        {
            cmbStaffID.Items.Clear();
            groupBox1.Show();
            btnUpdate.Enabled = false;
            btnAdd.Hide();
            btnDelete.Hide();
            btnConfirmDelete.Hide();
            btnConfirmAdd.Hide();
            btnConfirmUpdate.Show();
            txbFirstName.Enabled = false;
            txbSurname.Enabled = false;
            txbCreate.Enabled = false;
            txbConfirm.Enabled = false;
            cmbRole.Enabled = false;
            cmbStaffID.Enabled = true;
            pbName.Hide();
            pbSurname.Hide();
            pbPassword.Hide();
            pbConfirm.Hide();
            lblConfirm.Hide();
            lblCreate.Hide();
            lblName.Hide();
            lblSurname.Hide();
            lblRole.Hide();

            try
            {
                conn.Open();
                string sql = "SELECT Employee_ID FROM STAFF";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbStaffID.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)//ConfirmUpdate
        {
            string name, surname, createP, confirmP, finalPassword, role;
            int iD = int.Parse(cmbStaffID.Text);
            name = txbFirstName.Text;
            surname = txbSurname.Text;
            createP = txbCreate.Text;
            confirmP = txbConfirm.Text;
            role = cmbRole.Text;
            finalPassword = "";

            if ((name != "") && (surname != "") && (createP != "")
    && (confirmP != "") && (role != ""))
            {
                if (createP.Length < 8)//Password Validation
                {
                    lblCreate.Show();
                    pbPassword.Show();
                    lblCreate.Text = "*password needs to be at least 8 characters long";
                }
                else
                {
                    if (createP == confirmP)
                    {
                        finalPassword = createP;
                        try
                        {
                            this.sTAFFTableAdapter.UpdateStaff(name, surname, finalPassword, role, iD);
                            MessageBox.Show("Successfully updated the information");
                            this.sTAFFTableAdapter.Fill(this.jungleKingdomRecordsDataSet.STAFF);

                            txbFirstName.Clear();
                            txbSurname.Clear();
                            txbCreate.Clear();
                            txbConfirm.Clear();
                            cmbRole.Text = "";

                            btnConfirmAdd.Hide();
                            btnUpdate.Enabled = true;
                            btnDelete.Show();
                            btnUpdate.Show();
                            btnAdd.Show();
                            groupBox1.Hide();
                            cmbStaffID.Text = "";

                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                    else if (createP != confirmP)
                    {
                        lblConfirm.Show();
                        pbConfirm.Show();
                        lblConfirm.Text = "Passwords do not match";
                    }
                }
            }
            else
            {
                if ((name == "") || (surname == "") || (createP == "")
                    || (confirmP == "") || cmbRole.SelectedIndex == 0)
                {
                    if (name == "")
                    {
                        pbName.Show();
                        lblName.Show();
                    }
                    if (surname == "")
                    {
                        pbSurname.Show();
                        lblSurname.Show();
                    }
                    if (createP == "")
                    {
                        pbPassword.Show();
                        lblCreate.Show();
                        lblCreate.Text = "Insert Password";
                    }
                    if (confirmP == "")
                    {
                        pbConfirm.Show();
                        lblConfirm.Show();
                        lblCreate.Text = "Insert Password";
                    }
                    if (cmbRole.SelectedIndex == 0)
                    {
                        lblRole.Show();
                    }
                }
            }

        }

        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iD = int.Parse(cmbStaffID.Text);
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM STAFF WHERE Employee_ID = '{iD}'";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txbFirstName.Text = (string)reader.GetValue(1);
                    txbSurname.Text = (string)reader.GetValue(2);
                    txbCreate.Text = (string)reader.GetValue(3);
                    cmbRole.Text = (string)reader.GetValue(4);
                }
                conn.Close();

                txbCreate.Enabled = true;
                txbFirstName.Enabled = true;
                txbSurname.Enabled = true;
                txbConfirm.Enabled = true;
                cmbRole.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//Delete
        {
            cmbStaffID.Items.Clear();
            groupBox1.Show();
            btnDelete.Enabled = false;
            btnAdd.Hide();
            btnUpdate.Hide();
            btnConfirmDelete.Show();
            btnConfirmAdd.Hide();
            btnConfirmUpdate.Hide();
            txbFirstName.Enabled = false;
            txbSurname.Enabled = false;
            txbCreate.Enabled = false;
            txbConfirm.Enabled = false;
            cmbRole.Enabled = false;
            cmbStaffID.Enabled = true;
            pbName.Hide();
            pbSurname.Hide();
            pbPassword.Hide();
            pbConfirm.Hide();
            lblConfirm.Hide();
            lblCreate.Hide();
            lblName.Hide();
            lblSurname.Hide();
            lblRole.Hide();
            label3.Text = "Password:";
            label5.Hide();
            txbConfirm.Hide();

            try
            {
                conn.Open();
                string sql = "SELECT Employee_ID FROM STAFF";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbStaffID.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)//ConfrimDelete
        {
            int iD = int.Parse(cmbStaffID.Text);
            txbCreate.Enabled=false;
            txbFirstName.Enabled=false;
            txbSurname.Enabled=false;
            cmbRole.Enabled=false;

            if (MessageBox.Show("Are you sure you want to delete the information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = $"DELETE FROM STAFF_ON_DUTY WHERE Employee_ID = '{iD}'";
                    command = new SqlCommand(sql, conn);
                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    conn.Close();
                    this.sTAFFTableAdapter.DeleteQuery(iD);
                    MessageBox.Show("Staff Information has been sucessfully deleted");
                    this.sTAFFTableAdapter.Fill(this.jungleKingdomRecordsDataSet.STAFF);

                    txbFirstName.Clear();
                    txbSurname.Clear();
                    txbCreate.Clear();
                    txbConfirm.Clear();
                    txbConfirm.Show();
                    label3.Text = "Create Password:";
                    cmbRole.Text = "";

                    btnConfirmDelete.Hide();
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDelete.Show();
                    btnUpdate.Show();
                    btnAdd.Show();
                    groupBox1.Hide();
                    cmbStaffID.Text = "";
                    label5.Show();
                    txbCreate.Enabled = true;
                    txbFirstName.Enabled = true;
                    txbSurname.Enabled = true;
                    cmbRole.Enabled = true;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM STAFF WHERE Employee_Name LIKE '%{txbSearch.Text}%'";
                command = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "STAFF");

                sTAFFDataGridView.DataSource = ds;
                sTAFFDataGridView.DataMember = "STAFF";

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)//Help function
        {
            sTAFFDataGridView.Hide();
            lsbOutput.Show();
            lsbOutput.Items.Add("Return To Main Menu:");
            lsbOutput.Items.Add("If you wish to go back to the main menu Click the Return To Main Menu button.");
            lsbOutput.Items.Add("Add New Staff:");
            lsbOutput.Items.Add("To add a new Staff Member Click on the Add New Staff button.");
            lsbOutput.Items.Add("Delete Staff:");
            lsbOutput.Items.Add("If you wish to Remove a old Staff Member please Click the Delete button.");
            lsbOutput.Items.Add("Update Staff: ");
            lsbOutput.Items.Add("When you want to Update information about a Staff Member Click the Update button.");
            btnReturn.Show();
            groupBox1.Hide();

            txbSearch.Hide();
            pbHelp.Hide();
            lblHelp.Hide();
            label8.Hide();
            btnMenu.Hide();
            pictureBox1.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnAdd.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            lsbOutput.Hide();
            btnReturn.Hide();
            sTAFFDataGridView.Show();
            txbSearch.Show();
            pbHelp.Show();
            lblHelp.Show();
            label8.Show();
            btnMenu.Show();
            pictureBox1.Show();
            btnDelete.Show();
            btnUpdate.Show();
            btnAdd.Show();
        }

        private void sTAFFBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTAFFBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);

        }
    }
}
