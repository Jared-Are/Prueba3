using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace pjFiguraHerencia
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }


        //Llamando a los formularios correspondientes.
        private void btnFigBidimensional_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFigurasBidimensionales frmB = new();
            frmB.ShowDialog();
        }

        private void btnFigTridimensional_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmFigurasTridimensionales frmT = new();
            frmT.ShowDialog();
        }

        //Salida.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
                System.Windows.Forms.Application.Exit();
        }
    }
}
