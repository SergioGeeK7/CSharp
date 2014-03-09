namespace ejercicio2
{
    partial class ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejercicio2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtAñosW = new System.Windows.Forms.TextBox();
            this.grvSalida = new System.Windows.Forms.GroupBox();
            this.txtMontoAumen = new System.Windows.Forms.TextBox();
            this.txtPctAumento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.grvSalida.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(65, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "años trabajados";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(153, 35);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 3;
            // 
            // txtAñosW
            // 
            this.txtAñosW.Location = new System.Drawing.Point(153, 70);
            this.txtAñosW.Name = "txtAñosW";
            this.txtAñosW.Size = new System.Drawing.Size(47, 20);
            this.txtAñosW.TabIndex = 4;
            // 
            // grvSalida
            // 
            this.grvSalida.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("grvSalida.BackgroundImage")));
            this.grvSalida.Controls.Add(this.txtMontoAumen);
            this.grvSalida.Controls.Add(this.txtPctAumento);
            this.grvSalida.Controls.Add(this.label4);
            this.grvSalida.Controls.Add(this.label3);
            this.grvSalida.Location = new System.Drawing.Point(53, 144);
            this.grvSalida.Name = "grvSalida";
            this.grvSalida.Size = new System.Drawing.Size(256, 137);
            this.grvSalida.TabIndex = 5;
            this.grvSalida.TabStop = false;
            this.grvSalida.Text = "Datos";
            // 
            // txtMontoAumen
            // 
            this.txtMontoAumen.Location = new System.Drawing.Point(124, 62);
            this.txtMontoAumen.Name = "txtMontoAumen";
            this.txtMontoAumen.Size = new System.Drawing.Size(60, 20);
            this.txtMontoAumen.TabIndex = 3;
            // 
            // txtPctAumento
            // 
            this.txtPctAumento.Location = new System.Drawing.Point(124, 26);
            this.txtPctAumento.Name = "txtPctAumento";
            this.txtPctAumento.Size = new System.Drawing.Size(60, 20);
            this.txtPctAumento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Monto Aumento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Porcentaje Aumento";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(153, 106);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(234, 106);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTerminar.Location = new System.Drawing.Point(234, 287);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(75, 23);
            this.btnTerminar.TabIndex = 8;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = false;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 322);
            this.ControlBox = false;
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grvSalida);
            this.Controls.Add(this.txtAñosW);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ejercicio2_Load);
            this.grvSalida.ResumeLayout(false);
            this.grvSalida.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtAñosW;
        private System.Windows.Forms.GroupBox grvSalida;
        private System.Windows.Forms.TextBox txtMontoAumen;
        private System.Windows.Forms.TextBox txtPctAumento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnTerminar;
    }
}

