using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using iText.Layout;
using iText.Layout.Element;
using System.Windows.Forms;

namespace Ejemplo1iText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CreatePDF(string dest)
        {
            //Initialize PDF writer
            PdfWriter writer = new PdfWriter(dest);

            PdfDocument pdf = new PdfDocument(writer);

            Document document = new Document(pdf, PageSize.LETTER);
            document.SetMargins(60, 20, 55, 20);

            document.Add(new Paragraph("Hola Ramirez!"));
            document.Add(new Paragraph("Como estas?"));

            document.Close();
        }

        private void btnCrear_Click(object sender, System.EventArgs e)
        {
            CreatePDF("EJEMPLO1.PDF");
            MessageBox.Show("DOCUMENTO CREADO");
        }
    }   
}
