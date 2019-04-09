namespace Actividad.vista.Proyecto
{
    partial class Reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reproductor));
            this.textBoxTituloPelicula = new System.Windows.Forms.TextBox();
            this.textBoxIdPelicula = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelDuracion = new System.Windows.Forms.Label();
            this.textBoxDuracion = new System.Windows.Forms.TextBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.textBoxFechaPelicula = new System.Windows.Forms.TextBox();
            this.labelDirector = new System.Windows.Forms.Label();
            this.textBoxDirectorPelicula = new System.Windows.Forms.TextBox();
            this.textBoxResumen = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTituloPelicula
            // 
            this.textBoxTituloPelicula.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTituloPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTituloPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxTituloPelicula.Location = new System.Drawing.Point(12, 12);
            this.textBoxTituloPelicula.Name = "textBoxTituloPelicula";
            this.textBoxTituloPelicula.Size = new System.Drawing.Size(696, 38);
            this.textBoxTituloPelicula.TabIndex = 0;
            this.textBoxTituloPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxIdPelicula
            // 
            this.textBoxIdPelicula.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxIdPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIdPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxIdPelicula.Location = new System.Drawing.Point(42, 54);
            this.textBoxIdPelicula.Name = "textBoxIdPelicula";
            this.textBoxIdPelicula.Size = new System.Drawing.Size(64, 26);
            this.textBoxIdPelicula.TabIndex = 1;
            this.textBoxIdPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(12, 60);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(24, 16);
            this.labelId.TabIndex = 2;
            this.labelId.Text = "ID:";
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDuracion.Location = new System.Drawing.Point(112, 60);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(65, 16);
            this.labelDuracion.TabIndex = 3;
            this.labelDuracion.Text = "Duración:";
            // 
            // textBoxDuracion
            // 
            this.textBoxDuracion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDuracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDuracion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDuracion.Location = new System.Drawing.Point(183, 54);
            this.textBoxDuracion.Name = "textBoxDuracion";
            this.textBoxDuracion.Size = new System.Drawing.Size(79, 26);
            this.textBoxDuracion.TabIndex = 4;
            this.textBoxDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(268, 60);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(49, 16);
            this.labelFecha.TabIndex = 5;
            this.labelFecha.Text = "Fecha:";
            // 
            // textBoxFechaPelicula
            // 
            this.textBoxFechaPelicula.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFechaPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFechaPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFechaPelicula.Location = new System.Drawing.Point(323, 54);
            this.textBoxFechaPelicula.Name = "textBoxFechaPelicula";
            this.textBoxFechaPelicula.Size = new System.Drawing.Size(93, 26);
            this.textBoxFechaPelicula.TabIndex = 6;
            this.textBoxFechaPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDirector.Location = new System.Drawing.Point(422, 60);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(58, 16);
            this.labelDirector.TabIndex = 7;
            this.labelDirector.Text = "Director:";
            // 
            // textBoxDirectorPelicula
            // 
            this.textBoxDirectorPelicula.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDirectorPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDirectorPelicula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDirectorPelicula.Location = new System.Drawing.Point(486, 54);
            this.textBoxDirectorPelicula.Name = "textBoxDirectorPelicula";
            this.textBoxDirectorPelicula.Size = new System.Drawing.Size(222, 26);
            this.textBoxDirectorPelicula.TabIndex = 8;
            this.textBoxDirectorPelicula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxResumen
            // 
            this.textBoxResumen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResumen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResumen.Location = new System.Drawing.Point(15, 86);
            this.textBoxResumen.Name = "textBoxResumen";
            this.textBoxResumen.Size = new System.Drawing.Size(620, 38);
            this.textBoxResumen.TabIndex = 9;
            this.textBoxResumen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 162);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(696, 406);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::Actividad.Properties.Resources.home;
            this.pictureBoxHome.Location = new System.Drawing.Point(641, 86);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(67, 38);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 11;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRuta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxRuta.Location = new System.Drawing.Point(12, 130);
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(696, 26);
            this.textBoxRuta.TabIndex = 12;
            this.textBoxRuta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(720, 580);
            this.Controls.Add(this.textBoxRuta);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.textBoxResumen);
            this.Controls.Add(this.textBoxDirectorPelicula);
            this.Controls.Add(this.labelDirector);
            this.Controls.Add(this.textBoxFechaPelicula);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.textBoxDuracion);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxIdPelicula);
            this.Controls.Add(this.textBoxTituloPelicula);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reproductor";
            this.Text = "Reproductor";
            this.Load += new System.EventHandler(this.Reproductor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTituloPelicula;
        private System.Windows.Forms.TextBox textBoxIdPelicula;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelDuracion;
        private System.Windows.Forms.TextBox textBoxDuracion;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxFechaPelicula;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.TextBox textBoxDirectorPelicula;
        private System.Windows.Forms.TextBox textBoxResumen;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.TextBox textBoxRuta;
    }
}