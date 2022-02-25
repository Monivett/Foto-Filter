namespace Proyecto_Procesamiento_de_Imagenes
{
    partial class IDD_Videos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.BTN_IMAGEN = new System.Windows.Forms.Button();
            this.BTN_VIDEOS = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.BTN_Original = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_GRADIENTE = new System.Windows.Forms.Button();
            this.BTN_Invertir = new System.Windows.Forms.Button();
            this.BTN_Ruido = new System.Windows.Forms.Button();
            this.BTN_Grises = new System.Windows.Forms.Button();
            this.BTN_Contraste = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_Examinar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblRuta = new System.Windows.Forms.Label();
            this.BTN_Play = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BTN_Pausa = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BTN_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Salir.Location = new System.Drawing.Point(397, 21);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(128, 48);
            this.BTN_Salir.TabIndex = 2;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = false;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // BTN_IMAGEN
            // 
            this.BTN_IMAGEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BTN_IMAGEN.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_IMAGEN.Location = new System.Drawing.Point(50, 21);
            this.BTN_IMAGEN.Name = "BTN_IMAGEN";
            this.BTN_IMAGEN.Size = new System.Drawing.Size(128, 48);
            this.BTN_IMAGEN.TabIndex = 50;
            this.BTN_IMAGEN.Text = "Imágenes";
            this.BTN_IMAGEN.UseVisualStyleBackColor = false;
            this.BTN_IMAGEN.Click += new System.EventHandler(this.BTN_IMAGEN_Click);
            // 
            // BTN_VIDEOS
            // 
            this.BTN_VIDEOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BTN_VIDEOS.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_VIDEOS.Location = new System.Drawing.Point(219, 21);
            this.BTN_VIDEOS.Name = "BTN_VIDEOS";
            this.BTN_VIDEOS.Size = new System.Drawing.Size(128, 48);
            this.BTN_VIDEOS.TabIndex = 51;
            this.BTN_VIDEOS.Text = "Vídeos";
            this.BTN_VIDEOS.UseVisualStyleBackColor = false;
            this.BTN_VIDEOS.Click += new System.EventHandler(this.BTN_VIDEOS_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.BTN_VIDEOS);
            this.panel3.Controls.Add(this.BTN_IMAGEN);
            this.panel3.Controls.Add(this.BTN_Salir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1245, 88);
            this.panel3.TabIndex = 51;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(43, 127);
            this.Label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(253, 39);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "Filtro de Vídeos";
            // 
            // BTN_Original
            // 
            this.BTN_Original.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Original.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Original.Location = new System.Drawing.Point(926, 831);
            this.BTN_Original.Name = "BTN_Original";
            this.BTN_Original.Size = new System.Drawing.Size(160, 54);
            this.BTN_Original.TabIndex = 56;
            this.BTN_Original.Text = "Original";
            this.BTN_Original.UseVisualStyleBackColor = false;
            this.BTN_Original.Click += new System.EventHandler(this.BTN_Original_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_GRADIENTE);
            this.groupBox2.Controls.Add(this.BTN_Invertir);
            this.groupBox2.Controls.Add(this.BTN_Ruido);
            this.groupBox2.Controls.Add(this.BTN_Grises);
            this.groupBox2.Controls.Add(this.BTN_Contraste);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(832, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 469);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // BTN_GRADIENTE
            // 
            this.BTN_GRADIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_GRADIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_GRADIENTE.Location = new System.Drawing.Point(94, 217);
            this.BTN_GRADIENTE.Name = "BTN_GRADIENTE";
            this.BTN_GRADIENTE.Size = new System.Drawing.Size(143, 46);
            this.BTN_GRADIENTE.TabIndex = 10;
            this.BTN_GRADIENTE.Text = "Gradiente";
            this.BTN_GRADIENTE.UseVisualStyleBackColor = false;
            this.BTN_GRADIENTE.Click += new System.EventHandler(this.BTN_GRADIENTE_Click);
            // 
            // BTN_Invertir
            // 
            this.BTN_Invertir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Invertir.Location = new System.Drawing.Point(94, 42);
            this.BTN_Invertir.Name = "BTN_Invertir";
            this.BTN_Invertir.Size = new System.Drawing.Size(143, 46);
            this.BTN_Invertir.TabIndex = 9;
            this.BTN_Invertir.Text = "Invertir";
            this.BTN_Invertir.UseVisualStyleBackColor = false;
            this.BTN_Invertir.Click += new System.EventHandler(this.BTN_Invertir_Click);
            // 
            // BTN_Ruido
            // 
            this.BTN_Ruido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Ruido.Location = new System.Drawing.Point(94, 386);
            this.BTN_Ruido.Name = "BTN_Ruido";
            this.BTN_Ruido.Size = new System.Drawing.Size(143, 46);
            this.BTN_Ruido.TabIndex = 8;
            this.BTN_Ruido.Text = "Ruido";
            this.BTN_Ruido.UseVisualStyleBackColor = false;
            this.BTN_Ruido.Click += new System.EventHandler(this.BTN_Ruido_Click);
            // 
            // BTN_Grises
            // 
            this.BTN_Grises.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Grises.Location = new System.Drawing.Point(94, 129);
            this.BTN_Grises.Name = "BTN_Grises";
            this.BTN_Grises.Size = new System.Drawing.Size(143, 46);
            this.BTN_Grises.TabIndex = 7;
            this.BTN_Grises.Text = "Grises";
            this.BTN_Grises.UseVisualStyleBackColor = false;
            this.BTN_Grises.Click += new System.EventHandler(this.BTN_Grises_Click);
            // 
            // BTN_Contraste
            // 
            this.BTN_Contraste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Contraste.Location = new System.Drawing.Point(94, 307);
            this.BTN_Contraste.Name = "BTN_Contraste";
            this.BTN_Contraste.Size = new System.Drawing.Size(143, 46);
            this.BTN_Contraste.TabIndex = 6;
            this.BTN_Contraste.Text = "Contraste";
            this.BTN_Contraste.UseVisualStyleBackColor = false;
            this.BTN_Contraste.Click += new System.EventHandler(this.BTN_Contraste_Click);
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_GUARDAR.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(576, 831);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(160, 54);
            this.BTN_GUARDAR.TabIndex = 53;
            this.BTN_GUARDAR.Text = "Guardar vídeo";
            this.BTN_GUARDAR.UseVisualStyleBackColor = false;
            // 
            // BTN_Examinar
            // 
            this.BTN_Examinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Examinar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Examinar.Location = new System.Drawing.Point(117, 835);
            this.BTN_Examinar.Name = "BTN_Examinar";
            this.BTN_Examinar.Size = new System.Drawing.Size(160, 50);
            this.BTN_Examinar.TabIndex = 52;
            this.BTN_Examinar.Text = "Examinar...";
            this.BTN_Examinar.UseVisualStyleBackColor = false;
            this.BTN_Examinar.Click += new System.EventHandler(this.BTN_Examinar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRuta.Location = new System.Drawing.Point(52, 698);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(52, 20);
            this.lblRuta.TabIndex = 59;
            this.lblRuta.Text = "Ruta: ";
            // 
            // BTN_Play
            // 
            this.BTN_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Play.Location = new System.Drawing.Point(56, 746);
            this.BTN_Play.Name = "BTN_Play";
            this.BTN_Play.Size = new System.Drawing.Size(143, 46);
            this.BTN_Play.TabIndex = 11;
            this.BTN_Play.Text = "Play";
            this.BTN_Play.UseVisualStyleBackColor = false;
            this.BTN_Play.Click += new System.EventHandler(this.BTN_Play_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(0, 27);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(753, 442);
            this.imageBox1.TabIndex = 3;
            this.imageBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(56, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(753, 469);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vídeo";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BTN_Pausa
            // 
            this.BTN_Pausa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Pausa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Pausa.Location = new System.Drawing.Point(244, 746);
            this.BTN_Pausa.Name = "BTN_Pausa";
            this.BTN_Pausa.Size = new System.Drawing.Size(143, 46);
            this.BTN_Pausa.TabIndex = 60;
            this.BTN_Pausa.Text = "Pausa";
            this.BTN_Pausa.UseVisualStyleBackColor = false;
            this.BTN_Pausa.Click += new System.EventHandler(this.BTN_Pausa_Click);
            // 
            // IDD_Videos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1245, 971);
            this.Controls.Add(this.BTN_Pausa);
            this.Controls.Add(this.BTN_Play);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BTN_Original);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_Examinar);
            this.Controls.Add(this.panel3);
            this.Name = "IDD_Videos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IDD_Videos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IDD_Videos_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.Button BTN_IMAGEN;
        private System.Windows.Forms.Button BTN_VIDEOS;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button BTN_Original;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_GRADIENTE;
        private System.Windows.Forms.Button BTN_Invertir;
        private System.Windows.Forms.Button BTN_Ruido;
        private System.Windows.Forms.Button BTN_Grises;
        private System.Windows.Forms.Button BTN_Contraste;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_Examinar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.Button BTN_Play;
        private System.Windows.Forms.ImageList imageList1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTN_Pausa;
    }
}