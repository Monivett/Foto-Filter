using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Procesamiento_de_Imagenes {
    public partial class IDD_Videos : Form {

        private String ruta ="";
          private Bitmap original;
        public IDD_Videos() {
            InitializeComponent();
        }

        private void BTN_VIDEOS_Click(object sender, EventArgs e)
        {

        }

        private void BTN_IMAGEN_Click(object sender, EventArgs e) {

            //Abrimos la ventana
            IDD_Videos Pvideos = new IDD_Videos();
            Pvideos.Show();

            //Cerramos la ventana
            this.Hide();
        }

        private void BTN_Salir_Click(object sender, EventArgs e) {
            //Cerramos la aplicación
            this.Close();
        }

        private void BTN_Examinar_Click(object sender, EventArgs e) {

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
            }

        }

        private void BTN_Play_Click(object sender, EventArgs e){
            axWindowsMediaPlayer2.URL = ruta;
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void BTN_Invertir_Click(object sender, EventArgs e)
        {

        }
    }
}
