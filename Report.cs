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
    public partial class frmReport : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=SAVAG3-SAV1OUR;Initial Catalog=JungleKingdomRecords;Integrated Security=True");
        SqlCommand command;
        SqlDataAdapter adapter;
        DataSet ds;
        SqlDataReader reader;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            lsbOutput.Hide();
            btnGenerate.Hide();
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
            btnReturn.Hide();
            dataGridView1.Hide();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            lsbOutput.Show();
            lsbOutput.Items.Add("Price Evaluations for the period of " + dateTimePicker1.Text + " AND " + dateTimePicker2.Text);
            lsbOutput.Items.Add("==========================================================================");
            try
            {
                conn.Open();
                string sql3 = $"SELECT MIN(Price_Of_Tickets) FROM TICKETS t WHERE t.Date_Of_Purchase BETWEEN '{dateTimePicker1.Text}'AND '{dateTimePicker2.Text}'";
                command = new SqlCommand(sql3, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lsbOutput.Items.Add("Lowest Amount: R" + reader.GetValue(0));
                }
                lsbOutput.Items.Add("");
                conn.Close();

                conn.Open();
                string sql = $"SELECT MAX(Price_Of_Tickets) FROM TICKETS t WHERE t.Date_Of_Purchase BETWEEN '{dateTimePicker1.Text}'AND '{dateTimePicker2.Text}'";
                command = new SqlCommand(sql, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lsbOutput.Items.Add("Highest Amount: R" + reader.GetValue(0));
                }
                lsbOutput.Items.Add("");
                conn.Close();

                conn.Open();
                string sql4 = $"SELECT AVG(Price_Of_Tickets) FROM TICKETS t WHERE t.Date_Of_Purchase BETWEEN '{dateTimePicker1.Text}'AND '{dateTimePicker2.Text}'";
                command = new SqlCommand(sql4, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lsbOutput.Items.Add("Average Amount: R" + reader.GetValue(0));
                }
                lsbOutput.Items.Add("");
                conn.Close();

                conn.Open();
                string sql2 = $"SELECT SUM(Price_Of_Tickets) FROM TICKETS t WHERE t.Date_Of_Purchase BETWEEN '{dateTimePicker1.Text}'AND '{dateTimePicker2.Text}'";
                command = new SqlCommand(sql2, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    lsbOutput.Items.Add("Total Balance: R" + reader.GetValue(0));
                }
                lsbOutput.Items.Add("");
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void summaryToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            try
            {
                conn.Open();
                string sql = $"SELECT r.Ride_Name,Count(t.Ticket_ID) AS 'Number_Of_People' FROM TICKETS t,RIDES r WHERE r.Ride_ID = t.Ride_ID GROUP BY r.Ride_Name ORDER BY Number_Of_People DESC";
                command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "VISITORS");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "VISITORS";
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            try
            {
                conn.Open();
                string sql = $"SELECT t.Date_Of_Purchase,Count(v.Num_Tickets) AS 'Number Of Tickets' FROM VISITORS v,TICKETS t WHERE v.Visitor_ID = t.Visitor_ID GROUP BY t.Date_Of_Purchase";
                command = new SqlCommand(sql, conn);
                adapter = new SqlDataAdapter();
                ds = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(ds, "VISITORS");

                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "VISITORS";
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnDetailed_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            lsbOutput.Hide();
            dateTimePicker1.Show();
            dateTimePicker2.Show();
            btnGenerate.Show();
            btnSold.Hide();
            btnDetailed.Hide();
            btnSell.Hide();
        }
    }
}
