namespace SistemaFacturacion.Formularios
{
    partial class FormArticulos
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbprimero = new System.Windows.Forms.ToolStripButton();
            this.tsbanterior = new System.Windows.Forms.ToolStripButton();
            this.tsbsiguiente = new System.Windows.Forms.ToolStripButton();
            this.tsbultimo = new System.Windows.Forms.ToolStripButton();
            this.tsbnuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbmodificar = new System.Windows.Forms.ToolStripButton();
            this.tsbguardar = new System.Windows.Forms.ToolStripButton();
            this.tsbeliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbbuscar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbiva = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.txtdepartamento = new System.Windows.Forms.Label();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgbproductos = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbprimero,
            this.tsbanterior,
            this.tsbsiguiente,
            this.tsbultimo,
            this.toolStripSeparator1,
            this.tsbnuevo,
            this.tsbmodificar,
            this.tsbguardar,
            this.tsbeliminar,
            this.tsbbuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(698, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbprimero
            // 
            this.tsbprimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbprimero.Image = global::SistemaFacturacion.Properties.Resources.go_first;
            this.tsbprimero.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbprimero.Name = "tsbprimero";
            this.tsbprimero.Size = new System.Drawing.Size(23, 22);
            this.tsbprimero.Text = "toolStripButton1";
            this.tsbprimero.ToolTipText = "Va al primer registro";
            // 
            // tsbanterior
            // 
            this.tsbanterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbanterior.Image = global::SistemaFacturacion.Properties.Resources.ss_back;
            this.tsbanterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbanterior.Name = "tsbanterior";
            this.tsbanterior.Size = new System.Drawing.Size(23, 22);
            this.tsbanterior.Text = "toolStripButton2";
            this.tsbanterior.ToolTipText = "Va al anterior registro";
            // 
            // tsbsiguiente
            // 
            this.tsbsiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbsiguiente.Image = global::SistemaFacturacion.Properties.Resources.ss_forward;
            this.tsbsiguiente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbsiguiente.Name = "tsbsiguiente";
            this.tsbsiguiente.Size = new System.Drawing.Size(23, 22);
            this.tsbsiguiente.Text = "toolStripButton3";
            this.tsbsiguiente.ToolTipText = "Va al siguiente registro";
            // 
            // tsbultimo
            // 
            this.tsbultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbultimo.Image = global::SistemaFacturacion.Properties.Resources.go_last;
            this.tsbultimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbultimo.Name = "tsbultimo";
            this.tsbultimo.Size = new System.Drawing.Size(23, 22);
            this.tsbultimo.Text = "toolStripButton4";
            this.tsbultimo.ToolTipText = "Va al ultimo registro";
            // 
            // tsbnuevo
            // 
            this.tsbnuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbnuevo.Image = global::SistemaFacturacion.Properties.Resources.archivo;
            this.tsbnuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnuevo.Name = "tsbnuevo";
            this.tsbnuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbnuevo.Text = "toolStripButton5";
            this.tsbnuevo.ToolTipText = "Crea un nuevo registro";
            // 
            // tsbmodificar
            // 
            this.tsbmodificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbmodificar.Image = global::SistemaFacturacion.Properties.Resources.edit_32;
            this.tsbmodificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbmodificar.Name = "tsbmodificar";
            this.tsbmodificar.Size = new System.Drawing.Size(23, 22);
            this.tsbmodificar.Text = "toolStripButton6";
            this.tsbmodificar.ToolTipText = "Edita el registro actual";
            // 
            // tsbguardar
            // 
            this.tsbguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbguardar.Enabled = false;
            this.tsbguardar.Image = global::SistemaFacturacion.Properties.Resources.document_save;
            this.tsbguardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbguardar.Name = "tsbguardar";
            this.tsbguardar.Size = new System.Drawing.Size(23, 22);
            this.tsbguardar.Text = "toolStripButton7";
            this.tsbguardar.ToolTipText = "Guarda los cambios";
            // 
            // tsbeliminar
            // 
            this.tsbeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbeliminar.Image = global::SistemaFacturacion.Properties.Resources.edit_delete;
            this.tsbeliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbeliminar.Name = "tsbeliminar";
            this.tsbeliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbeliminar.Text = "toolStripButton8";
            this.tsbeliminar.ToolTipText = "Elimina el registro";
            // 
            // tsbbuscar
            // 
            this.tsbbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbbuscar.Image = global::SistemaFacturacion.Properties.Resources.system_search;
            this.tsbbuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbbuscar.Name = "tsbbuscar";
            this.tsbbuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbbuscar.Text = "toolStripButton9";
            this.tsbbuscar.ToolTipText = "Busca un registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Producto :";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Enabled = false;
            this.txtidproducto.Location = new System.Drawing.Point(88, 22);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(100, 20);
            this.txtidproducto.TabIndex = 2;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Location = new System.Drawing.Point(88, 48);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(603, 20);
            this.txtdescripcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion: ";
            // 
            // txtStock
            // 
            this.txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(268, 74);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(423, 20);
            this.txtStock.TabIndex = 6;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Stock :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(88, 74);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(136, 20);
            this.txtPrecio.TabIndex = 8;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio :";
            // 
            // cmbiva
            // 
            this.cmbiva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbiva.Enabled = false;
            this.cmbiva.FormattingEnabled = true;
            this.cmbiva.Location = new System.Drawing.Point(268, 100);
            this.cmbiva.Name = "cmbiva";
            this.cmbiva.Size = new System.Drawing.Size(423, 21);
            this.cmbiva.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "IVA";
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.Enabled = false;
            this.cmbdepartamento.FormattingEnabled = true;
            this.cmbdepartamento.Location = new System.Drawing.Point(88, 100);
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(136, 21);
            this.cmbdepartamento.TabIndex = 10;
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.AutoSize = true;
            this.txtdepartamento.Location = new System.Drawing.Point(5, 103);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(74, 13);
            this.txtdepartamento.TabIndex = 9;
            this.txtdepartamento.Text = "Departamento";
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Enabled = false;
            this.txtNotas.Location = new System.Drawing.Point(88, 137);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(603, 114);
            this.txtNotas.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Notas :";
            // 
            // dgbproductos
            // 
            this.dgbproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbproductos.Location = new System.Drawing.Point(15, 257);
            this.dgbproductos.Name = "dgbproductos";
            this.dgbproductos.Size = new System.Drawing.Size(676, 291);
            this.dgbproductos.TabIndex = 15;
            // 
            // FormArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 552);
            this.Controls.Add(this.dgbproductos);
            this.Controls.Add(this.txtNotas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbiva);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbdepartamento);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.FormArticulos_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgbproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbprimero;
        private System.Windows.Forms.ToolStripButton tsbanterior;
        private System.Windows.Forms.ToolStripButton tsbsiguiente;
        private System.Windows.Forms.ToolStripButton tsbultimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbnuevo;
        private System.Windows.Forms.ToolStripButton tsbmodificar;
        private System.Windows.Forms.ToolStripButton tsbguardar;
        private System.Windows.Forms.ToolStripButton tsbeliminar;
        private System.Windows.Forms.ToolStripButton tsbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.Label txtdepartamento;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgbproductos;
    }
}