using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraGUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            try
            {
                num1 = Convert.ToInt32(txtNum1.Text);
                num2  = Convert.ToInt32(txtNum2.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Debe de introducir solo numeros",
                "ERROR SUMA!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            lblOperacion.Text = "S U M A (+)";
            int operacion = num1 + num2;
            txtResultado.Text = operacion.ToString();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { 
            if (MessageBox.Show("Seguro que deseas limpiar las cajas de texto?",
                "Limpiando cajas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information
                ) == DialogResult.Yes)
            {
                txtNum1.Text = "";
                txtNum2.Text = "";
                txtResultado.Text = "";
                lblOperacion.Text = "- ninguna -";
                MessageBox.Show("Borrado con exito!",
                "Limpiando cajas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            } else
            {
                MessageBox.Show("No se limpiaron las cajas",
                "Limpiando cajas",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            try
            {
                num1 = Convert.ToInt32(txtNum1.Text);
                num2 = Convert.ToInt32(txtNum2.Text);
            } catch (FormatException)
            {
                MessageBox.Show("Debe de introducir solo numeros",
                "ERROR RESTA!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            lblOperacion.Text = "R E S T A (-)";
            int operacion = num1 - num2;
            txtResultado.Text = operacion.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int num1 = 0, num2 = 0;
            try
            {
                num1 = Convert.ToInt32(txtNum1.Text);
                num2 = Convert.ToInt32(txtNum2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe de introducir solo numeros",
                "ERROR MULTIPLICACION!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            lblOperacion.Text = "MULTIPLICACION (X)";
            int operacion = num1 * num2;
            txtResultado.Text = operacion.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0;
            try
            {
                num1 = Convert.ToDouble(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe de introducir solo numeros",
                "ERROR DIVISION!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            lblOperacion.Text = "DIVISION (÷)";
            double operacion = num1 / num2;
            txtResultado.Text = operacion.ToString();
        }
    }
}
