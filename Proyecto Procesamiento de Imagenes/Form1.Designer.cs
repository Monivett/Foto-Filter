namespace Proyecto_Procesamiento_de_Imagenes
{
    partial class IDD_Imagenes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Examinar = new System.Windows.Forms.Button();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.BTN_Salir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_GRADIENTE = new System.Windows.Forms.Button();
            this.BTN_Invertir = new System.Windows.Forms.Button();
            this.BTN_Ruido = new System.Windows.Forms.Button();
            this.BTN_Grises = new System.Windows.Forms.Button();
            this.BTN_Contraste = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Original = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BTN_VIDEOS = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Examinar
            // 
            this.BTN_Examinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Examinar.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Examinar.Location = new System.Drawing.Point(125, 698);
            this.BTN_Examinar.Name = "BTN_Examinar";
            this.BTN_Examinar.Size = new System.Drawing.Size(160, 50);
            this.BTN_Examinar.TabIndex = 0;
            this.BTN_Examinar.Text = "Examinar...";
            this.BTN_Examinar.UseVisualStyleBackColor = false;
            this.BTN_Examinar.Click += new System.EventHandler(this.BTN_Examinar_Click);
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_GUARDAR.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_GUARDAR.Location = new System.Drawing.Point(372, 694);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(160, 54);
            this.BTN_GUARDAR.TabIndex = 1;
            this.BTN_GUARDAR.Text = "Guardar imagen";
            this.BTN_GUARDAR.UseVisualStyleBackColor = false;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.BTN_Salir.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_Salir.Location = new System.Drawing.Point(404, 21);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(128, 48);
            this.BTN_Salir.TabIndex = 2;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = false;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_GRADIENTE);
            this.groupBox2.Controls.Add(this.BTN_Invertir);
            this.groupBox2.Controls.Add(this.BTN_Ruido);
            this.groupBox2.Controls.Add(this.BTN_Grises);
            this.groupBox2.Controls.Add(this.BTN_Contraste);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(622, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 469);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtros";
            // 
            // BTN_GRADIENTE
            // 
            this.BTN_GRADIENTE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_GRADIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTN_GRADIENTE.Location = new System.Drawing.Point(93, 231);
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
            this.BTN_Invertir.Location = new System.Drawing.Point(93, 57);
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
            this.BTN_Ruido.Location = new System.Drawing.Point(93, 400);
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
            this.BTN_Grises.Location = new System.Drawing.Point(93, 143);
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
            this.BTN_Contraste.Location = new System.Drawing.Point(93, 321);
            this.BTN_Contraste.Name = "BTN_Contraste";
            this.BTN_Contraste.Size = new System.Drawing.Size(143, 46);
            this.BTN_Contraste.TabIndex = 6;
            this.BTN_Contraste.Text = "Contraste";
            this.BTN_Contraste.UseVisualStyleBackColor = false;
            this.BTN_Contraste.Click += new System.EventHandler(this.BTN_Contraste_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(50, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 469);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // BTN_Original
            // 
            this.BTN_Original.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.BTN_Original.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Original.Location = new System.Drawing.Point(705, 694);
            this.BTN_Original.Name = "BTN_Original";
            this.BTN_Original.Size = new System.Drawing.Size(160, 54);
            this.BTN_Original.TabIndex = 11;
            this.BTN_Original.Text = "Original";
            this.BTN_Original.UseVisualStyleBackColor = false;
            this.BTN_Original.Click += new System.EventHandler(this.BTN_Original_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(93)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.BTN_VIDEOS);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.BTN_Salir);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1846, 88);
            this.panel3.TabIndex = 49;
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(50, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 50;
            this.button1.Text = "Imágenes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Label1.Location = new System.Drawing.Point(43, 125);
            this.Label1.MaximumSize = new System.Drawing.Size(500, 500);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(304, 39);
            this.Label1.TabIndex = 48;
            this.Label1.Text = "Filtro de Imágenes";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(989, 745);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(528, 260);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Azul";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(989, 470);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 231);
            this.groupBox4.TabIndex = 51;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Verde";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(989, 191);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(528, 240);
            this.groupBox5.TabIndex = 52;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Rojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(982, 125);
            this.label2.MaximumSize = new System.Drawing.Size(500, 500);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 53;
            this.label2.Text = "Histograma";
            // 
            // IDD_Imagenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(16)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1846, 1050);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BTN_Original);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BTN_GUARDAR);
            this.Controls.Add(this.BTN_Examinar);
            this.Name = "IDD_Imagenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro de Imágenes";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Examinar;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.Button BTN_Salir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_Contraste;
        private System.Windows.Forms.Button BTN_GRADIENTE;
        private System.Windows.Forms.Button BTN_Invertir;
        private System.Windows.Forms.Button BTN_Ruido;
        private System.Windows.Forms.Button BTN_Grises;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Original;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BTN_VIDEOS;
        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        internal System.Windows.Forms.Label label2;
    }
}

