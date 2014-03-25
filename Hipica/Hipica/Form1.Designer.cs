namespace Hipica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.caballo1 = new System.Windows.Forms.PictureBox();
            this.caballo2 = new System.Windows.Forms.PictureBox();
            this.caballo4 = new System.Windows.Forms.PictureBox();
            this.caballo3 = new System.Windows.Forms.PictureBox();
            this.caballo5 = new System.Windows.Forms.PictureBox();
            this.txtstart = new System.Windows.Forms.Button();
            this.btnrestart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.caballo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo5)).BeginInit();
            this.SuspendLayout();
            // 
            // caballo1
            // 
            this.caballo1.BackColor = System.Drawing.Color.Transparent;
            this.caballo1.Image = global::Hipica.Properties.Resources.caballos_dibujos_infantiles_p1;
            this.caballo1.Location = new System.Drawing.Point(0, 12);
            this.caballo1.Name = "caballo1";
            this.caballo1.Size = new System.Drawing.Size(180, 112);
            this.caballo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo1.TabIndex = 0;
            this.caballo1.TabStop = false;
            // 
            // caballo2
            // 
            this.caballo2.BackColor = System.Drawing.Color.Gainsboro;
            this.caballo2.Image = global::Hipica.Properties.Resources.caballos_dibujos_infantiles_p1;
            this.caballo2.Location = new System.Drawing.Point(0, 119);
            this.caballo2.Name = "caballo2";
            this.caballo2.Size = new System.Drawing.Size(180, 112);
            this.caballo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo2.TabIndex = 1;
            this.caballo2.TabStop = false;
            // 
            // caballo4
            // 
            this.caballo4.BackColor = System.Drawing.Color.Transparent;
            this.caballo4.Image = global::Hipica.Properties.Resources.caballos_dibujos_infantiles_p1;
            this.caballo4.Location = new System.Drawing.Point(0, 335);
            this.caballo4.Name = "caballo4";
            this.caballo4.Size = new System.Drawing.Size(180, 112);
            this.caballo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo4.TabIndex = 3;
            this.caballo4.TabStop = false;
            // 
            // caballo3
            // 
            this.caballo3.BackColor = System.Drawing.Color.Transparent;
            this.caballo3.Image = global::Hipica.Properties.Resources.caballos_dibujos_infantiles_p;
            this.caballo3.Location = new System.Drawing.Point(0, 226);
            this.caballo3.Name = "caballo3";
            this.caballo3.Size = new System.Drawing.Size(180, 112);
            this.caballo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo3.TabIndex = 2;
            this.caballo3.TabStop = false;
            // 
            // caballo5
            // 
            this.caballo5.BackColor = System.Drawing.Color.Transparent;
            this.caballo5.Image = global::Hipica.Properties.Resources.caballos_dibujos_infantiles_p1;
            this.caballo5.Location = new System.Drawing.Point(0, 441);
            this.caballo5.Name = "caballo5";
            this.caballo5.Size = new System.Drawing.Size(180, 112);
            this.caballo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.caballo5.TabIndex = 4;
            this.caballo5.TabStop = false;
            // 
            // txtstart
            // 
            this.txtstart.Location = new System.Drawing.Point(220, 573);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(236, 30);
            this.txtstart.TabIndex = 5;
            this.txtstart.Text = "Start";
            this.txtstart.UseVisualStyleBackColor = true;
            this.txtstart.Click += new System.EventHandler(this.txtstart_Click);
            // 
            // btnrestart
            // 
            this.btnrestart.Location = new System.Drawing.Point(462, 573);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(217, 30);
            this.btnrestart.TabIndex = 6;
            this.btnrestart.Text = "Restart";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 615);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.txtstart);
            this.Controls.Add(this.caballo5);
            this.Controls.Add(this.caballo4);
            this.Controls.Add(this.caballo3);
            this.Controls.Add(this.caballo2);
            this.Controls.Add(this.caballo1);
            this.Name = "Form1";
            this.Text = "Hipica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.caballo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.caballo5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox caballo1;
        private System.Windows.Forms.PictureBox caballo2;
        private System.Windows.Forms.PictureBox caballo4;
        private System.Windows.Forms.PictureBox caballo3;
        private System.Windows.Forms.PictureBox caballo5;
        private System.Windows.Forms.Button txtstart;
        private System.Windows.Forms.Button btnrestart;
    }
}

