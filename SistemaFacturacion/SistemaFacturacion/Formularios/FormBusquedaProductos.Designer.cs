namespace SistemaFacturacion.Formularios
{
    partial class FormBusquedaProductos
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.rbtidproducto = new System.Windows.Forms.RadioButton();
            this.rbtdescripcion = new System.Windows.Forms.RadioButton();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.dgvdatagridproductos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatagridproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = global::SistemaFacturacion.Properties.Resources.exit;
            this.btncancelar.Location = new System.Drawing.Point(950, 485);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 66);
            this.btncancelar.TabIndex = 0;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = global::SistemaFacturacion.Properties.Resources.aceptar2;
            this.btnaceptar.Location = new System.Drawing.Point(870, 485);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(79, 66);
            this.btnaceptar.TabIndex = 4;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // rbtidproducto
            // 
            this.rbtidproducto.AutoSize = true;
            this.rbtidproducto.Checked = true;
            this.rbtidproducto.Location = new System.Drawing.Point(12, 12);
            this.rbtidproducto.Name = "rbtidproducto";
            this.rbtidproducto.Size = new System.Drawing.Size(80, 17);
            this.rbtidproducto.TabIndex = 0;
            this.rbtidproducto.TabStop = true;
            this.rbtidproducto.Text = "&Id Producto";
            this.rbtidproducto.UseVisualStyleBackColor = true;
            this.rbtidproducto.CheckedChanged += new System.EventHandler(this.rbtidproducto_CheckedChanged);
            // 
            // rbtdescripcion
            // 
            this.rbtdescripcion.AutoSize = true;
            this.rbtdescripcion.Location = new System.Drawing.Point(98, 12);
            this.rbtdescripcion.Name = "rbtdescripcion";
            this.rbtdescripcion.Size = new System.Drawing.Size(81, 17);
            this.rbtdescripcion.TabIndex = 1;
            this.rbtdescripcion.Text = "&Descripcion";
            this.rbtdescripcion.UseVisualStyleBackColor = true;
            this.rbtdescripcion.CheckedChanged += new System.EventHandler(this.rbtdescripcion_CheckedChanged);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(185, 12);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(281, 20);
            this.txtfiltro.TabIndex = 2;
            this.txtfiltro.TextChanged += new System.EventHandler(this.txtfiltro_TextChanged);
            // 
            // dgvdatagridproductos
            // 
            this.dgvdatagridproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdatagridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatagridproductos.Location = new System.Drawing.Point(12, 53);
            this.dgvdatagridproductos.Name = "dgvdatagridproductos";
            this.dgvdatagridproductos.ReadOnly = true;
            this.dgvdatagridproductos.Size = new System.Drawing.Size(1016, 432);
            this.dgvdatagridproductos.TabIndex = 3;
            // 
            // FormBusquedaProductos
            // 
            this.AcceptButton = this.btnaceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btncancelar;
            this.ClientSize = new System.Drawing.Size(1030, 560);
            this.Controls.Add(this.dgvdatagridproductos);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.rbtdescripcion);
            this.Controls.Add(this.rbtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Name = "FormBusquedaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Busqueda De Productos";
            this.Load += new System.EventHandler(this.FormBusquedaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatagridproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.RadioButton rbtidproducto;
        private System.Windows.Forms.RadioButton rbtdescripcion;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.DataGridView dgvdatagridproductos;
    }
}