using ClinicaM.Entidades;
using ClinicaM.Negocio;
using System;
using System.Data;
using System.Windows.Forms;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using LibreriaPDF;
using System.Diagnostics;

namespace ClinicaM.Front
{
    public partial class frmAgregaCitaMedica : Form
    {
        DataTable dataMedico;
        public frmAgregaCitaMedica()
        {
            InitializeComponent();
        }

        private void frmAgregaCitaMedica_Load(object sender, System.EventArgs e)
        {
            try
            {
                dataMedico = NMedico.ObtenMedicos();
                cmbClaveMedico.DataSource = dataMedico;
                cmbClaveMedico.DisplayMember = "CLAVE MEDICO";
                cmbClaveMedico.ValueMember = "CLAVE MEDICO";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, System.EventArgs e)
        {
            cmbClaveMedico.SelectedIndex = 0;
            cmbHora.SelectedIndex = 0;
            mtxtFechaCita.Clear();
            txtNombrePaciente.Clear();
            txtObservaciones.Clear();
            txtTelefono.Clear();
        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            if (!validaClaveMedico()) return;
            if (!validaNombre()) return;
            if (!validaFecha()) return;
            if (!validaTelefono()) return;
            if (!validaHora()) return;
            errorP.Clear();

            string respuesta = "";
            int valorInt = cmbClaveMedico.SelectedIndex;
            int claveMedico = Convert.ToInt32(dataMedico.Rows[valorInt][0].ToString());
            string nombre = txtNombrePaciente.Text;
            string fecha = mtxtFechaCita.Text.ToString();
            string telefono = txtTelefono.Text.ToString();
            string hora = cmbHora.SelectedItem.ToString();
            string observaciones = txtObservaciones.Text;
            CitaMedica cita = new CitaMedica(claveMedico, fecha, hora, nombre, telefono, observaciones);
            try
            {
                respuesta = NCitaMedica.Agregar(cita);
                if (respuesta.Equals("Ya existe cita"))
                {
                    MessageBox.Show("Ya existe una cita a esa hora", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Cita agregada con exito", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }
        }

        private bool validaNombre()
        {
            string nombre = txtNombrePaciente.Text;
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrEmpty(nombre))
            {
                errorP.SetError(txtNombrePaciente, "No puedes dejar este espacio vacio");
                txtNombrePaciente.Focus();
                return false;
            }
            return true;
        }

        private bool validaTelefono()
        {
            string telefono = txtTelefono.Text;
            if (string.IsNullOrWhiteSpace(telefono) || string.IsNullOrEmpty(telefono) || telefono.Length<10)
            {
                errorP.SetError(txtTelefono, "Ingresa un telefono valido");
                txtTelefono.Focus();
                return false;
            }
            return true;
        }

        private bool validaClaveMedico()
        {
            try
            {
                string claveMedico = cmbClaveMedico.SelectedItem.ToString();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool validaFecha()
        {
            string fecha = mtxtFechaCita.Text;
            if (string.IsNullOrWhiteSpace(fecha) || string.IsNullOrEmpty(fecha) || fecha.Length<10)
            {
                errorP.SetError(mtxtFechaCita, "Ingresa una fecha valida");
                mtxtFechaCita.Focus();
                return false;
            }
            return true;
        }

        private bool validaHora()
        {
            try
            {
                string hora = cmbHora.SelectedItem.ToString();
                return true;
            }
            catch
            {
                errorP.SetError(cmbHora, "Debes seleccionar una hora");
                cmbHora.Focus();
                return false;
            }
        }

        private void txtNombrePaciente_Validated(object sender, System.EventArgs e)
        {
            validaNombre();
        }

        private void txtNombrePaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorP.SetError(txtNombrePaciente, "Solo puedes ingresar letras y espacios");
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_Validated(object sender, System.EventArgs e)
        {
            validaTelefono();
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(txtTelefono, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void txtObservaciones_Validated(object sender, System.EventArgs e)
        {}

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && !(char.IsWhiteSpace(e.KeyChar)))
            {
                errorP.SetError(txtObservaciones, "Solo puedes ingresar letras y espacios");
                e.Handled = true;
                return;
            }
        }

        private void mtxtFechaCita_Validated(object sender, System.EventArgs e)
        {
            validaFecha();
        }

        private void mtxtFechaCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            errorP.Clear();
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                errorP.SetError(mtxtFechaCita, "Solo puedes ingresar numeros");
                e.Handled = true;
                return;
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable data = NCitaMedica.ObtenCitas();
                PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
                Document documento = Utility.CreatePDF("ReporteCitasMedicas.PDF");

                documento = Utility.EncabezadoPDF(documento, "CLINICA MEDICA",
                    "Reporte de Citas Medicas");
                string[] columnas = { "Clave Cita", "Clave Medico", "Nombre del Medico", "Fecha", "Hora", "Nombre del Paciente", "Telefono del Paciente", "Observaciones" };
                float[] tam = { 10, 10, 40, 20, 20, 40, 20, 40 };
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
                Process.Start("ReporteCitasMedicas.PDF");
                documento.Close();
                MessageBox.Show("Reporte Generado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
