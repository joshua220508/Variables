﻿using System;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblFechas.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FdmArreglo frm = new FdmArreglo();
            frm.ShowDialog();
        }
    }
}
