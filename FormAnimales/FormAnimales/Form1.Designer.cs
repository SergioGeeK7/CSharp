namespace FormAnimales
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtanos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbperro = new System.Windows.Forms.RadioButton();
            this.chbaguila = new System.Windows.Forms.RadioButton();
            this.chbpaloma = new System.Windows.Forms.RadioButton();
            this.chbgato = new System.Windows.Forms.RadioButton();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animales";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(116, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(302, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // txtanos
            // 
            this.txtanos.Location = new System.Drawing.Point(116, 126);
            this.txtanos.Name = "txtanos";
            this.txtanos.Size = new System.Drawing.Size(302, 20);
            this.txtanos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Años";
            // 
            // chbperro
            // 
            this.chbperro.AutoSize = true;
            this.chbperro.Checked = true;
            this.chbperro.Location = new System.Drawing.Point(28, 58);
            this.chbperro.Name = "chbperro";
            this.chbperro.Size = new System.Drawing.Size(50, 17);
            this.chbperro.TabIndex = 9;
            this.chbperro.TabStop = true;
            this.chbperro.Text = "Perro";
            this.chbperro.UseVisualStyleBackColor = true;
            // 
            // chbaguila
            // 
            this.chbaguila.AutoSize = true;
            this.chbaguila.Location = new System.Drawing.Point(364, 58);
            this.chbaguila.Name = "chbaguila";
            this.chbaguila.Size = new System.Drawing.Size(54, 17);
            this.chbaguila.TabIndex = 10;
            this.chbaguila.Text = "Aguila";
            this.chbaguila.UseVisualStyleBackColor = true;
            // 
            // chbpaloma
            // 
            this.chbpaloma.AutoSize = true;
            this.chbpaloma.Location = new System.Drawing.Point(248, 58);
            this.chbpaloma.Name = "chbpaloma";
            this.chbpaloma.Size = new System.Drawing.Size(60, 17);
            this.chbpaloma.TabIndex = 11;
            this.chbpaloma.Text = "Paloma";
            this.chbpaloma.UseVisualStyleBackColor = true;
            // 
            // chbgato
            // 
            this.chbgato.AutoSize = true;
            this.chbgato.Location = new System.Drawing.Point(137, 58);
            this.chbgato.Name = "chbgato";
            this.chbgato.Size = new System.Drawing.Size(48, 17);
            this.chbgato.TabIndex = 12;
            this.chbgato.Text = "Gato";
            this.chbgato.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(153, 152);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnsiguiente.TabIndex = 13;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(248, 152);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(126, 23);
            this.btnguardar.TabIndex = 14;
            this.btnguardar.Text = "Guardar y Terminar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 213);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.chbgato);
            this.Controls.Add(this.chbpaloma);
            this.Controls.Add(this.chbaguila);
            this.Controls.Add(this.chbperro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtanos);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtanos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton chbperro;
        private System.Windows.Forms.RadioButton chbaguila;
        private System.Windows.Forms.RadioButton chbpaloma;
        private System.Windows.Forms.RadioButton chbgato;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnguardar;
    }
}

