using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Proyecto_GUI_EmpleadosNomina
{
    public partial class frmAcercaDe : Form
    {
        private MediaPlayer mediaPlayer = new MediaPlayer();

        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void frmAcercaDe_Load(object sender, EventArgs e)
        { 
            string mp3FilePath = Path.Combine(Application.StartupPath, @"sources\Sounds\bgMusic.mp3");
            mediaPlayer.Open(new Uri(mp3FilePath));

            mediaPlayer.Volume = 0.05;

            mediaPlayer.MediaEnded += (s, args) => {
                mediaPlayer.Position = TimeSpan.Zero;
                mediaPlayer.Play();
            };
            mediaPlayer.Play();
        }

        private void frmAcercaDe_FormClosing(object sender, FormClosingEventArgs e)
        {
            mediaPlayer.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
