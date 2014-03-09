namespace AppParcial1
{
    partial class AppParcial1
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
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gbdatos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalorventa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txtVenCOnt1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVentC1 = new System.Windows.Forms.TextBox();
            this.gbalmacen1 = new System.Windows.Forms.GroupBox();
            this.gbalmacen2 = new System.Windows.Forms.GroupBox();
            this.txtVenCont2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVenta2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btProcesos = new System.Windows.Forms.Button();
            this.gbdatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbalmacen1.SuspendLayout();
            this.gbalmacen2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(298, 3);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(104, 26);
            this.btnEmpezar.TabIndex = 1;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Terminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(348, 432);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(104, 26);
            this.btnReiniciar.TabIndex = 3;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(91, 46);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(91, 20);
            this.txtCod.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(180, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Almacen1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(450, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(72, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "Almacen2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // gbdatos
            // 
            this.gbdatos.Controls.Add(this.label4);
            this.gbdatos.Controls.Add(this.txtvalorventa);
            this.gbdatos.Controls.Add(this.groupBox2);
            this.gbdatos.Controls.Add(this.txtCod);
            this.gbdatos.Controls.Add(this.label1);
            this.gbdatos.Location = new System.Drawing.Point(238, 67);
            this.gbdatos.Name = "gbdatos";
            this.gbdatos.Size = new System.Drawing.Size(273, 177);
            this.gbdatos.TabIndex = 7;
            this.gbdatos.TabStop = false;
            this.gbdatos.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Valor Venta";
            // 
            // txtvalorventa
            // 
            this.txtvalorventa.Location = new System.Drawing.Point(123, 151);
            this.txtvalorventa.Name = "txtvalorventa";
            this.txtvalorventa.Size = new System.Drawing.Size(91, 20);
            this.txtvalorventa.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Location = new System.Drawing.Point(18, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 56);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TipoVenta";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(138, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.Text = "Credito";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(23, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 17);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Contado";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // txtVenCOnt1
            // 
            this.txtVenCOnt1.Location = new System.Drawing.Point(169, 61);
            this.txtVenCOnt1.Name = "txtVenCOnt1";
            this.txtVenCOnt1.Size = new System.Drawing.Size(91, 20);
            this.txtVenCOnt1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total VentaContado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total VentaC";
            // 
            // txtVentC1
            // 
            this.txtVentC1.Location = new System.Drawing.Point(169, 19);
            this.txtVentC1.Name = "txtVentC1";
            this.txtVentC1.Size = new System.Drawing.Size(91, 20);
            this.txtVentC1.TabIndex = 9;
            // 
            // gbalmacen1
            // 
            this.gbalmacen1.Controls.Add(this.txtVenCOnt1);
            this.gbalmacen1.Controls.Add(this.label6);
            this.gbalmacen1.Controls.Add(this.txtVentC1);
            this.gbalmacen1.Controls.Add(this.label5);
            this.gbalmacen1.Location = new System.Drawing.Point(48, 282);
            this.gbalmacen1.Name = "gbalmacen1";
            this.gbalmacen1.Size = new System.Drawing.Size(296, 102);
            this.gbalmacen1.TabIndex = 13;
            this.gbalmacen1.TabStop = false;
            this.gbalmacen1.Text = "Almacen1";
            this.gbalmacen1.Visible = false;
            // 
            // gbalmacen2
            // 
            this.gbalmacen2.Controls.Add(this.txtVenCont2);
            this.gbalmacen2.Controls.Add(this.label2);
            this.gbalmacen2.Controls.Add(this.txtVenta2);
            this.gbalmacen2.Controls.Add(this.label3);
            this.gbalmacen2.Location = new System.Drawing.Point(409, 292);
            this.gbalmacen2.Name = "gbalmacen2";
            this.gbalmacen2.Size = new System.Drawing.Size(296, 102);
            this.gbalmacen2.TabIndex = 14;
            this.gbalmacen2.TabStop = false;
            this.gbalmacen2.Text = "Almacen2";
            this.gbalmacen2.Visible = false;
            // 
            // txtVenCont2
            // 
            this.txtVenCont2.Location = new System.Drawing.Point(169, 61);
            this.txtVenCont2.Name = "txtVenCont2";
            this.txtVenCont2.Size = new System.Drawing.Size(91, 20);
            this.txtVenCont2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total VentaC";
            // 
            // txtVenta2
            // 
            this.txtVenta2.Location = new System.Drawing.Point(169, 19);
            this.txtVenta2.Name = "txtVenta2";
            this.txtVenta2.Size = new System.Drawing.Size(91, 20);
            this.txtVenta2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total VentaContado";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(192, 432);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(104, 26);
            this.btLimpiar.TabIndex = 15;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Visible = false;
            this.btLimpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btProcesos
            // 
            this.btProcesos.Location = new System.Drawing.Point(316, 250);
            this.btProcesos.Name = "btProcesos";
            this.btProcesos.Size = new System.Drawing.Size(104, 26);
            this.btProcesos.TabIndex = 16;
            this.btProcesos.Text = "Procesos";
            this.btProcesos.UseVisualStyleBackColor = true;
            this.btProcesos.Visible = false;
            this.btProcesos.Click += new System.EventHandler(this.button5_Click);
            // 
            // AppParcial1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(750, 541);
            this.Controls.Add(this.btProcesos);
            this.Controls.Add(this.btLimpiar);
            this.Controls.Add(this.gbalmacen2);
            this.Controls.Add(this.gbalmacen1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.gbdatos);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnEmpezar);
            this.Name = "AppParcial1";
            this.Text = "AppParcial1";
            this.Load += new System.EventHandler(this.AppParcial1_Load);
            this.gbdatos.ResumeLayout(false);
            this.gbdatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbalmacen1.ResumeLayout(false);
            this.gbalmacen1.PerformLayout();
            this.gbalmacen2.ResumeLayout(false);
            this.gbalmacen2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gbdatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txtVenCOnt1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVentC1;
        private System.Windows.Forms.GroupBox gbalmacen1;
        private System.Windows.Forms.GroupBox gbalmacen2;
        private System.Windows.Forms.TextBox txtVenCont2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVenta2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btProcesos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvalorventa;
    }
}

