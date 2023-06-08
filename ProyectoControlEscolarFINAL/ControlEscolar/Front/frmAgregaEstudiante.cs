using ConE.Entidades;
using ConE.Negocio;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using LibreriaPDF;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;

namespace ConE.Front
{
    public partial class frmAgregaEstudiante : Form
    {
        DataTable dataCarreras;
        public frmAgregaEstudiante()
        {
            InitializeComponent();
        }

        private void frmAgregaEstudiante_Load(object sender, EventArgs e)
        {
            try
            {
                string clave = NEstudiante.ObtenerClaveEstudiante();
                txtClave.Text = clave;
                dataCarreras = NCarrera.ObtenCarreras();
                cmbCarrera.DataSource = dataCarreras;
                cmbCarrera.DisplayMember = "NOMBRE CARRERA";
                cmbCarrera.ValueMember = "NOMBRE CARRERA";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!validaCarrera()) return;
            if (!validaNombre()) return;
            if (!validaDomicilio()) return;
            if (!validaCorreo()) return;
            if (!validaTelefono()) return;

            string respuesta = "";
            string nombre = txtNombre.Text;
            decimal semestre = nupSemestre.Value;
            int valorInt = cmbCarrera.SelectedIndex;
            int carrera = Convert.ToInt32(dataCarreras.Rows[valorInt][0].ToString());
            string domicilio = txtDomicilio.Text.ToString();
            string correo = txtCorreoElectronico.Text;
            string telefono = mtxtTelefono.Text;
            Estudiante estudiante = new Estudiante(nombre, semestre, carrera, domicilio, correo, telefono);
            try
            {
                respuesta = NEstudiante.Agregar(estudiante);
                if (respuesta.Equals("Ya existe estudiante"))
                {
                    MessageBox.Show("Ya existe un estudiante registrado con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Estudiante agregado con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                string clave = NEstudiante.ObtenerClaveEstudiante();
                txtClave.Text = clave;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private void limpiar()
        {
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtCorreoElectronico.Clear();
            mtxtTelefono.Clear();
            nupSemestre.Value = 1;
            cmbCarrera.SelectedIndex = 0;
        }

        private bool validaNombre()
        {
            string nombre = txtNombre.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(nombre))
            {
                error.SetError(txtNombre, "No puedes dejar este espacio vacio");
                txtNombre.Focus();
                return false;
            }
            return true;
        }

        private bool validaDomicilio()
        {
            string domicilio = txtDomicilio.Text;
            if (string.IsNullOrWhiteSpace(domicilio) || string.IsNullOrEmpty(domicilio))
            {
                error.SetError(txtDomicilio, "No puedes dejar este espacio vacio");
                txtDomicilio.Focus();
                return false;
            }
            return true;
        }

        private bool validaCorreo()
        {
            string correo = txtCorreoElectronico.Text;
            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrEmpty(correo))
            {
                error.SetError(txtCorreoElectronico, "No puedes dejar este espacio vacio");
                txtCorreoElectronico.Focus();
                return false;
            }
            return true;
        }

        private bool validaCarrera()
        {
            try
            {
                string carrera = cmbCarrera.SelectedItem.ToString();
                return true;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar una carrera primero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool validaTelefono()
        {
            string telefono = mtxtTelefono.Text;
            if (string.IsNullOrWhiteSpace(telefono) || string.IsNullOrEmpty(telefono) || telefono.Length < 12)
            {
                error.SetError(mtxtTelefono, "Ingresa un numero valido");
                mtxtTelefono.Focus();
                return false;
            }
            return true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            validaNombre();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !(char.IsWhiteSpace(e.KeyChar)))
            {
                error.SetError(txtNombre, "Solo puedes ingresar letras y espacios");
                e.Handled = true;
                return;
            }
        }

        private void txtDomicilio_Validated(object sender, EventArgs e)
        {
            validaDomicilio(); validaDomicilio();
        }

        private void txtDomicilio_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsLetter(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '#' && e.KeyChar != ',')
            {
                error.SetError(txtDomicilio, "No puedes ingresar caracteres especiales, solo letras, numeros, comas y '#'");
                e.Handled = true;
                return;
            }
        }

        private void txtCorreoElectronico_Validated(object sender, EventArgs e)
        {
            validaCorreo();
        }

        private void txtCorreoElectronico_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (e.KeyChar == (char)Keys.Space)
            {
                error.SetError(txtCorreoElectronico, "No puedes ingresar espacios en el correo electronico");
                e.Handled = true;
                return;
            }
        }

        private void mtxtTelefono_Validated(object sender, EventArgs e)
        {
            validaTelefono();
        }

        private void mtxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            error.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                error.SetError(mtxtTelefono, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {

            try
            {
                DataTable data = NEstudiante.ObtenEstudiante();
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                Document documento = Utility.CreatePDF("ReporteEstudiantes.pdf");

                documento = Utility.EncabezadoPDF(documento, "ESTUDIANTE", "Reporte de estudiantes registrados");
                string[] columnas = { "Clave estudiante", "Nombre estudiante", "Semestre", "Clave Carrera",
                "Nombre Carrera", "Materia 1", "Materia 2", "Materia 3","Materia 4", "Materia 5",
                "Domicilio", "Correo", "Telefono"};
                float[] tam = { 10, 20, 10, 10, 20, 20, 20, 20, 20, 20, 20, 20, 10};
                Table tabla = Utility.EncabezadoTabla(columnas, tam);
                foreach (DataRow row in data.Rows)
                {
                    foreach (DataColumn col in data.Columns)
                    {
                        Paragraph p = new Paragraph(row[col].ToString()).SetFont(fontNormal);
                        tabla.AddCell(new Cell().Add(p));
                    }
                }
                documento.Add(tabla);
                documento.Close();
                MessageBox.Show("Reporte Generado");
                Process.Start("ReporteEstudiantes.PDF");
 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
