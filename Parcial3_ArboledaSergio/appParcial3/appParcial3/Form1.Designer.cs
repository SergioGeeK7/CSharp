namespace appParcial3
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
            this.txtnombre2 = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.Label();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.txtkilometrosporhora = new System.Windows.Forms.Label();
            this.txtkilometrosporhora2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrecorrerhoras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombremotor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtnombre2
            // 
            this.txtnombre2.Location = new System.Drawing.Point(137, 15);
            this.txtnombre2.Name = "txtnombre2";
            this.txtnombre2.Size = new System.Drawing.Size(100, 20);
            this.txtnombre2.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.AutoSize = true;
            this.txtnombre.Location = new System.Drawing.Point(31, 18);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(88, 13);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Text = "Nombre Vehiculo";
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(34, 127);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnsiguiente.TabIndex = 2;
            this.btnsiguiente.Text = "Siguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(137, 127);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(75, 23);
            this.btnterminar.TabIndex = 5;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            // 
            // txtkilometrosporhora
            // 
            this.txtkilometrosporhora.AutoSize = true;
            this.txtkilometrosporhora.Location = new System.Drawing.Point(31, 44);
            this.txtkilometrosporhora.Name = "txtkilometrosporhora";
            this.txtkilometrosporhora.Size = new System.Drawing.Size(100, 13);
            this.txtkilometrosporhora.TabIndex = 7;
            this.txtkilometrosporhora.Text = "Kilometros Por Hora";
            // 
            // txtkilometrosporhora2
            // 
            this.txtkilometrosporhora2.Location = new System.Drawing.Point(137, 41);
            this.txtkilometrosporhora2.Name = "txtkilometrosporhora2";
            this.txtkilometrosporhora2.Size = new System.Drawing.Size(100, 20);
            this.txtkilometrosporhora2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Correr (en horas)";
            // 
            // txtrecorrerhoras
            // 
            this.txtrecorrerhoras.Location = new System.Drawing.Point(137, 92);
            this.txtrecorrerhoras.Name = "txtrecorrerhoras";
            this.txtrecorrerhoras.Size = new System.Drawing.Size(100, 20);
            this.txtrecorrerhoras.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre del motor";
            // 
            // txtnombremotor
            // 
            this.txtnombremotor.Location = new System.Drawing.Point(137, 67);
            this.txtnombremotor.Name = "txtnombremotor";
            this.txtnombremotor.Size = new System.Drawing.Size(100, 20);
            this.txtnombremotor.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 181);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombremotor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtrecorrerhoras);
            this.Controls.Add(this.txtkilometrosporhora);
            this.Controls.Add(this.txtkilometrosporhora2);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtnombre2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre2;
        private System.Windows.Forms.Label txtnombre;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.Label txtkilometrosporhora;
        private System.Windows.Forms.TextBox txtkilometrosporhora2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrecorrerhoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombremotor;
    }
}

