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
    public partial class frmSellTickets : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SAVAG3-SAV1OUR;Initial Catalog=JungleKingdomRecords;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        public frmSellTickets()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmSellTickets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jungleKingdomRecordsDataSet.TICKETS' table. You can move, or remove it, as needed.
            this.tICKETSTableAdapter.Fill(this.jungleKingdomRecordsDataSet.TICKETS);
            groupBox1.Hide();
            btnConfirm.Hide();
            tICKETSDataGridView.Hide();
            lsbReceipt.Hide();
            lsbOutput.Hide();
            btnReturn.Hide();
            lblDate.Hide();
            tICKETSBindingNavigator.Hide();
            pbVisitor.Hide();
            pbSurname.Hide();
            pbNum.Hide();
            pbName.Hide();
            pbR.Hide();
            pbRide.Hide();

            try
            {

                conn.Open();
                string sql3 = "SELECT Visitor_ID FROM VISITORS";
                command = new SqlCommand(sql3, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbVisitorID.Items.Add(reader.GetValue(0));
                }

                conn.Close();

                conn.Open();
                string sql4 = "SELECT Ride_ID FROM RIDES";
                command = new SqlCommand(sql4, conn);
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

        private void btnSell_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            tICKETSDataGridView.Hide();
            btnConfirm.Show();

            txbFirstName.Clear();
            txbSurname.Clear();
            txbRide.Clear();
            cmbRideID.Text = "";
            cmbVisitorID.Text = "";
            txbNum.Clear();
            lblPrice.Text = "R ";
            cbPaid.Checked = false;
        }

        private void cmbRideID_SelectedIndexChanged(object sender, EventArgs e)
        {

            int iD = int.Parse(cmbRideID.Text);
            lsbReceipt.Show();
            pbR.Hide();
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
            lblPrice.Text = "R " + (int.Parse(txbNum.Text) * 20);

            lsbReceipt.Items.Clear();
            lsbReceipt.Items.Add("Receipt:");
            lsbReceipt.Items.Add("+++++++++++++++++");
            lsbReceipt.Items.Add("Name: " + txbFirstName.Text);
            lsbReceipt.Items.Add("Surname: " + txbSurname.Text);
            lsbReceipt.Items.Add("Ride: " + txbRide.Text);
            lsbReceipt.Items.Add("Number of tickets: " + txbNum.Text);
            lsbReceipt.Items.Add("Total amount : R" + (int.Parse(txbNum.Text) * 20) + ".00");
            lsbReceipt.Items.Add("Date of purchase: " + dateTimePicker1.Text);
        }

        private void cmbVisitorID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iD = int.Parse(cmbVisitorID.Text);
            lsbReceipt.Show();
            pbVisitor.Hide();
            pbSurname.Hide();
            pbNum.Hide();
            pbName.Hide();
            try
            {
                //Open connection
                conn.Open();

                string sql2 = $"SELECT * FROM VISITORS WHERE Visitor_ID = '{iD}'";
                command = new SqlCommand(sql2, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txbFirstName.Text = (string)reader.GetValue(1);
                    txbSurname.Text = (string)reader.GetValue(2);
                    txbNum.Text = reader.GetValue(4).ToString();
                }

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            txbFirstName.Enabled = false;
            txbSurname.Enabled = false;
            txbNum.Enabled = false;
            lblPrice.Text = "R " + (int.Parse(txbNum.Text) * 20);

            lsbReceipt.Items.Clear();
            lsbReceipt.Items.Add("Receipt:");
            lsbReceipt.Items.Add("+++++++++++++++++");
            lsbReceipt.Items.Add("Name: " + txbFirstName.Text);
            lsbReceipt.Items.Add("Surname: " + txbSurname.Text);
            lsbReceipt.Items.Add("Ride: " + txbRide.Text);
            lsbReceipt.Items.Add("Number of tickets: " + txbNum.Text);
            lsbReceipt.Items.Add("Total amount : R" + (int.Parse(txbNum.Text)*20));
            lsbReceipt.Items.Add("Date of purchase: " + dateTimePicker1.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)//Confirm sale of ticket
        {
            if((cmbRideID.Text == "") && (cmbVisitorID.Text == ""))
            {
                pbVisitor.Show();
                pbSurname.Show();
                pbNum.Show();
                pbName.Show();
                pbR.Show();
                pbRide.Show();
            }
            else if (cmbRideID.Text == "")
            {
                pbR.Show();
                pbRide.Show();
                pbVisitor.Hide();
                pbSurname.Hide();
                pbNum.Hide();
                pbName.Hide();
            }
            else if(cmbVisitorID.Text == "")
            {
                pbVisitor.Show();
                pbSurname.Show();
                pbNum.Show();
                pbName.Show();
                pbR.Hide();
                pbRide.Hide();
            }
            else if ((cmbRideID.Text != "") && (cmbVisitorID.Text != ""))
            {
                if (!cbPaid.Checked)
                {
                    MessageBox.Show("Check if the customer has paid before procedding with" +
                        "the sale of the tickets");
                }
                else
                {
                    if (dateTimePicker1.Value >= DateTime.Now)
                    {
                        lsbReceipt.Items.Clear();
                        lsbReceipt.Hide();
                        try
                        {
                            decimal price = int.Parse(txbNum.Text) * 20;
                            this.tICKETSTableAdapter.InsertSell(int.Parse(cmbVisitorID.Text), int.Parse(cmbRideID.Text)
                                , price,DateTime.Parse(dateTimePicker1.Text));
                            MessageBox.Show("The ticket(s) has been sold");
                            this.tICKETSTableAdapter.Fill(this.jungleKingdomRecordsDataSet.TICKETS);


                            groupBox1.Hide();
                            tICKETSDataGridView.Show();

                        }
                        catch (SqlException error)
                        {
                            MessageBox.Show(error.Message);
                        }
                    }
                    else
                    {
                        lblDate.Show();
                        lsbReceipt.Show();
                    }

                }
            }

        }

        private void lblHelp_Click(object sender, EventArgs e)//Help Function
        {
            tICKETSDataGridView.Hide();
            lsbOutput.Items.Add("Return To Main Menu:");
            lsbOutput.Items.Add("If you wish to go back to the main menu Click the Return To Main Menu button.");
            lsbOutput.Items.Add("Sell a Ticket:");
            lsbOutput.Items.Add("To sell a ticket Click on the Sell a Ticket Button");
            lsbOutput.Items.Add("After a ticket has been sold the Receipt will be displayed.");
            lsbOutput.Show();
            btnReturn.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            btnReturn.Hide();
            lsbOutput.Items.Clear();
            lsbOutput.Hide();
        }

        private void tICKETSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tICKETSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);

        }
    }
}
