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
    public partial class IDD_Imagenes : Form {
        private Bitmap original;
        private Bitmap resultante;
        private int[] histogramaR = new int[256];
        private int[] histogramaG = new int[256];
        private int[] histogramaB = new int[256];
        private int[,] conv3x3 = new int[3, 3];
        private int factor;
        private int offset;
        int[] popo;

        //VENTANAS
        Histograma hformR;
        Histograma hformG;
        Histograma hformB;
        
        Bitmap resized;
        bool bolHistograma = false;
        //Variables para el double buffer y el flicker
        PaintEventArgs p;
        private int AnchoV, AltoV;
        public IDD_Imagenes() {
            InitializeComponent();

            //Creamos el bitmap resultante del cuadro
            resultante = new Bitmap(350, 300);

            //Colocamos los valores para los dibujos de scrolls
            AnchoV = 350;
            AltoV = 300;
        }

        private void BTN_Examinar_Click(object sender, EventArgs e){

            openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK) { //Si el usuario dio OK al open dialog
             
                //Se carga la imagen
                original = (Bitmap)(Bitmap.FromFile(openFileDialog1.FileName)); //Path del archivo
                resized = new Bitmap(original, new Size(350, 300));

                AnchoV = 350;
                AltoV =300;

                resultante = resized;

                this.Invalidate(); //Lleva acabo el dibujo de la ventana

                //HISTOGRAMA
                int x = 0;
                int y = 0;
                Color rColor = new Color();

                for (x = 0; x < AnchoV; x++) {

                    for (y = 0; y < AltoV; y++) {
                        //Obtenemos el color del pixel
                        rColor = resultante.GetPixel(x, y);
                        histogramaR[rColor.R]++;
                        histogramaG[rColor.G]++;
                        histogramaB[rColor.B]++;
                    }
                }
                hformR = new Histograma(histogramaR, "Rojo");
                hformR.Text = "Rojo";
                hformR.Show();
                hformG = new Histograma(histogramaG, "Verde");
                hformG.Location = new Point(950,150);
                hformG.Text = "Verde";
                hformG.Show();
                hformB = new Histograma(histogramaB, "Azul");
                hformB.Text = "Azúl";
                hformB.Location = new Point(650, 350);
                hformB.Show();

            }
        }


        private void BTN_GUARDAR_Click(object sender, EventArgs e){

            if (saveFileDialog1.ShowDialog() == DialogResult.OK){ //Si el usuario da OK

                                //Ruta de la imagen       //Ruta donde la queremos guardar y el formato
                resultante.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png); //Guardamos el bitmap

            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e){

            //Verificamos que se tenga el bitmap instanciado
            if (resultante != null){

                //Obtenemos el objeto graphics
                Graphics g = e.Graphics;

                //Calculamos el scroll
                AutoScrollMinSize = new Size(AnchoV, AltoV); //Si la imagen es muy grande habrá scroll

                //Copiamos el bitmap a la ventana
                           //Bitmap que queremos copiar en la ventana               //Dónde vamos a colocar la imagen                            
                g.DrawImage(resultante, new Rectangle(this.AutoScrollPosition.X + 32, this.AutoScrollPosition.Y + 128, AnchoV, AltoV));

                //Liberamos el recurso 
                g.Dispose();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Imagen_Contorno(object sender, EventArgs e)
        {

        }

     

        private void BTN_Invertir_Click(object sender, EventArgs e){
            
            LimpiarHistogramas();

            //Invertimos la imagen, saca su negativo
            int x = 0;
            int y = 0;

            resultante = new Bitmap(350, 300);

            Color rColor = new Color();
            Color oColor = new Color();

            for (x = 0; x < 350; x++) {

                for (y = 0; y < 300; y++) {

                    //Obtenemos el color del pixel
                    oColor = resized.GetPixel(x, y);

                    //Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb(255 - oColor.R, 255 - oColor.G, 255 - oColor.B);

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, rColor);

                }
            }

            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {
                    //Obtenemos el color del pixel
                    rColor = resultante.GetPixel(x, y);
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }
            MostrarHistogramas(histogramaR, histogramaG, histogramaB);


            this.Invalidate();
            
        }

        private void BTN_GRADIENTE_Click(object sender, EventArgs e) {

            float r1 = 120;
            float g1 = 230;
            float b1 = 120;

            float r2 = 230;
            float g2 = 100;
            float b2 = 100;

            int r = 0;
            int g = 0;
            int b = 0;

            float dr = (r2 - r1) / AnchoV;
            float dg = (g2 - g1) / AnchoV;
            float db = (b2 - b1) / AnchoV;

            int x = 0;
            int y = 0;

            Color oColor;
            Color rColor;

            //Obtenemos los tonos de gris
            BTN_Grises_Click(sender, e);


            LimpiarHistogramas();

            for (x = 0; x < AnchoV; x++){

                for (y = 0; y < AltoV; y++){

                    //Obtenemos el color del pixel
                    oColor = resized.GetPixel(x, y);

                    //Calculamos el color
                    r = (int)((r1 / 255.0f) * oColor.R);
                    g = (int)((g1 / 255.0f) * oColor.G);
                    b = (int)((b1 / 255.0f) * oColor.B);

                    if (r > 255) {
                        r = 255;
                    }else if (r<0) {
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
                   resultante.SetPixel(x, y, Color.FromArgb(r,g,b));

                }
                //Avanzamos el color
                r1 = (r1 + dr);
                g1 = (g1 + dg);
                b1 = (b1 + db);
            }
            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++)
                {
                    //Obtenemos el color del pixel
                    rColor = resultante.GetPixel(x, y);
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }
            MostrarHistogramas(histogramaR, histogramaG, histogramaB);

            this.Invalidate();

        }

        private void BTN_Grises_Click(object sender, EventArgs e) {
            //Convertimos la imagen en tonos de grises

            LimpiarHistogramas();

            int x = 0;
            int y = 0;
            resultante = new Bitmap(AnchoV, AltoV);
            Color rColor = new Color();
            Color oColor = new Color();

            float g = 0;

            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {

                    //Obtenemos el color del pixel
                    oColor = resized.GetPixel(x, y);

                    //0.2126 0.7152 0.0722 //Colorimetrica, basada en percepción humana
                    //0.299 0.587 0.114 //Luma basado en el brillo
                    //0.267 0.678 0.0593

                    g = oColor.R * 0.299f + oColor.G * 0.587f + oColor.B * 0.114f;

                    //Procesamos y obtenemos el nuevo color
                    rColor = Color.FromArgb((int)g, (int)g, (int)g);

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, rColor);

                }
            }
            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {
                    //Obtenemos el color del pixel
                    rColor = resultante.GetPixel(x, y);
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }
            MostrarHistogramas(histogramaR, histogramaG, histogramaB);
            this.Invalidate();

        }

        private void BTN_Contraste_Click(object sender, EventArgs e){

            //Modificamos el contraste de la imagen

            LimpiarHistogramas();

            int contraste = 30; //El valor va de -100 a 100

            float c =(100.0f + contraste) /100.0f;
            c *= c;

            int x = 0;
            int y = 0;

            resultante = new Bitmap(AnchoV, AltoV);

            Color rColor = new Color();
            Color oColor = new Color();

            float r = 0;
            float g = 0;
            float b = 0;
          

            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {

                    //Obtenemos el color del pixel
                    oColor = resized.GetPixel(x, y);

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

                    if (b > 255){
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

            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {
                    //Obtenemos el color del pixel
                    rColor = resultante.GetPixel(x, y);
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }
            MostrarHistogramas(histogramaR, histogramaG, histogramaB);

            this.Invalidate();

        }

        private void BTN_Ruido_Click(object sender, EventArgs e) {

            LimpiarHistogramas();

            int x = 0;
            int y = 0;
            int porcentaje = 15;

            //0 a 200
            int rangoMin = 85;
            int rangoMax = 255;
            float pBrillo = 0;

            Random rnd = new Random();
            Color rColor;
            Color oColor;

            int r = 0;
            int g = 0;
            int b = 0;

            resultante = new Bitmap(AnchoV, AltoV);

            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {

                    //Verificamos si el pixel tiene ruido o no

                    if(rnd.Next(1,100) <= porcentaje) {

                        //metodo 1
                        //Procesamos y obtenemos el nuevo color
                        rColor = Color.FromArgb(rnd.Next(rangoMin, rangoMax), rnd.Next(rangoMin, rangoMax), rnd.Next(rangoMin, rangoMax));
                    } else {
                        rColor = resized.GetPixel(x, y);
                    }

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, rColor);

                }
            }

            this.Invalidate();


            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {

                    //Obtenemos el color del pixel
                    rColor = resultante.GetPixel(x, y);
                    histogramaR[rColor.R]++;
                    histogramaG[rColor.G]++;
                    histogramaB[rColor.B]++;
                }
            }
            MostrarHistogramas(histogramaR, histogramaG, histogramaB);
        }

        private void BTN_VIDEOS_Click(object sender, EventArgs e) {
            LimpiarHistogramas();
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

        private void IDD_Imagenes_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Original_Click(object sender, EventArgs e){

            LimpiarHistogramas();

            int x = 0;
            int y = 0;

            resultante = new Bitmap(350, 300);

            Color oColor = new Color();

            for (x = 0; x < 350; x++) {

                for (y = 0; y < 300; y++) {

                    //Obtenemos el color del pixel
                    oColor = resized.GetPixel(x, y);

                    //Colocamos el color en el resultante
                    resultante.SetPixel(x, y, oColor);

                }
            }

            this.Invalidate();


            for (x = 0; x < AnchoV; x++) {

                for (y = 0; y < AltoV; y++) {

                    //Obtenemos el color del pixel
                    oColor = resultante.GetPixel(x, y);
                    histogramaR[oColor.R]++;
                    histogramaG[oColor.G]++;
                    histogramaB[oColor.B]++;
                }
            }
            MostrarHistogramas(histogramaR, histogramaG, histogramaB);
        }

        private void LimpiarHistogramas() {
        
            hformR.Hide();
            hformG.Hide();
            hformB.Hide();
        
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MostrarHistogramas(int[] histogramaR, int[] histogramaG, int[] histogramaB)
        {
            hformR = new Histograma(histogramaR, "Rojo");
            hformR.Text = "Rojo";
            hformR.Show();
            hformG = new Histograma(histogramaG, "Verde");
            hformG.Location = new Point(950, 150);
            hformG.Text = "Verde";
            hformG.Show();
            hformB = new Histograma(histogramaB, "Azul");
            hformB.Text = "Azúl";
            hformB.Location = new Point(650, 350);
            hformB.Show();
        }

    }

    }

