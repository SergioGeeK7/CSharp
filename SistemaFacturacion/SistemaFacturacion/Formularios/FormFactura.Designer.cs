namespace SistemaFacturacion.Formularios
{
    partial class FormFactura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcliente = new System.Windows.Forms.ComboBox();
            this.clienteNombresFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new SistemaFacturacion.FacturacionDataSet();
            this.clienteNombresFullTableAdapter = new SistemaFacturacion.FacturacionDataSetTableAdapters.ClienteNombresFullTableAdapter();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.productoTableAdapter = new SistemaFacturacion.FacturacionDataSetTableAdapters.ProductoTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneliminartodo = new System.Windows.Forms.Button();
            this.dataGridViewDetalle = new System.Windows.Forms.DataGridView();
            this.detalleFacturaTmpConValorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleFacturaTmpConValorTableAdapter = new SistemaFacturacion.FacturacionDataSetTableAdapters.DetalleFacturaTmpConValorTableAdapter();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txttotalvalor = new System.Windows.Forms.TextBox();
            this.txttotalcantidad = new System.Windows.Forms.TextBox();
            this.IDLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.clienteNombresFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaTmpConValorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(68, 17);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // cmbcliente
            // 
            this.cmbcliente.DataSource = this.clienteNombresFullBindingSource;
            this.cmbcliente.DisplayMember = "NombreFull";
            this.cmbcliente.FormattingEnabled = true;
            this.cmbcliente.Location = new System.Drawing.Point(68, 43);
            this.cmbcliente.Name = "cmbcliente";
            this.cmbcliente.Size = new System.Drawing.Size(198, 21);
            this.cmbcliente.TabIndex = 3;
            this.cmbcliente.ValueMember = "IDCliente";
            // 
            // clienteNombresFullBindingSource
            // 
            this.clienteNombresFullBindingSource.DataMember = "ClienteNombresFull";
            this.clienteNombresFullBindingSource.DataSource = this.facturacionDataSet;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteNombresFullTableAdapter
            // 
            this.clienteNombresFullTableAdapter.ClearBeforeFill = true;
            // 
            // cmbproducto
            // 
            this.cmbproducto.DataSource = this.productoBindingSource;
            this.cmbproducto.DisplayMember = "Descripcion";
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(68, 70);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(198, 21);
            this.cmbproducto.TabIndex = 5;
            this.cmbproducto.ValueMember = "IDProducto";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "Producto";
            this.productoBindingSource.DataSource = this.facturacionDataSet;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Producto";
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Cantidad";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(66, 97);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(200, 20);
            this.txtcantidad.TabIndex = 7;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(272, 97);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 8;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(353, 97);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 9;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btneliminartodo
            // 
            this.btneliminartodo.Location = new System.Drawing.Point(434, 97);
            this.btneliminartodo.Name = "btneliminartodo";
            this.btneliminartodo.Size = new System.Drawing.Size(121, 23);
            this.btneliminartodo.TabIndex = 10;
            this.btneliminartodo.Text = "Eliminar Todo";
            this.btneliminartodo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDetalle
            // 
            this.dataGridViewDetalle.AllowUserToAddRows = false;
            this.dataGridViewDetalle.AllowUserToOrderColumns = true;
            this.dataGridViewDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDetalle.AutoGenerateColumns = false;
            this.dataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLinea,
            this.iDProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.dataGridViewDetalle.DataSource = this.detalleFacturaTmpConValorBindingSource;
            this.dataGridViewDetalle.Location = new System.Drawing.Point(14, 123);
            this.dataGridViewDetalle.Name = "dataGridViewDetalle";
            this.dataGridViewDetalle.ReadOnly = true;
            this.dataGridViewDetalle.Size = new System.Drawing.Size(637, 283);
            this.dataGridViewDetalle.TabIndex = 11;
            // 
            // detalleFacturaTmpConValorBindingSource
            // 
            this.detalleFacturaTmpConValorBindingSource.DataMember = "DetalleFacturaTmpConValor";
            this.detalleFacturaTmpConValorBindingSource.DataSource = this.facturacionDataSet;
            // 
            // detalleFacturaTmpConValorTableAdapter
            // 
            this.detalleFacturaTmpConValorTableAdapter.ClearBeforeFill = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = global::SistemaFacturacion.Properties.Resources.exit;
            this.btncancelar.Location = new System.Drawing.Point(574, 426);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 66);
            this.btncancelar.TabIndex = 12;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = global::SistemaFacturacion.Properties.Resources.aceptar2;
            this.btnaceptar.Location = new System.Drawing.Point(494, 426);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(79, 66);
            this.btnaceptar.TabIndex = 13;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Totales";
            // 
            // txttotalvalor
            // 
            this.txttotalvalor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalvalor.Enabled = false;
            this.txttotalvalor.Location = new System.Drawing.Point(550, 406);
            this.txttotalvalor.Name = "txttotalvalor";
            this.txttotalvalor.Size = new System.Drawing.Size(101, 20);
            this.txttotalvalor.TabIndex = 15;
            this.txttotalvalor.Text = "0";
            this.txttotalvalor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttotalcantidad
            // 
            this.txttotalcantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotalcantidad.Enabled = false;
            this.txttotalcantidad.Location = new System.Drawing.Point(443, 406);
            this.txttotalcantidad.Name = "txttotalcantidad";
            this.txttotalcantidad.Size = new System.Drawing.Size(101, 20);
            this.txttotalcantidad.TabIndex = 16;
            this.txttotalcantidad.Text = "0";
            this.txttotalcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IDLinea
            // 
            this.IDLinea.DataPropertyName = "IDLinea";
            this.IDLinea.HeaderText = "ID Linea";
            this.IDLinea.Name = "IDLinea";
            this.IDLinea.ReadOnly = true;
            // 
            // iDProductoDataGridViewTextBoxColumn
            // 
            this.iDProductoDataGridViewTextBoxColumn.DataPropertyName = "IDProducto";
            this.iDProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.iDProductoDataGridViewTextBoxColumn.Name = "iDProductoDataGridViewTextBoxColumn";
            this.iDProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.precioDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 493);
            this.Controls.Add(this.txttotalcantidad);
            this.Controls.Add(this.txttotalvalor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dataGridViewDetalle);
            this.Controls.Add(this.btneliminartodo);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbproducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbcliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.label1);
            this.Name = "FormFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteNombresFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaTmpConValorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbcliente;
        private FacturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource clienteNombresFullBindingSource;
        private FacturacionDataSetTableAdapters.ClienteNombresFullTableAdapter clienteNombresFullTableAdapter;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private FacturacionDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneliminartodo;
        private System.Windows.Forms.DataGridView dataGridViewDetalle;
        private System.Windows.Forms.BindingSource detalleFacturaTmpConValorBindingSource;
        private FacturacionDataSetTableAdapters.DetalleFacturaTmpConValorTableAdapter detalleFacturaTmpConValorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLineaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttotalvalor;
        private System.Windows.Forms.TextBox txttotalcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLinea;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}