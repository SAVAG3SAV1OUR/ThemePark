using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JungleKingdomThemePark_System
{
    public partial class frmDuty : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SAVAG3-SAV1OUR;Initial Catalog=JungleKingdomRecords;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataSet ds;
        public frmDuty()
        {
            InitializeComponent();
        }


        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void frmDuty_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jungleKingdomRecordsDataSet.STAFF_ON_DUTY' table. You can move, or remove it, as needed.
            this.sTAFF_ON_DUTYTableAdapter.Fill(this.jungleKingdomRecordsDataSet.STAFF_ON_DUTY);
            groupBox1.Hide();
            lsbOutput.Hide();
            btnReturn.Hide();
            sTAFF_ON_DUTYBindingNavigator.Hide();

            try
            {
                conn.Open();
                string sql3 = "SELECT Employee_ID FROM STAFF";
                command = new SqlCommand(sql3, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbEmID.Items.Add(reader.GetValue(0));
                }

                conn.Close();

                conn.Open();
                string sql4 = "SELECT Ride_ID FROM RIDES";
                command = new SqlCommand(sql4, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbRide.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }


        }

        private void cmbEmID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iD = int.Parse(cmbEmID.Text);
            pbID.Hide();
            try
            {
                //Open connection
                conn.Open();

                string sql2 = $"SELECT * FROM STAFF WHERE Employee_ID = '{iD}'";
                command = new SqlCommand(sql2, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txbFirstName.Text = (string)reader.GetValue(1);
                    txbSurname.Text = (string)reader.GetValue(2);
                }

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            txbFirstName.Enabled = false;
            txbSurname.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            pbID.Hide();
            pbRide.Hide();
            groupBox1.Show();
        }

        private void lblHelp_Click(object sender, EventArgs e)//Help Function
        {
            lsbOutput.Items.Add("Return To Main Menu:");
            lsbOutput.Items.Add("If you wish to go back to the main menu Click the Return To Main Menu button.");
            lsbOutput.Items.Add("Assign Staff to Task:");
            lsbOutput.Items.Add("To change the current Task of a Staff Member Click on the Assign Staff to Task button.");
            lsbOutput.Items.Add("Search Date:");
            lsbOutput.Items.Add("To Search for a specific date type that date in the alocated space.");
            lsbOutput.Show();
            btnReturn.Show();
            groupBox1.Hide();
            sTAFF_ON_DUTYDataGridView.Hide();
            txbSearch.Hide();
            pbHelp.Hide();
            lblHelp.Hide();
            label8.Hide();
            btnMenu.Hide();
            pictureBox1.Hide();
            btnAdd.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            lsbOutput.Items.Clear();
            lsbOutput.Hide();
            btnReturn.Hide();
            sTAFF_ON_DUTYDataGridView.Show();
            txbSearch.Show();
            pbHelp.Show();
            lblHelp.Show();
            label8.Show();
            btnMenu.Show();
            pictureBox1.Show();
            btnAdd.Show();
        }

        private void cmbRide_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iD = int.Parse(cmbRide.Text);
            pbRide.Hide();
            try
            {
                //Open connection
                conn.Open();

                string sql2 = $"SELECT * FROM RIDES WHERE Ride_ID = '{iD}'";
                command = new SqlCommand(sql2, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txbRide.Text = (string)reader.GetValue(1);
                }

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            txbRide.Enabled = false;
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)//ConfirmAdd
        {
            string myDate = dateTimePicker1.Text;
            int ride, employee;

            if((cmbEmID.Text == "") || (cmbRide.Text == ""))
            {
                if(cmbEmID.Text == "")
                {
                    pbID.Show();
                }
                if (cmbRide.Text == "")
                {
                    pbRide.Show();
                }
            }
            else if ((cmbEmID.Text == "") && (cmbRide.Text == ""))
            {
                pbID.Show();
                pbRide.Show();
            }
            else if ((cmbEmID.Text != "") && (cmbRide.Text != ""))
            {
                if(dateTimePicker1.Value < DateTime.Today)
                {
                    lblDate.Show();
                    lblDate.Text = "Do not select a previous day";
                }
                else
                {
                    lblDate.Hide();
                    ride = int.Parse(cmbRide.Text);
                    employee = int.Parse(cmbEmID.Text);
                    try
                    {
                        this.sTAFF_ON_DUTYTableAdapter.InsertDuty(employee, ride, DateTime.Parse(myDate));
                        MessageBox.Show("New Task added");
                        this.sTAFF_ON_DUTYTableAdapter.Fill(this.jungleKingdomRecordsDataSet.STAFF_ON_DUTY);

                        txbFirstName.Clear();
                        txbSurname.Clear();
                        txbRide.Clear();
                        cmbEmID.Text = "";
                        cmbRide.Text = "";


                        //btnConfirmAdd.Hide();
                        btnAdd.Enabled = true;
                        groupBox1.Hide();

                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void sTAFF_ON_DUTYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTAFF_ON_DUTYBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM STAFF_ON_DUTY WHERE Date_On_Duty LIKE '%{txbSearch.Text}%'";
                command = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "STAFF");

                sTAFF_ON_DUTYDataGridView.DataSource = ds;
                sTAFF_ON_DUTYDataGridView.DataMember = "STAFF";

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
