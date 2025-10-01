using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Variables.Modelos;

namespace Variables.Formularios
{
    public partial class FdmArrgelo : Form
    {
        public FdmArrgelo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbEdad_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        public void llenarListado()
        {
            lbEdades.DataSource = null;
            lbEdades.DataSource = Arreglo.edad;
            lbEdades.Refresh();
            gpEdades.Text = "Edades: " + Arreglo.edad.Length;
            tbEdad.Text = "";
            tbEdad.Focus();
        }

        private void tbEdad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int edad = int.Parse(tbEdad.Text);
                if (Arreglo.pos < 10)
                Arreglo.edad[Arreglo.pos++] = edad;
                else MessageBox.Show("No se puede agregar mas elementos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
