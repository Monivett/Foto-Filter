using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Procesamiento_de_Imagenes
{
    public partial class Histograma : Form
    {
        String colorPluma;
        private int[] histograma; //Cantidad de números de los pixeles
        private int mayor; //Mayor cantidad de pixeles
        public Histograma(int []pHistograma, string Color) {
            InitializeComponent();
            histograma = pHistograma;
            int n = 0;

            //Encontramos el mayor
            mayor = 0;
            for (n = 0; n < 256; n++) {

                if (histograma[n] > mayor) {
                    mayor = histograma[n];
                }
            }
            for (n = 0; n < 256; n++) {
                histograma[n] = (int)((float)histograma[n] / (float)mayor * 256.0f);
            }

            colorPluma = Color;
        }

    

        private void Histograma_Paint_1(object sender, PaintEventArgs e) {
            int n = 0;
            int altura = 0;
            Graphics gr = e.Graphics;
            Pen plumaH;
            Pen plumaEjes = new Pen(Color.White); ;
            plumaH = new Pen(Color.Black);

            if (colorPluma == "Rojo") {
             plumaH = new Pen(Color.Red);
            
            }
            if (colorPluma == "Azul") {
                plumaH = new Pen(Color.Blue);
            
            }
            if (colorPluma == "Verde") {
                plumaH = new Pen(Color.Green);
              
            }
     
            gr.DrawLine(plumaEjes, 19, 141, 300, 141); //Eje vertical
            gr.DrawLine(plumaEjes, 19, 140, 19, 14); //Eje horizontal

            for (n = 0; n < 256; n++)
            {
                gr.DrawLine(plumaH, n + 20, 139, n + 20, 139 - histograma[n]);
            }
        }

        private void Histograma_Load(object sender, EventArgs e)
        {

        }
    }
}
