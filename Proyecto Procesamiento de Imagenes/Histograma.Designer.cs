namespace Proyecto_Procesamiento_de_Imagenes
{
    partial class Histograma
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
            this.SuspendLayout();
            // 
            // Histograma
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(278, 144);
            this.Location = new System.Drawing.Point(650, 150);
            this.Name = "Histograma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Histograma";
            this.Load += new System.EventHandler(this.Histograma_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Histograma_Paint_1);
            this.ResumeLayout(false);

        }

        #endregion
    }
}