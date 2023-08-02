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
    /*
     *  1.	Neo Khunoane [37612034]
        2.	Mbulelo Kondile [31228208]
        3.	Aran Hugh Petersen [38630834]
        4.	Jarred Green [37561405]
        5.	C.M Ngokana [31846769]
        6.	Rethabile Peega [37922696]

     */
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }


        public static int A1;
        public static int S2;
        public static int M3;

        frmMenu myMenu = new frmMenu();
        public string admin, staff, manager;
        public string aPass, sPass, mPass;

        private void txbPassword_TextChanged(object sender, EventArgs e)//Password Textbox
        {
            pbInvaild.Hide();
            lblInvalid.Hide();
            pbPassword.Hide();
            pbUserName.Hide();
            pbClosed.Hide();
            pbOpen.Show();
            txbPassword.UseSystemPasswordChar = true;
        }

        private void pbClosed_Click(object sender, EventArgs e)//Password Hide
        {
            pbClosed.Hide();
            pbOpen.Show();
            txbPassword.UseSystemPasswordChar = true;
        }

        private void pbOpen_Click(object sender, EventArgs e)//Password show
        {
            pbOpen.Hide();
            pbClosed.Show();
            txbPassword.UseSystemPasswordChar = false;
        }

        private void btnClose_Click(object sender, EventArgs e)//Close Button
        {
            this.Close();
        }

        private void txbUsername_TextChanged(object sender, EventArgs e)//Username
        {
            pbInvaild.Hide();
            lblInvalid.Hide();
            pbPassword.Hide();
            pbUserName.Hide();
            pbClosed.Hide();
            pbOpen.Show();
            txbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)//Login
        {
            //Admin, staff and manager information
            admin = "Scott Pearson";
            staff = "Mike Dean";
            manager = "John Adams";
            aPass = "Ninja24WW";
            sPass = "CatDog672E";
            mPass = "SeeFuture882";

            if ((txbUsername.Text == admin) || (txbUsername.Text == staff) 
                || (txbUsername.Text == manager))
            {
                if (txbUsername.Text == admin)
                {
                    if (txbPassword.Text == aPass)
                    {
                        A1 = 1;
                        this.Hide();
                        myMenu.ShowDialog();
                        this.Show();

                        txbPassword.Clear();
                        txbUsername.Clear();
                    }
                    else
                    {
                        pbPassword.Show();
                        pbInvaild.Show();
                        lblInvalid.Show();
                        pbOpen.Hide();
                        pbClosed.Hide();
                    }
                }
                else if(txbUsername.Text == staff)
                {
                    if (txbPassword.Text == sPass)
                    {
                        S2 = 1;
                        this.Hide();
                        myMenu.ShowDialog();
                        this.Show();

                        txbUsername.Clear();
                        txbPassword.Clear();
                    }
                    else
                    {
                        pbPassword.Show();
                        pbInvaild.Show();
                        lblInvalid.Show();
                        pbOpen.Hide();
                        pbClosed.Hide();
                    }
                }
                else if(txbUsername.Text == manager)
                {
                    if (txbPassword.Text == mPass)
                    {
                        M3 = 1;
                        this.Hide();
                        myMenu.ShowDialog();
                        this.Show();

                        txbPassword.Clear();
                        txbUsername.Clear();
                    }
                    else
                    {
                        pbPassword.Show();
                        pbInvaild.Show();
                        lblInvalid.Show();
                        pbOpen.Hide();
                        pbClosed.Hide();
                    }
                }
            }
            else
            {
                pbInvaild.Show();
                pbPassword.Show();
                lblInvalid.Show();
                pbUserName.Show(); 
                pbOpen.Hide();
                pbClosed.Hide();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)//Clear
        {
            txbUsername.Clear();
            txbPassword.Clear();
            pbInvaild.Hide();
            lblInvalid.Hide();
            pbPassword.Hide();
            pbUserName.Hide();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pbInvaild.Hide();
            lblInvalid.Hide();
            pbPassword.Hide();
            pbUserName.Hide();
        }
    }
}
