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
    public partial class frmFigurasBidimensionales : Form
    {
        public frmFigurasBidimensionales()
        {
            InitializeComponent();
        }


        //Aquí se ocultan los label y se bloquean los botones "Calcular" cuándo el programa(formulario) se inicia.
        private void frmFigurasBidimensionales_Load(object sender, EventArgs e)
        {
            lblAreaCi.Visible = false;
            lblPerimetroCi.Visible = false;
            lblAreaCu.Visible = false;
            lblPerimetroCu.Visible = false;
            lblAreaTr.Visible = false;
            lblPerimetroTr.Visible = false;

            btnCalcularCi.Enabled = false;
            btnCalcularCu.Enabled = false;
            btnCalcularT.Enabled = false;

            btnBorrar.Enabled = false;
        }


        //Estos 4 métodos validan que solo se ingresen números positivos a los textbox, y que solo se permita 1 punto decimal por textbox.
        private void txtRadio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números decimales positivos (incluyendo punto) y la tecla Backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // Bloquear la entrada de caracteres no válidos
            }

            // Permitir solo un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains(".")))
            {
                e.Handled = true; // Bloquear la entrada de un segundo punto.
            }

            if ((e.KeyChar == '.') && (sender as TextBox).Text.Length == 0)
            {
                e.Handled = true; // Bloquear la entrada si solo se ingresa un punto.
            }
        }

        private void txtLado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains(".")))
                e.Handled = true;

            if ((e.KeyChar == '.') && (sender as TextBox).Text.Length == 0)
                e.Handled = true;
        }

        private void txtBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains(".")))
                e.Handled = true;

            if ((e.KeyChar == '.') && (sender as TextBox).Text.Length == 0)
                e.Handled = true;
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
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
                lblAreaCi.Text = ("El área del círculo es: ");
                lblPerimetroCi.Text = ("El perímetro del círculo es: ");
            }
            else if (double.TryParse(txtRadio.Text, out _))
            {
                lblAreaCi.Visible = true;
                lblPerimetroCi.Visible = true;
            }
        }

        private void txtLado_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();
            HabilitarBotonBorrar();

            if (string.IsNullOrWhiteSpace(txtLado.Text))
            {
                lblAreaCu.Text = ("El área del cuadrado es: ");
                lblPerimetroCu.Text = ("El perímetro del cuadrado es: ");
            }
            else if (double.TryParse(txtLado.Text, out _))
            {
                lblAreaCu.Visible = true;
                lblPerimetroCu.Visible = true;
            }
        }

        //Aquí, hice un método(verificarAmbosTextbox), para que los label aparezcan cuando ambos textbox del triángulo tengan datos.
        private void txtBase_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();
            VerificarAmbosTextboxs();
            HabilitarBotonBorrar();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {
            VerificarCamposNoVacios();
            VerificarAmbosTextboxs();
            HabilitarBotonBorrar();
        }

        //Este método verifica que los textbox del triángulo tengan datos, para así mostrar los label
        private void VerificarAmbosTextboxs()
        {
            if (string.IsNullOrWhiteSpace(txtAltura.Text) || (string.IsNullOrWhiteSpace(txtBase.Text)))
            {
                lblAreaTr.Text = ("El área del triángulo es: ");
                lblPerimetroTr.Text = ("El perímetro del triángulo es: ");
            }
            else if (double.TryParse(txtAltura.Text, out _) || (double.TryParse(txtBase.Text, out _)))
            {
                lblAreaTr.Visible = true;
                lblPerimetroTr.Visible = true;
            }


            if (EsNumero(txtAltura.Text) && EsNumero(txtBase.Text))
            {
                lblAreaTr.Visible = true;
                lblPerimetroTr.Visible = true;
            }
        }

        //Ayuda con la verificación de los 2 textbox del triángulo.
        private bool EsNumero(string text)
        {
            return double.TryParse(text, out _);
        }


        //Este método habilita y deshabilita los botones "Calcular" de cada figura, verificando los textbox vacíos.
      
        private void VerificarCamposNoVacios()
        {
            if (!string.IsNullOrWhiteSpace(txtBase.Text) && !string.IsNullOrWhiteSpace(txtAltura.Text))
                // Ambos campos tienen texto, habilita el botón de "calcular"
                btnCalcularT.Enabled = true;
            else
                // Al menos uno de los campos está vacío, deshabilita el botón de "calcular"
                btnCalcularT.Enabled = false;


            if (!string.IsNullOrWhiteSpace(txtLado.Text))
                btnCalcularCu.Enabled = true;
            else
                btnCalcularCu.Enabled = false;


            if (!string.IsNullOrWhiteSpace(txtRadio.Text))
                btnCalcularCi.Enabled = true;
            else
                btnCalcularCi.Enabled = false;
        }


        //Estos 3 métodos realizan los cálculos, le dan función a los botones "Calcular".
        private void btnCalcularCi_Click(object sender, EventArgs e)
        {
            //creando instancia de su respectiva clase y obteniendo el valor ingresado.
            double radio = double.Parse(txtRadio.Text);
            Circulo obj = new(radio);

            //Mostrando el resultado.
            lblAreaCi.Text = ("El área del círculo es: " + obj.CalcularArea().ToString("F2") + " cm^2");
            lblPerimetroCi.Text = ("El perímetro del círculo es: " + obj.CalcularPerimetro().ToString("F2") + " cm");
        }

        private void btnCalcularCu_Click(object sender, EventArgs e)
        {
            double lado = double.Parse(txtLado.Text);
            Cuadrado obj = new(lado);

            lblAreaCu.Text = ("El área del cuadrado es: " + obj.CalcularArea().ToString("F2") + " cm^2");
            lblPerimetroCu.Text = ("El perímetro del cuadrado es: " + obj.CalcularPerimetro().ToString("F2") + " cm");
        }

        private void btnCalcularT_Click(object sender, EventArgs e)
        {
            double Base = double.Parse(txtBase.Text);
            double Altura = double.Parse(txtAltura.Text);
            Triangulo obj = new(Base, Altura);

            lblAreaTr.Text = ("El área del triángulo es: " + obj.CalcularArea().ToString("F2") + " cm^2");
            lblPerimetroTr.Text = ("El perímetro del triángulo es: " + obj.CalcularPerimetro().ToString("F2") + " cm");
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
                txtLado.Text = "";
                txtBase.Text = "";
                txtAltura.Text = "";
                txtRadio.Focus();
                btnBorrar.Enabled = false;
            }
        }

        private void HabilitarBotonBorrar()
        {
            // Verifica si los TextBox tienen datos y habilita el botón de limpiar en consecuencia
            btnBorrar.Enabled = !string.IsNullOrWhiteSpace(txtRadio.Text) || !string.IsNullOrWhiteSpace(txtLado.Text)
                || !string.IsNullOrWhiteSpace(txtBase.Text) || !string.IsNullOrWhiteSpace(txtAltura.Text);
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
