using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea3_FSI
{
    public partial class Form1 : Form
    {
        CArreglo objarreglo = new CArreglo();
        Cvendedor objvendedor = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int auxcodigo = Convert.ToInt32(textBoxCodigo.Text);
            string auxnombre = textBoxVendedor.Text;
            int auxmonto = Convert.ToInt32(textBoxVentas.Text);
            objvendedor = new Cvendedor(auxcodigo, auxnombre, auxmonto);
            if(objarreglo.Insertar(objvendedor,auxcodigo)==1)
            {
                MessageBox.Show("mal");
            }
            else
            {
                listBoxCodigo.Items.Add(auxcodigo.ToString());
                listBoxVendedor.Items.Add(auxnombre);
                listBoxVentas.Items.Add(auxnombre.ToString());
            }

        }
    }
}
