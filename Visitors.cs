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
    public partial class frmVisitors : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SAVAG3-SAV1OUR;Initial Catalog=JungleKingdomRecords;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataReader reader;

        
        public frmVisitors()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)//Return to main menu
        {
            this.DialogResult = DialogResult.OK;

        }

        private void frmVisitors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jungleKingdomRecordsDataSet.VISITORS' table. You can move, or remove it, as needed.
            this.vISITORSTableAdapter.Fill(this.jungleKingdomRecordsDataSet.VISITORS);
            vISITORSBindingNavigator.Hide();
            groupBox1.Hide();
            pbName.Hide();
            pbSurname.Hide();
            pbNum.Hide();
            pbTicket.Hide();
            lblName.Hide();
            lblNum.Hide();
            lblSurname.Hide();
            lblTickets.Hide();
            lsbOutput.Hide();
            btnReturn.Hide();
            lsbOutput.Hide();
            btnReturn.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)//Add New Visitor
        {
            //formalities
            groupBox1.Show();
            btnConfirmUpdate.Hide();
            btnConfirmDelete.Hide();
            btnConfirmAdd.Show();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnAdd.Enabled = false;
            cmbVisitorID.Enabled = false;
        }

        private void btnConfirmAdd_Click(object sender, EventArgs e)//Confirm Add Visitor
        {
            string name, surname, num;
            int rtickets;

            name = txbFirstName.Text;
            surname = txbSurname.Text;
            num = txbContact.Text;
            rtickets = (int)numTickets.Value; 

            if ((name != "") && (surname != "") && (num != "")
                && (rtickets != 0))
            {
                this.vISITORSTableAdapter.InsertVisitor(name, surname, num, rtickets);
                MessageBox.Show("New Visitor Added");
                this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);
                this.vISITORSTableAdapter.Fill(this.jungleKingdomRecordsDataSet.VISITORS);


                txbFirstName.Clear();
                txbSurname.Clear();
                txbContact.Clear();
                numTickets.Value = 0;
                btnConfirmAdd.Hide();
                btnAdd.Enabled = true;
                btnDelete.Show();
                btnUpdate.Show();
                groupBox1.Hide();
            }
            else
            {
                if ((name == "") || (surname == "") || (num == "")
                    || (rtickets == 0))
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
                    if (num == "")
                    {
                        pbNum.Show();
                        lblNum.Show();
                    }
                    if (rtickets == 0)
                    {
                        pbTicket.Show();
                        lblTickets.Show();
                    }
                }
            }

        }

        private void txbFirstName_TextChanged(object sender, EventArgs e)//FirstName textbox
        {
            lblName.Hide();
            lblSurname.Hide();
            lblNum.Hide();
            lblTickets.Hide();
            pbName.Hide();
            pbNum.Hide();
            pbSurname.Hide();
            pbTicket.Hide();
        }

        private void txbSurname_TextChanged(object sender, EventArgs e)//Surname textbox
        {
            lblName.Hide();
            lblSurname.Hide();
            lblNum.Hide();
            lblTickets.Hide();
            pbName.Hide();
            pbNum.Hide();
            pbSurname.Hide();
            pbTicket.Hide();
        }

        private void txbContact_TextChanged(object sender, EventArgs e)//Contact textbox
        {
            lblName.Hide();
            lblSurname.Hide();
            lblNum.Hide();
            lblTickets.Hide();
            pbName.Hide();
            pbNum.Hide();
            pbSurname.Hide();
            pbTicket.Hide();
        }

        private void numTickets_ValueChanged(object sender, EventArgs e)//NumTickets
        {
            lblName.Hide();
            lblSurname.Hide();
            lblNum.Hide();
            lblTickets.Hide();
            pbName.Hide();
            pbNum.Hide();
            pbSurname.Hide();
            pbTicket.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)//Update Visitor details
        {
            cmbVisitorID.Items.Clear();
            groupBox1.Show();
            btnUpdate.Enabled = false;
            btnAdd.Hide();
            btnDelete.Hide();
            btnConfirmDelete.Hide();
            btnConfirmAdd.Hide();
            btnConfirmUpdate.Show();
            txbFirstName.Enabled = false;
            txbSurname.Enabled = false;
            txbContact.Enabled = false;
            numTickets.Enabled = false;
            cmbVisitorID.Enabled = true;

            try
            {
                conn.Open();
                string sql = "SELECT Visitor_ID FROM VISITORS";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbVisitorID.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cmbVisitorID_SelectedIndexChanged(object sender, EventArgs e)//Visitor_ID
        {
            int iD = int.Parse(cmbVisitorID.Text);
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM VISITORS WHERE Visitor_ID = '{iD}'";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txbFirstName.Text = (string)reader.GetValue(1);
                    txbSurname.Text = (string)reader.GetValue(2);
                    txbContact.Text = (string)reader.GetValue(3);
                    numTickets.Value = (int)reader.GetValue(4);
                }
                conn.Close();

                txbContact.Enabled = true;
                txbFirstName.Enabled = true;
                numTickets.Enabled = true;
                txbSurname.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }   

        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)//ConfirmUpdate
        {
            string name, surname, num;
            int rtickets;

            name = txbFirstName.Text;
            surname = txbSurname.Text;
            num = txbContact.Text;
            rtickets = (int)numTickets.Value;
            int iD = int.Parse(cmbVisitorID.Text);

            if ((name != "") && (surname != "") && (num != "")
                && (rtickets != 0))
            {
                this.vISITORSTableAdapter.UpdateVisitor(name, surname, num, rtickets, iD);
                MessageBox.Show("Visitor Information successfully updated", "Update", MessageBoxButtons.OK);
                this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);
                this.vISITORSTableAdapter.Fill(this.jungleKingdomRecordsDataSet.VISITORS);


                txbFirstName.Clear();
                txbSurname.Clear();
                txbContact.Clear();
                numTickets.Value = 0;

                btnConfirmAdd.Hide();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Show();
                btnUpdate.Show();
                btnAdd.Show();
                groupBox1.Hide();
            }
            else
            {
                if ((name == "") || (surname == "") || (num == "")
                    || (rtickets == 0))
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
                    if (num == "")
                    {
                        pbNum.Show();
                        lblNum.Show();
                    }
                    if (rtickets == 0)
                    {
                        pbTicket.Show();
                        lblTickets.Show();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)//Delete
        {
            cmbVisitorID.Items.Clear();
            groupBox1.Show();
            btnDelete.Enabled = false;
            btnAdd.Hide();
            btnUpdate.Hide();
            btnConfirmDelete.Show();
            btnConfirmAdd.Hide();
            btnConfirmUpdate.Hide();
            txbFirstName.Enabled = false;
            txbSurname.Enabled = false;
            txbContact.Enabled = false;
            numTickets.Enabled = false;
            cmbVisitorID.Enabled = true;

            try
            {
                conn.Open();
                string sql = "SELECT Visitor_ID FROM VISITORS";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbVisitorID.Items.Add(reader.GetValue(0));
                }
                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnConfirmDelete_Click(object sender, EventArgs e)//ConfirmDelete
        {
            if (MessageBox.Show("Are you sure you want to delete the information?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                conn.Open();
                string sql = $"DELETE FROM TICKETS WHERE Visitor_ID = '{int.Parse(cmbVisitorID.Text)}'";
                command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command;
                adapter.DeleteCommand.ExecuteNonQuery();

                conn.Close();
                this.vISITORSTableAdapter.DeleteVisitor(int.Parse(cmbVisitorID.Text));


                MessageBox.Show("Visitor Information has been sucessfully deleted");
                this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);
                this.vISITORSTableAdapter.Fill(this.jungleKingdomRecordsDataSet.VISITORS);

                txbFirstName.Clear();
                txbSurname.Clear();
                txbContact.Clear();
                numTickets.Value = 0;

                btnConfirmDelete.Hide();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnDelete.Show();
                btnUpdate.Show();
                btnAdd.Show();
                groupBox1.Hide();
            }

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)//Search
        {
            try
            {
                conn.Open();
                string sql = $"SELECT * FROM VISITORS WHERE Visitor_Name LIKE '%{txbSearch.Text}%'";
                command = new SqlCommand(sql, conn);

                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "VISITORS");

                vISITORSDataGridView.DataSource = ds;
                vISITORSDataGridView.DataMember = "VISITORS";

                conn.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lblHelp_Click(object sender, EventArgs e)//Help function
        {
            vISITORSDataGridView.Hide();
            lsbOutput.Items.Add("Return To Main Menu:");
            lsbOutput.Items.Add("If you wish to go back to the main menu Click the Return To Main Menu button.");
            lsbOutput.Items.Add("Add New Visitor:");
            lsbOutput.Items.Add("To add a new Visitor Click on the Add New Ride button.");
            lsbOutput.Items.Add("Delete Visitor:");
            lsbOutput.Items.Add("If you wish to Remove a old Visitor please Click the Delete button.");
            lsbOutput.Items.Add("Update Visitor: ");
            lsbOutput.Items.Add("When you want to Update information about a Visitor Click the Update button.");
            lsbOutput.Show();
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
            lsbOutput.Items.Clear();
            lsbOutput.Hide();
            btnReturn.Hide();
            vISITORSDataGridView.Show();
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

        private void vISITORSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vISITORSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jungleKingdomRecordsDataSet);

        }
    }
}
