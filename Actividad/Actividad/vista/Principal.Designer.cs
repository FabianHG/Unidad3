namespace Actividad.vista
{
    partial class Principal
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonJornada = new System.Windows.Forms.Button();
            this.buttonCampeonato = new System.Windows.Forms.Button();
            this.buttonEquipos = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 10);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(621, 322);
            this.splitContainer1.SplitterDistance = 55;
            this.splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Actividad.Properties.Resources.soccer_ball;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(183, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liga de Futbol Miguel Hidalgo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.37594F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.62406F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.Controls.Add(this.buttonJornada, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonCampeonato, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEquipos, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(621, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonJornada
            // 
            this.buttonJornada.BackColor = System.Drawing.Color.Orange;
            this.buttonJornada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonJornada.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJornada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonJornada.Location = new System.Drawing.Point(258, 3);
            this.buttonJornada.Name = "buttonJornada";
            this.buttonJornada.Size = new System.Drawing.Size(246, 125);
            this.buttonJornada.TabIndex = 1;
            this.buttonJornada.Text = "Jornada";
            this.buttonJornada.UseVisualStyleBackColor = false;
            this.buttonJornada.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCampeonato
            // 
            this.buttonCampeonato.BackColor = System.Drawing.Color.Gold;
            this.buttonCampeonato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCampeonato.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCampeonato.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCampeonato.Location = new System.Drawing.Point(3, 3);
            this.buttonCampeonato.Name = "buttonCampeonato";
            this.buttonCampeonato.Size = new System.Drawing.Size(249, 125);
            this.buttonCampeonato.TabIndex = 0;
            this.buttonCampeonato.Text = "Campeonato";
            this.buttonCampeonato.UseVisualStyleBackColor = false;
            this.buttonCampeonato.Click += new System.EventHandler(this.buttonCampeonato_Click);
            this.buttonCampeonato.MouseLeave += new System.EventHandler(this.buttonCampeonato_MouseLeave);
            // 
            // buttonEquipos
            // 
            this.buttonEquipos.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonEquipos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEquipos.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEquipos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEquipos.Location = new System.Drawing.Point(3, 134);
            this.buttonEquipos.Name = "buttonEquipos";
            this.buttonEquipos.Size = new System.Drawing.Size(249, 126);
            this.buttonEquipos.TabIndex = 2;
            this.buttonEquipos.Text = "Equipos";
            this.buttonEquipos.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(510, 134);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(108, 126);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureExit
            // 
            this.pictureExit.Image = global::Actividad.Properties.Resources.exit__1_;
            this.pictureExit.Location = new System.Drawing.Point(3, 49);
            this.pictureExit.Name = "pictureExit";
            this.pictureExit.Size = new System.Drawing.Size(100, 74);
            this.pictureExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExit.TabIndex = 0;
            this.pictureExit.TabStop = false;
            this.pictureExit.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureExit.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 342);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Principal";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormaJornada";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonCampeonato;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonJornada;
        private System.Windows.Forms.Button buttonEquipos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureExit;
    }
}