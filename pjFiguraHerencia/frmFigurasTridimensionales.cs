using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pjFiguraHerencia
{
    public partial class frmFigurasTridimensionales : Form
    {
        public frmFigurasTridimensionales()
        {
            InitializeComponent();
        }


        //Aquí se ocultan los label y se bloquean los botones "Calcular" cuándo el programa(formulario) se inicia.
        private void frmFigurasTridimensionales_Load(object sender, EventArgs e)
        {
            lblAreaE.Visible = false;
            lblVolumenE.Visible = false;
            lblAreaC.Visible = false;
            lblVolumenC.Visible = false;
            lblAreaT.Visible = false;
            lblVolumenT.Visible = false;

            btnCalcularC.Enabled = false;
            btnCalcularE.Enabled = false;
            btnCalcularT.Enabled = false;

            btnBorrar.Enabled = false;
        }


        //Estos 4 métodos validan que solo se ingresen números positivos a los textbox, y que solo se permita 1 punto decimal por textbox.
        private void txtRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números decimales positivos (incluyendo punto) y la tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquear la entrada de caracteres no válidos
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true; // Bloquear la entrada de un segundo punto
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true; // Bloquear la entrada si solo se ingresa un punto
            }
        }

        private void txtLadoC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains(".")))
                e.Handled = true;

            if ((e.KeyChar == '.') && (sender as TextBox).Text.Length == 0)
                e.Handled = true;
        }

        private void txtLadoT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains(".")))
                e.Handled = true;

            if ((e.KeyChar == '.') && (sender as TextBox).Text.Length == 0)
                e.Handled = true;
        }


        //Los eventos "TextChanged", sirven para que aparezcan los label apenas los textbox detecten información, en este caso números.
        //También se ncargan de eliminar el resultado apenas el textbox esté vacío.
        private void txtRadio_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();
            HabilitarBotonBorrar();

            //Verifica que el textbox no está vacío para mostrar los label.
            if (string.IsNullOrWhiteSpace(txtRadio.Text))
            {
                lblAreaE.Text = ("El área de la esfera es: ");
                lblVolumenE.Text = ("El volumen de la esfera es: ");
            }
            else if (double.TryParse(txtRadio.Text, out _))
            {
                lblAreaE.Visible = true;
                lblVolumenE.Visible = true;
            }
        }

        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();
            HabilitarBotonBorrar();

            if (string.IsNullOrWhiteSpace(txtLadoC.Text))
            {
                lblAreaC.Text = ("El área del cubo es: ");
                lblVolumenC.Text = ("El volumen del cubo es: ");
            }
            else if (double.TryParse(txtLadoC.Text, out _))
            {
                lblAreaC.Visible = true;
                lblVolumenC.Visible = true;
            }
        }

        //Aquí, hice un método(verificarAmbosTextbox), para que los label aparezcan cuando ambos textbox del triángulo tengan datos.
        private void txtLadoT_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();
            HabilitarBotonBorrar();

            if (string.IsNullOrWhiteSpace(txtLadoT.Text))
            {
                lblAreaT.Text = ("El área del tetraedro es: ");
                lblVolumenT.Text = ("El volumen del tetraedro es: ");
            }
            else if (double.TryParse(txtLadoT.Text, out _))
            {
                lblAreaT.Visible = true;
                lblVolumenT.Visible = true;
            }
        }



        //Este método habilita y deshabilita los botones "Calcular" de cada figura, verificando los textbox vacíos.
        private void VerificarCamposNoVacios()
        {
            if (!string.IsNullOrWhiteSpace(txtRadio.Text))
                // Ambos campos tienen texto, habilita el botón de "calcular"
                btnCalcularE.Enabled = true;
            else
                // Al menos uno de los campos está vacío, deshabilita el botón de "calcular"
                btnCalcularE.Enabled = false;


            if (!string.IsNullOrWhiteSpace(txtLadoC.Text))
                btnCalcularC.Enabled = true;
            else
                btnCalcularC.Enabled = false;


            if (!string.IsNullOrWhiteSpace(txtLadoT.Text))
                btnCalcularT.Enabled = true;
            else
                btnCalcularT.Enabled = false;
        }


        //Estos 3 métodos realizan los cálculos, le dan función a los botones "Calcular".
        private void btnCalcularE_Click(object sender, EventArgs e)
        {
            //creando instancia de su respectiva clase y obteniendo el valor ingresado.
            double radio = double.Parse(txtRadio.Text);
            Esfera obj = new(radio);

            //Mostrando el resultado.
            lblAreaE.Text = ("El área de la esfera es: " + obj.CalcularArea().ToString("F2") + " cm^2");
            lblVolumenE.Text = ("El volumen de la esfera es: " + obj.CalcularVolumen().ToString("F2") + " cm^3");
        }

        private void btnCalcularC_Click(object sender, EventArgs e)
        {
            double lado = double.Parse(txtLadoC.Text);
            Cubo obj = new(lado);

            lblAreaC.Text = ("El área del cubo es: " + obj.CalcularArea().ToString("F2") + " cm^2");
            lblVolumenC.Text = ("El volumen del cubo es: " + obj.CalcularVolumen().ToString("F2") + " cm^3");
        }

        private void btnCalcularT_Click(object sender, EventArgs e)
        {
            double LadoT = double.Parse(txtLadoT.Text);
            Tetraedro obj = new(LadoT);

            lblAreaT.Text = ("El área del tetraedo es: " + obj.CalcularArea().ToString("F2") + " cm^2");
            lblVolumenT.Text = ("El volumen del tetraedro es: " + obj.CalcularVolumen().ToString("F2") + " cm^3");
        }


        //Llama al formulario del menú principal.
        private void btnInicio_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea regresar al menú principal?", "Confirmar acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                this.Hide();
                frmMenu menu = new();
                menu.ShowDialog();
            }
        }


        //Limpia los textbox y deja el cursor en el primer textbox.
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            HabilitarBotonBorrar();
            DialogResult resultado = MessageBox.Show("¿Desea borrar los datos ingresados?", "Confirmar acción", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                txtRadio.Text = "";
                txtLadoC.Text = "";
                txtLadoT.Text = "";
                txtRadio.Focus();
                btnBorrar.Enabled = false;
            }
        }

        private void HabilitarBotonBorrar()
        {
            // Verifica si los TextBox tienen datos y habilita el botón de limpiar en consecuencia
            btnBorrar.Enabled = !string.IsNullOrWhiteSpace(txtRadio.Text) || !string.IsNullOrWhiteSpace(txtLadoC.Text)
                || !string.IsNullOrWhiteSpace(txtLadoT.Text);
        }


        //Salida.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de la aplicación?", "Confirmar salida", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
                Application.Exit();
        }


    }
}
