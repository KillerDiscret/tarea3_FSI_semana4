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
                MessageBox.Show("Ha repetido Codigo ¡Estafador!");
            }
            else
            {
                listBoxCodigo.Items.Add(auxcodigo.ToString());
                listBoxVendedor.Items.Add(auxnombre);
                listBoxVentas.Items.Add(auxmonto.ToString());
                textBoxCodigo.Clear();
                textBoxVendedor.Clear();
                textBoxVentas.Clear();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mostrar = objarreglo.Mostrar_Mayor();

            MessageBox.Show("Nombre: "+mostrar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string aux = objarreglo.Mostrar_Menor();

            MessageBox.Show("Nombre: " + aux);
        }
    }
}
