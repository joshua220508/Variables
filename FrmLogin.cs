using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        int intentos = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Logear();
        }

        private void Logear()
        {
            if (Login(tbUser.Text, tbPassword.Text))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else
            {
                intentos++;
                MessageBox.Show("Contrasena incorrecta.");
            }
            if (intentos == 3)
            {
                MessageBox.Show("Has superado el numero de intentos (3)", "Error", MessageBoxButtons.OK);
                this.Close();
            } 
        }
        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Logear();            
            }
        }
    }
}
