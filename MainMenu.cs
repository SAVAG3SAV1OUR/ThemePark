using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JungleKingdomThemePark_System
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnVisitors_Click(object sender, EventArgs e)//Visitors
        {
            frmVisitors myVisitors = new frmVisitors();
            this.Hide();
            myVisitors.ShowDialog();
            this.Show();
        }

        private void btnRides_Click(object sender, EventArgs e)//Rides
        {
            frmRides myRides =  new frmRides();
            this.Hide();
            myRides.ShowDialog();
            this.Show();
        }

        private void btnStaff_Click(object sender, EventArgs e)//Staff
        {
            frmStaff myStaff = new frmStaff();
            this.Hide();
            myStaff.ShowDialog();
            this.Show();
        }

        private void btnDuty_Click(object sender, EventArgs e)//Staff On Duty
        {
            frmDuty myDuty = new frmDuty();
            this.Hide();
            myDuty.ShowDialog();
            this.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)//Sell Tickets
        {
            frmSellTickets myTickets = new frmSellTickets();
            this.Hide();
            myTickets.ShowDialog();
            this.Show();
        }

        private void lblHelp_Click(object sender, EventArgs e)//Help button
        {
            lsbOutput.Items.Add("Maintain Visitors: ");
            lsbOutput.Items.Add("Click this button if you wish to add, delete or update Visitors information.");
            lsbOutput.Items.Add("Maintain Rides: ");
            lsbOutput.Items.Add("Click this button if you wish to make changes to Rides.");
            lsbOutput.Items.Add("Maintain Staff: ");
            lsbOutput.Items.Add("Click this button if you wish to add, delete or update Staff members.");
            lsbOutput.Items.Add("Maintain Staff on duty: ");
            lsbOutput.Items.Add("Click this button if you wish to view or make changes to Staff members on duty.");
            lsbOutput.Items.Add("Request Reports: ");
            lsbOutput.Items.Add("Click this button if you wish to view reports on Salfe of tickets.");
            lsbOutput.Items.Add("Sell Tickets: ");
            lsbOutput.Items.Add("Click this button if you wish to Sell tickets to visitors.");
            lsbOutput.Show();
            btnReturn.Show();
            pbHelp.Hide();
            pictureBox2.Hide();
            lblHelp.Hide();
            btnLogOut.Hide();
            label1.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)//Return
        {
            lsbOutput.Hide();
            lsbOutput.Items.Clear();
            btnReturn.Hide();
            pictureBox2.Show();
            lblHelp.Show();
            btnLogOut.Show();
            label1.Show();
        }

        private void pbHelp_Click(object sender, EventArgs e)//Help Button #2
        {
            lsbOutput.Show();
            btnReturn.Show();
            pbHelp.Hide();
            lblHelp.Hide();
            btnLogOut.Hide();
            label1.Hide();
        }

        private void btnRequest_Click(object sender, EventArgs e)//Request Report
        {
            frmReport myReport = new frmReport();
            this.Hide();
            myReport.ShowDialog();
            this.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)//Logout
        {
            frmLogin.A1 = 0;
            frmLogin.S2 = 0;
            frmLogin.M3 = 0;
            btnStaff.Enabled = true;
            btnStaff.BackColor = Color.White;

            btnRequest.Enabled = true;
            btnRequest.BackColor = Color.White;

            btnRides.Enabled = true;
            btnRides.BackColor = Color.White;

            btnDuty.Enabled = true;
            btnDuty.BackColor = Color.White;

            btnVisitors.Enabled = true;
            btnVisitors.BackColor = Color.White;

            btnSell.Enabled = true;
            btnSell.BackColor = Color.White;

            this.DialogResult = DialogResult.OK;
        }

        private void frmMenu_Load(object sender, EventArgs e)//form load
        {
            lsbOutput.Hide();
            btnReturn.Hide();
            pbHelp.Hide();
            pictureBox2.Show();
            lblHelp.Show();

            if(frmLogin.A1 == 1)//Admin
            {
                btnStaff.Enabled = false;
                btnStaff.BackColor = Color.Gray;
                btnRequest.Enabled = false;
                btnRequest.BackColor = Color.Gray;

                btnVisitors.Enabled = true;
                btnVisitors.BackColor = Color.White;
                btnSell.Enabled = true;
                btnSell.BackColor = Color.White;
                btnRides.Enabled = true;
                btnRides.BackColor = Color.White;
                btnDuty.Enabled = true;
                btnDuty.BackColor = Color.White;
            }
            else if (frmLogin.S2 == 1)//Staff
            {
                btnStaff.Enabled = false;
                btnStaff.BackColor = Color.Gray;
                btnRequest.Enabled = false;
                btnRequest.BackColor = Color.Gray;
                btnRides.Enabled = false;
                btnRides.BackColor = Color.Gray;
                btnDuty.Enabled = false;
                btnDuty.BackColor = Color.Gray;

                btnVisitors.Enabled = true;
                btnVisitors.BackColor = Color.White;
                btnSell.Enabled = true;
                btnSell.BackColor = Color.White;
            }
            else if (frmLogin.M3 == 1)//Manager
            {
                btnSell.Enabled = false;
                btnSell.BackColor = Color.Gray; 
                btnDuty.Enabled = false;
                btnDuty.BackColor = Color.Gray;
                btnVisitors.Enabled = false;
                btnVisitors.BackColor = Color.Gray;

                btnRides.Enabled = true;
                btnRides.BackColor = Color.White;
                btnStaff.Enabled = true;
                btnStaff.BackColor = Color.White;
                btnRequest.Enabled = true;
                btnRequest.BackColor = Color.White;
            }
        }
    }
}
