namespace Actividad.vista.Proyecto
{
    partial class Visualizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visualizador));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxPausa = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlay = new System.Windows.Forms.PictureBox();
            this.pictureBoxAtras = new System.Windows.Forms.PictureBox();
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(719, 357);
            this.axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Image = global::Actividad.Properties.Resources.stop;
            this.pictureBoxStop.Location = new System.Drawing.Point(425, 374);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(93, 35);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStop.TabIndex = 15;
            this.pictureBoxStop.TabStop = false;
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxStop_Click);
            // 
            // pictureBoxPausa
            // 
            this.pictureBoxPausa.Image = global::Actividad.Properties.Resources.pausa;
            this.pictureBoxPausa.Location = new System.Drawing.Point(290, 374);
            this.pictureBoxPausa.Name = "pictureBoxPausa";
            this.pictureBoxPausa.Size = new System.Drawing.Size(97, 35);
            this.pictureBoxPausa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPausa.TabIndex = 14;
            this.pictureBoxPausa.TabStop = false;
            this.pictureBoxPausa.Click += new System.EventHandler(this.pictureBoxPausa_Click);
            // 
            // pictureBoxPlay
            // 
            this.pictureBoxPlay.Image = global::Actividad.Properties.Resources.play;
            this.pictureBoxPlay.Location = new System.Drawing.Point(159, 374);
            this.pictureBoxPlay.Name = "pictureBoxPlay";
            this.pictureBoxPlay.Size = new System.Drawing.Size(88, 36);
            this.pictureBoxPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlay.TabIndex = 13;
            this.pictureBoxPlay.TabStop = false;
            this.pictureBoxPlay.Click += new System.EventHandler(this.pictureBoxPlay_Click);
            // 
            // pictureBoxAtras
            // 
            this.pictureBoxAtras.Image = global::Actividad.Properties.Resources.atras;
            this.pictureBoxAtras.Location = new System.Drawing.Point(609, 374);
            this.pictureBoxAtras.Name = "pictureBoxAtras";
            this.pictureBoxAtras.Size = new System.Drawing.Size(45, 35);
            this.pictureBoxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAtras.TabIndex = 12;
            this.pictureBoxAtras.TabStop = false;
            this.pictureBoxAtras.Click += new System.EventHandler(this.pictureBoxAtras_Click);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = global::Actividad.Properties.Resources.home;
            this.pictureBoxHome.Location = new System.Drawing.Point(660, 375);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(48, 35);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 11;
            this.pictureBoxHome.TabStop = false;
            this.pictureBoxHome.Click += new System.EventHandler(this.pictureBoxHome_Click);
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(720, 421);
            this.Controls.Add(this.pictureBoxStop);
            this.Controls.Add(this.pictureBoxPausa);
            this.Controls.Add(this.pictureBoxPlay);
            this.Controls.Add(this.pictureBoxAtras);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Visualizador";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.PictureBox pictureBoxAtras;
        private System.Windows.Forms.PictureBox pictureBoxPlay;
        private System.Windows.Forms.PictureBox pictureBoxPausa;
        private System.Windows.Forms.PictureBox pictureBoxStop;
    }
}