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
    public partial class frmRides : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SAVAG3-SAV1OUR;Initial Catalog=JungleKingdomRecords;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataReader reader;
        public frmRides()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void frmRides_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jungleKingdomRecordsDataSet.RIDES' table. You can move, or remove it, as needed.
            this.rIDESTableAdapter.Fill(this.jungleKingdomRecordsDataSet.RIDES);
            groupBox1.Hide();
            btnConfirmDelete.Hide();
            btnConfirmUpdate.Hide();
            lsbOutput.Hide();
            btnReturn.Hide();
            rIDESBindingNavigator.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)//Add Ride
        {
            groupBox1.Show();
            cmbRideID.Enabled = false;
            btnAdd.Enabled = false;
            btnConfirmAdd.Show();
            btnConfirmDelete.Hide();
            btnConfirmUpdate.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();
            lblName.Hide();
            pbName.Hide();
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)//Confirm Add
        {
            string rideName = txbRide.Text;

            if (rideName != "")
            {
                try
                {
                    this.rIDESTableAdapter.InsertRide(rideName);
                    MessageBox.Show("New Ride added");
                    this.rIDESTableAdapter.Fill(this.jungleKingdomRecordsDataSet.RIDES);

                    txbRide.Clear();

                    btnConfirmAdd.Hide();
                    btnAdd.Enabled = true;
                    btnDelete.Show();
                    btnUpdate.Show();
                    groupBox1.Hide();
                    cmbRideID.Text = "";

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                pbName.Show();
                lblName.Show();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)//Update
        {
            cmbRideID.Items.Clear();
            groupBox1.Show();
            btnUpdate.Enabled = false;
            btnAdd.Hide();
            btnDelete.Hide();
            btnConfirmDelete.Hide();
            btnConfirmAdd.Hide();
            btnConfirmUpdate.Show();
            txbRide.Enabled = false;
            cmbRideID.Enabled = true;
            pbName.Hide();
            lblName.Hide();

            try
            {
                conn.Open();
                string sql = "SELECT Ride_ID FROM RIDES";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbRideID.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)//Confirm Update
        {
            string rideName = txbRide.Text;
            int iD = int.Parse(cmbRideID.Text);

            if (rideName != "")
            {
                try
                {
                    this.rIDESTableAdapter.UpdateRides(rideName, iD);
                    MessageBox.Show("Successfully updated the ride information");
                    this.rIDESTableAdapter.Fill(this.jungleKingdomRecordsDataSet.RIDES);

                    txbRide.Clear();

                    btnConfirmAdd.Hide();
                    btnUpdate.Enabled = true;
                    btnDelete.Show();
                    btnUpdate.Show();
                    btnAdd.Show();
                    groupBox1.Hide();
                    cmbRideID.Text = "";

                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                pbName.Show();
                lblName.Show();
            }
        }

        private void cmbRideID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iD = int.Parse(cmbRideID.Text);
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM RIDES WHERE Ride_ID = '{iD}'";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txbRide.Text = (string)reader.GetValue(1);
                }
                conn.Close();

                txbRide.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//Delete
        {
            cmbRideID.Items.Clear();
            groupBox1.Show();
            btnDelete.Enabled = false;
            btnAdd.Hide();
            btnUpdate.Hide();
            btnConfirmDelete.Show();
            btnConfirmAdd.Hide();
            btnConfirmUpdate.Hide();
            txbRide.Enabled = false;
            cmbRideID.Enabled = true;
            pbName.Hide();
            lblName.Hide();

            try
            {
                conn.Open();
                string sql = "SELECT Ride_ID FROM RIDES";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbRideID.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)//Confirm Delete
        {
            int iD = int.Parse(cmbRideID.Text);

            if (MessageBox.Show("Are you sure you want to delete the information?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = $"DELETE FROM TICKETS WHERE Ride_ID = '{iD}'";
                    command = new SqlCommand(sql, conn);
                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    conn.Close();
                    conn.Open();
                    string sql2 = $"DELETE FROM STAFF_ON_DUTY WHERE Ride_ID = '{iD}'";
                    command = new SqlCommand(sql2, conn);
                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = command;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    conn.Close();
                    this.rIDESTableAdapter.DeleteRide(iD);
                    MessageBox.Show("Ride Information has been sucessfully deleted");
                    this.rIDESTableAdapter.Fill(this.jungleKingdomRecordsDataSet.RIDES);

                    txbRide.Clear();

                    btnConfirmDelete.Hide();
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnDelete.Show();
                    btnUpdate.Show();
                    btnAdd.Show();
                    groupBox1.Hide();
                    cmbRideID.Text = "";

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)//Search
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM RIDES WHERE Ride_Name LIKE '%{txbSearch.Text}%'";
                command = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "RIDES");

                rIDESDataGridView.DataSource = ds;
                rIDESDataGridView.DataMember = "RIDES";

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)//Help Function
        {
            lsbOutput.Items.Add("Return To Main Menu:");
            lsbOutput.Items.Add("If you wish to go back to the main menu Click the Return To Main Menu button.");
            lsbOutput.Items.Add("Add New Ride:");
            lsbOutput.Items.Add("To add a new ride Click on the Add New Ride button.");
            lsbOutput.Items.Add("Delete:");
            lsbOutput.Items.Add("If you wish to delete a old ride please Click the Delete button.");
            lsbOutput.Items.Add("Update: ");
            lsbOutput.Items.Add("When you want to Update information about a Ride Click the Update button.");
            lsbOutput.Show();
            btnReturn.Show();
            groupBox1.Hide();
            rIDESDataGridView.Hide();
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
            lsbOutput.Items.Clear();
            lsbOutput.Hide();
            btnReturn.Hide();
            rIDESDataGridView.Show();
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

        private void rIDESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rIDESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);

        }

        private void txbRide_TextChanged(object sender, EventArgs e)
        {
            pbName.Hide();
            lblName.Hide();
        }
    }
}
