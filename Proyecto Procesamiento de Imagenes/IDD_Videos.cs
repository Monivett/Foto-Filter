using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Capture = Emgu.CV.Capture;

namespace Proyecto_Procesamiento_de_Imagenes {
    public partial class IDD_Videos : Form {

        String Filtro;


        Capture captureVideo;
        Image<Bgr, Byte> currentFrame;
        Bitmap temp;

        private String ruta = "";
        private Bitmap original;
        private Bitmap resultante;


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

            OpenFileDialog videoDoc = new OpenFileDialog();

            videoDoc.Filter = "Files (*.mp4)|*.mp4";

            if (videoDoc.ShowDialog() == DialogResult.OK) {

                ruta = videoDoc.FileName;
                captureVideo = new Capture(videoDoc.FileName);
                currentFrame = captureVideo.QueryFrame().Resize(700, 290, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                imageBox1.Image = currentFrame;

                lblRuta.Text = ruta;
            }

        }

        private void BTN_Play_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                timer1.Enabled = true;
            }

        }

        private void BTN_Invertir_Click(object sender, EventArgs e) {
            Filtro = "Invertir";
        }

        private void timer1_Tick(object sender, EventArgs e) {

            currentFrame = captureVideo.QueryFrame().Resize(700, 290, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC); ;
            temp = currentFrame.Bitmap;

            if (currentFrame != null) {

                imageBox1.Image = currentFrame;

                if (Filtro == "Invertir") {
                    Invertir(temp);
                }
                if (Filtro == "Grises") {
                    Grises(temp);
                }
                if (Filtro == "Gradiante") {
                    Gradiante(temp);
                }
                if (Filtro == "Contraste") {
                    Contraste(temp);
                }
                if (Filtro == "Grises") {
                    Grises(temp);
                }
                if (Filtro == "Ruido") {
                    Ruido(temp);
                }
                if (Filtro == "Original") {
                    Original(temp);
                }
            }
            else {
                timer1.Enabled = false;
            }
        }

        private void BTN_Pausa_Click(object sender, EventArgs e) {
            if (currentFrame != null) {
                timer1.Enabled = false;

            }
            else {
                imageBox1.Image = currentFrame;
            }
        }

        private void BTN_Grises_Click(object sender, EventArgs e) {
            Filtro = "Grises";
        }

        private void BTN_GRADIENTE_Click(object sender, EventArgs e) {
            Filtro = "Gradiante";
        }

        private void BTN_Contraste_Click(object sender, EventArgs e) {
           
            Filtro = "Contraste";
        }
        
        private void BTN_Ruido_Click(object sender, EventArgs e) {
            Filtro = "Ruido";
        }

        private void BTN_Original_Click(object sender, EventArgs e){
            Filtro = "Original";
        }

        //FUNCIONES
        private void Invertir(Bitmap original) {
            //Invertimos la imagen, saca su negativo
            int x = 0;
            int y = 0;
            original = currentFrame.Bitmap;
            resultante = original;

            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 1; x < original.Width - 1; x++)
            {

                for (y = 1; y < original.Height - 1; y++)
                {

                    //Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    //Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, rColor);

                }
            }

            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(resultante);
            imageBox1.Image = myImage;
        }

        private void Grises(Bitmap original) {

            //Convertimos la imagen en tonos de grises
            int x = 0;
            int y = 0;
            float g = 0;

            original = currentFrame.Bitmap;
            resultante = original;

            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 1; x < original.Width - 1; x++) {

                for (y = 1; y < original.Height - 1; y++) {

                    //Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;

                    //Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, rColor);

                }
            }

            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(resultante);
            imageBox1.Image = myImage;
        }

        private void Gradiante(Bitmap original) {

            original = currentFrame.Bitmap;
            resultante = original;

            float r1 = 120;
            float g1 = 230;
            float b1 = 120;

            float r2 = 230;
            float g2 = 100;
            float b2 = 100;

            int r = 0;
            int g = 0;
            int b = 0;

            float dr = (r2 - r1) / original.Width;
            float dg = (g2 - g1) / original.Width;
            float db = (b2 - b1) / original.Width;

            int x = 0;
            int y = 0;

            Color oColor;
            //Color rColor;

            //Obtenemos los tonos de gris
            Grises(original);

            for (x = 1; x < original.Width - 1; x++) {

                for (y = 1; y < original.Height - 1; y++) { 
                    //Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    //Calculamos el color
                    r = (int)((r1 / 255.0f) * oColor.R);
                    g = (int)((g1 / 255.0f) * oColor.G);
                    b = (int)((b1 / 255.0f) * oColor.B);

                    if (r > 255) {
                        r = 255;
                    }
                    else if (r < 0) {
                        r = 0;
                    }

                    if (g > 255) {
                        g = 255;
                    }
                    else if (g < 0) {
                        g = 0;
                    }

                    if (b > 255) {
                        b = 255;
                    }
                    else if (b < 0) {
                        b = 0;
                    }

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, Color.FromArgb(r, g, b));

                }
                //Avanzamos el color
                r1 = (r1 + dr);
                g1 = (g1 + dg);
                b1 = (b1 + db);
            }

            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(resultante);
            imageBox1.Image = myImage;
        }

        private void Contraste(Bitmap original) {

            //Modificamos el contraste de la imagen

            int contraste = 30; //El valor va de -100 a 100

            float c = (100.0f + contraste) / 100.0f;
            c *= c;

            int x = 0;
            int y = 0;

            original = currentFrame.Bitmap;
            resultante = original;

            Color rColor = new Color();
            Color oColor = new Color();

            float r = 0;
            float g = 0;
            float b = 0;


            for (x = 0; x < original.Width; x++) {

                for (y = 0; y < original.Height; y++) {

                    //Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    r = ((((oColor.R / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    g = ((((oColor.G / 255.0f) - 0.5f) * c) + 0.5f) * 255;
                    b = ((((oColor.B / 255.0f) - 0.5f) * c) + 0.5f) * 255;

                    if (r > 255) {
                        r = 255;
                    }
                    else if (r < 0) {
                        r = 0;
                    }

                    if (g > 255) {
                        g = 255;
                    }
                    else if (g < 0) {
                        g = 0;
                    }

                    if (b > 255) {
                        b = 255;
                    }
                    else if (b < 0) {
                        b = 0;
                    }

                    //Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, rColor);

                }

            }

            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(resultante);
            imageBox1.Image = myImage;
        }

        private void Ruido(Bitmap original) {
            int x = 0;
            int y = 0;
            int porcentaje = 15;

            //0 a 200
            int rangoMin = 85;
            int rangoMax = 255;
            float pBrillo = 0;

            Random rnd = new Random();
            Color rColor;
          

            int r = 0;
            int g = 0;
            int b = 0;


            original = currentFrame.Bitmap;
            resultante = original;

            for (x = 0; x < original.Width; x++) {

                for (y = 0; y < original.Height; y++) {

                    //Verificamos si el pixel tiene ruido o no

                    if (rnd.Next(1, 100) <= porcentaje) {

                        //metodo 1
                        //Procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(rnd.Next(rangoMin, rangoMax), rnd.Next(rangoMin, rangoMax), rnd.Next(rangoMin, rangoMax));
                    }
                    else {
                        rColor = original.GetPixel(x, y);
                    }

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, rColor);

                }
            }

            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(resultante);
            imageBox1.Image = myImage;

        }

        private void Original(Bitmap original) {

            int x = 0;
            int y = 0;

            original = currentFrame.Bitmap;
            resultante = original;

            Color oColor = new Color();

            for (x = 0; x < original.Width; x++) {

                for (y = 0; y < original.Height; y++) {

                    //Obtenemos el color del pixel
                    oColor = original.GetPixel(x, y);

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, oColor);

                }
            }

            Image<Bgr, Byte> myImage = new Image<Bgr, Byte>(resultante);
            imageBox1.Image = myImage;
        }

 
    }
}
