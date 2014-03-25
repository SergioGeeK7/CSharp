namespace appPractica0
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
            this.rdbcuad = new System.Windows.Forms.RadioButton();
            this.rdbrect = new System.Windows.Forms.RadioButton();
            this.lbltexto = new System.Windows.Forms.Label();
            this.txtlado1 = new System.Windows.Forms.TextBox();
            this.PnlDatos = new System.Windows.Forms.Panel();
            this.txtlado2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.PnlDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbcuad
            // 
            this.rdbcuad.AutoSize = true;
            this.rdbcuad.Checked = true;
            this.rdbcuad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcuad.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbcuad.Location = new System.Drawing.Point(53, 48);
            this.rdbcuad.Name = "rdbcuad";
            this.rdbcuad.Size = new System.Drawing.Size(97, 24);
            this.rdbcuad.TabIndex = 5;
            this.rdbcuad.TabStop = true;
            this.rdbcuad.Text = "Cuadrado";
            this.rdbcuad.UseVisualStyleBackColor = true;
            this.rdbcuad.CheckedChanged += new System.EventHandler(this.rdbcuad_CheckedChanged);
            // 
            // rdbrect
            // 
            this.rdbrect.AutoSize = true;
            this.rdbrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbrect.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbrect.Location = new System.Drawing.Point(196, 48);
            this.rdbrect.Name = "rdbrect";
            this.rdbrect.Size = new System.Drawing.Size(109, 24);
            this.rdbrect.TabIndex = 6;
            this.rdbrect.Text = "Rectangulo";
            this.rdbrect.UseVisualStyleBackColor = true;
            this.rdbrect.CheckedChanged += new System.EventHandler(this.rdbrect_CheckedChanged);
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltexto.Location = new System.Drawing.Point(45, 106);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(105, 20);
            this.lbltexto.TabIndex = 2;
            this.lbltexto.Text = "Valor del lado";
            this.lbltexto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtlado1
            // 
            this.txtlado1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlado1.Location = new System.Drawing.Point(186, 105);
            this.txtlado1.Name = "txtlado1";
            this.txtlado1.Size = new System.Drawing.Size(188, 26);
            this.txtlado1.TabIndex = 0;
            // 
            // PnlDatos
            // 
            this.PnlDatos.Controls.Add(this.txtlado2);
            this.PnlDatos.Controls.Add(this.label1);
            this.PnlDatos.Location = new System.Drawing.Point(49, 149);
            this.PnlDatos.Name = "PnlDatos";
            this.PnlDatos.Size = new System.Drawing.Size(325, 59);
            this.PnlDatos.TabIndex = 7;
            this.PnlDatos.Visible = false;
            // 
            // txtlado2
            // 
            this.txtlado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlado2.Location = new System.Drawing.Point(137, 16);
            this.txtlado2.Name = "txtlado2";
            this.txtlado2.Size = new System.Drawing.Size(188, 26);
            this.txtlado2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(-4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor lado 2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(104, 223);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(249, 33);
            this.btnprocesar.TabIndex = 2;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(49, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Area";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(45, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Perimetro";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtarea
            // 
            this.txtarea.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarea.Location = new System.Drawing.Point(186, 276);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(188, 26);
            this.txtarea.TabIndex = 7;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtperimetro.Location = new System.Drawing.Point(186, 322);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(188, 26);
            this.txtperimetro.TabIndex = 8;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(49, 379);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(150, 32);
            this.btnlimpiar.TabIndex = 3;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(224, 379);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(150, 32);
            this.btnterminar.TabIndex = 4;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(431, 447);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.PnlDatos);
            this.Controls.Add(this.txtlado1);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.rdbrect);
            this.Controls.Add(this.rdbcuad);
            this.Name = "Form1";
            this.Text = "Juanito clavo un clavito";
            this.PnlDatos.ResumeLayout(false);
            this.PnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbcuad;
        private System.Windows.Forms.RadioButton rdbrect;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.TextBox txtlado1;
        private System.Windows.Forms.Panel PnlDatos;
        private System.Windows.Forms.TextBox txtlado2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnterminar;
    }
}

