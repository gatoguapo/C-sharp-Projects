using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Media;

namespace ConE.Front
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
            string directoryPath = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(directoryPath, @"sources\Sounds\bgMusic.mp3");
            mediaPlayer.Open(new Uri(filePath));

            mediaPlayer.Volume = 0.05;

            mediaPlayer.MediaEnded += (s, args) =>
            {
                mediaPlayer.Position = TimeSpan.Zero;
                mediaPlayer.Play();
            };
            mediaPlayer.Play();
        }
    }
}
