namespace Actividad.vista.Proyecto
{
    partial class Musica
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
            this.labelTituloMusica = new System.Windows.Forms.Label();
            this.pictureBoxTuesday = new System.Windows.Forms.PictureBox();
            this.pictureBoxParadise = new System.Windows.Forms.PictureBox();
            this.pictureBoxPagarte = new System.Windows.Forms.PictureBox();
            this.pictureBoxBlame = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTuesday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParadise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPagarte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTituloMusica
            // 
            this.labelTituloMusica.AutoSize = true;
            this.labelTituloMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMusica.ForeColor = System.Drawing.Color.Cyan;
            this.labelTituloMusica.Location = new System.Drawing.Point(276, 22);
            this.labelTituloMusica.Name = "labelTituloMusica";
            this.labelTituloMusica.Size = new System.Drawing.Size(143, 42);
            this.labelTituloMusica.TabIndex = 3;
            this.labelTituloMusica.Text = "Música";
            // 
            // pictureBoxTuesday
            // 
            this.pictureBoxTuesday.Image = global::Actividad.Properties.Resources.tuesday;
            this.pictureBoxTuesday.Location = new System.Drawing.Point(236, 93);
            this.pictureBoxTuesday.Name = "pictureBoxTuesday";
            this.pictureBoxTuesday.Size = new System.Drawing.Size(159, 153);
            this.pictureBoxTuesday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTuesday.TabIndex = 7;
            this.pictureBoxTuesday.TabStop = false;
            this.pictureBoxTuesday.Click += new System.EventHandler(this.pictureBoxTuesday_Click);
            // 
            // pictureBoxParadise
            // 
            this.pictureBoxParadise.Image = global::Actividad.Properties.Resources.paradise;
            this.pictureBoxParadise.Location = new System.Drawing.Point(458, 84);
            this.pictureBoxParadise.Name = "pictureBoxParadise";
            this.pictureBoxParadise.Size = new System.Drawing.Size(250, 258);
            this.pictureBoxParadise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxParadise.TabIndex = 6;
            this.pictureBoxParadise.TabStop = false;
            this.pictureBoxParadise.Click += new System.EventHandler(this.pictureBoxParadise_Click);
            // 
            // pictureBoxPagarte
            // 
            this.pictureBoxPagarte.Image = global::Actividad.Properties.Resources.como_pagarte;
            this.pictureBoxPagarte.Location = new System.Drawing.Point(223, 273);
            this.pictureBoxPagarte.Name = "pictureBoxPagarte";
            this.pictureBoxPagarte.Size = new System.Drawing.Size(196, 195);
            this.pictureBoxPagarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPagarte.TabIndex = 5;
            this.pictureBoxPagarte.TabStop = false;
            this.pictureBoxPagarte.Click += new System.EventHandler(this.pictureBoxPagarte_Click);
            // 
            // pictureBoxBlame
            // 
            this.pictureBoxBlame.Image = global::Actividad.Properties.Resources.blame;
            this.pictureBoxBlame.Location = new System.Drawing.Point(36, 93);
            this.pictureBoxBlame.Name = "pictureBoxBlame";
            this.pictureBoxBlame.Size = new System.Drawing.Size(156, 153);
            this.pictureBoxBlame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlame.TabIndex = 4;
            this.pictureBoxBlame.TabStop = false;
            this.pictureBoxBlame.Click += new System.EventHandler(this.pictureBoxBlame_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::Actividad.Properties.Resources.home;
            this.pictureBoxHome.Location = new System.Drawing.Point(611, 372);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(97, 96);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 2;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // Musica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(720, 480);
            this.Controls.Add(this.pictureBoxTuesday);
            this.Controls.Add(this.pictureBoxParadise);
            this.Controls.Add(this.pictureBoxPagarte);
            this.Controls.Add(this.pictureBoxBlame);
            this.Controls.Add(this.labelTituloMusica);
            this.Controls.Add(this.pictureBoxHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Musica";
            this.Text = "Musica";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTuesday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParadise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPagarte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Label labelTituloMusica;
        private System.Windows.Forms.PictureBox pictureBoxBlame;
        private System.Windows.Forms.PictureBox pictureBoxPagarte;
        private System.Windows.Forms.PictureBox pictureBoxParadise;
        private System.Windows.Forms.PictureBox pictureBoxTuesday;
    }
}