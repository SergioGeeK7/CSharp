namespace appPractica3
{
    partial class frmHerencia
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
            this.tadDatos = new System.Windows.Forms.TabControl();
            this.tabCirculo = new System.Windows.Forms.TabPage();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcularcircu = new System.Windows.Forms.Button();
            this.tabTriangulo = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcularTriang = new System.Windows.Forms.Button();
            this.tabCuadrado = new System.Windows.Forms.TabPage();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.Lado = new System.Windows.Forms.Label();
            this.btnCalcularCuad = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tadDatos.SuspendLayout();
            this.tabCirculo.SuspendLayout();
            this.tabTriangulo.SuspendLayout();
            this.tabCuadrado.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tadDatos
            // 
            this.tadDatos.Controls.Add(this.tabCirculo);
            this.tadDatos.Controls.Add(this.tabTriangulo);
            this.tadDatos.Controls.Add(this.tabCuadrado);
            this.tadDatos.Location = new System.Drawing.Point(12, 59);
            this.tadDatos.Name = "tadDatos";
            this.tadDatos.SelectedIndex = 0;
            this.tadDatos.Size = new System.Drawing.Size(389, 180);
            this.tadDatos.TabIndex = 0;
            // 
            // tabCirculo
            // 
            this.tabCirculo.BackColor = System.Drawing.Color.Silver;
            this.tabCirculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCirculo.Controls.Add(this.txtradio);
            this.tabCirculo.Controls.Add(this.label2);
            this.tabCirculo.Controls.Add(this.btnCalcularcircu);
            this.tabCirculo.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCirculo.Location = new System.Drawing.Point(4, 22);
            this.tabCirculo.Name = "tabCirculo";
            this.tabCirculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCirculo.Size = new System.Drawing.Size(381, 154);
            this.tabCirculo.TabIndex = 0;
            this.tabCirculo.Text = "Circulo";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(126, 46);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(153, 23);
            this.txtradio.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Radio :";
            // 
            // btnCalcularcircu
            // 
            this.btnCalcularcircu.BackColor = System.Drawing.Color.Silver;
            this.btnCalcularcircu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularcircu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularcircu.Location = new System.Drawing.Point(106, 112);
            this.btnCalcularcircu.Name = "btnCalcularcircu";
            this.btnCalcularcircu.Size = new System.Drawing.Size(165, 23);
            this.btnCalcularcircu.TabIndex = 3;
            this.btnCalcularcircu.Text = "Calcular";
            this.btnCalcularcircu.UseVisualStyleBackColor = false;
            this.btnCalcularcircu.Click += new System.EventHandler(this.btnCalcularcircu_Click);
            // 
            // tabTriangulo
            // 
            this.tabTriangulo.BackColor = System.Drawing.Color.Silver;
            this.tabTriangulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTriangulo.Controls.Add(this.label5);
            this.tabTriangulo.Controls.Add(this.label4);
            this.tabTriangulo.Controls.Add(this.txtLadoB);
            this.tabTriangulo.Controls.Add(this.txtLadoC);
            this.tabTriangulo.Controls.Add(this.txtLadoA);
            this.tabTriangulo.Controls.Add(this.label3);
            this.tabTriangulo.Controls.Add(this.btnCalcularTriang);
            this.tabTriangulo.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTriangulo.Location = new System.Drawing.Point(4, 22);
            this.tabTriangulo.Name = "tabTriangulo";
            this.tabTriangulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTriangulo.Size = new System.Drawing.Size(381, 154);
            this.tabTriangulo.TabIndex = 1;
            this.tabTriangulo.Text = "Triangulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lado C:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lado B:";
            // 
            // txtLadoB
            // 
            this.txtLadoB.Location = new System.Drawing.Point(145, 46);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(105, 23);
            this.txtLadoB.TabIndex = 7;
            // 
            // txtLadoC
            // 
            this.txtLadoC.Location = new System.Drawing.Point(145, 75);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(105, 23);
            this.txtLadoC.TabIndex = 6;
            // 
            // txtLadoA
            // 
            this.txtLadoA.Location = new System.Drawing.Point(145, 17);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(105, 23);
            this.txtLadoA.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lado A:";
            // 
            // btnCalcularTriang
            // 
            this.btnCalcularTriang.BackColor = System.Drawing.Color.Silver;
            this.btnCalcularTriang.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularTriang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularTriang.Location = new System.Drawing.Point(99, 113);
            this.btnCalcularTriang.Name = "btnCalcularTriang";
            this.btnCalcularTriang.Size = new System.Drawing.Size(165, 23);
            this.btnCalcularTriang.TabIndex = 3;
            this.btnCalcularTriang.Text = "Calcular";
            this.btnCalcularTriang.UseVisualStyleBackColor = false;
            this.btnCalcularTriang.Click += new System.EventHandler(this.btnCalcularTriang_Click);
            // 
            // tabCuadrado
            // 
            this.tabCuadrado.BackColor = System.Drawing.Color.Silver;
            this.tabCuadrado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCuadrado.Controls.Add(this.txtLado);
            this.tabCuadrado.Controls.Add(this.Lado);
            this.tabCuadrado.Controls.Add(this.btnCalcularCuad);
            this.tabCuadrado.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCuadrado.Location = new System.Drawing.Point(4, 22);
            this.tabCuadrado.Name = "tabCuadrado";
            this.tabCuadrado.Size = new System.Drawing.Size(381, 154);
            this.tabCuadrado.TabIndex = 2;
            this.tabCuadrado.Text = "Cuadrado";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(122, 51);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(153, 23);
            this.txtLado.TabIndex = 2;
            // 
            // Lado
            // 
            this.Lado.AutoSize = true;
            this.Lado.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lado.Location = new System.Drawing.Point(59, 55);
            this.Lado.Name = "Lado";
            this.Lado.Size = new System.Drawing.Size(52, 19);
            this.Lado.TabIndex = 1;
            this.Lado.Text = "Lado :";
            // 
            // btnCalcularCuad
            // 
            this.btnCalcularCuad.BackColor = System.Drawing.Color.Silver;
            this.btnCalcularCuad.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcularCuad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularCuad.Location = new System.Drawing.Point(97, 111);
            this.btnCalcularCuad.Name = "btnCalcularCuad";
            this.btnCalcularCuad.Size = new System.Drawing.Size(165, 23);
            this.btnCalcularCuad.TabIndex = 0;
            this.btnCalcularCuad.Text = "Calcular";
            this.btnCalcularCuad.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitulo.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(101, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(217, 23);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Herencia y Polimorfismo";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(25, 257);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 35);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTerminar.Font = new System.Drawing.Font("Imprint MT Shadow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.Location = new System.Drawing.Point(237, 257);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(146, 35);
            this.btnTerminar.TabIndex = 3;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPerimetro);
            this.panel1.Controls.Add(this.txtArea);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(25, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 88);
            this.panel1.TabIndex = 4;
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(141, 54);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.ReadOnly = true;
            this.txtPerimetro.Size = new System.Drawing.Size(130, 20);
            this.txtPerimetro.TabIndex = 6;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(141, 17);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(130, 20);
            this.txtArea.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Perimetro :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Area :";
            // 
            // frmHerencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tadDatos);
            this.Name = "frmHerencia";
            this.Text = "Herencia";
            this.tadDatos.ResumeLayout(false);
            this.tabCirculo.ResumeLayout(false);
            this.tabCirculo.PerformLayout();
            this.tabTriangulo.ResumeLayout(false);
            this.tabTriangulo.PerformLayout();
            this.tabCuadrado.ResumeLayout(false);
            this.tabCuadrado.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tadDatos;
        private System.Windows.Forms.TabPage tabCirculo;
        private System.Windows.Forms.TabPage tabTriangulo;
        private System.Windows.Forms.TabPage tabCuadrado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCalcularCuad;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcularcircu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.TextBox txtLadoC;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcularTriang;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label Lado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

