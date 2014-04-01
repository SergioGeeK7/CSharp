namespace SistemaFacturacion.Formularios
{
    partial class FormBusquedaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBusquedaClientes));
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.dgvdatagridproductos = new System.Windows.Forms.DataGridView();
            this.iDClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturacionDataSet = new SistemaFacturacion.FacturacionDataSet();
            this.clienteTableAdapter = new SistemaFacturacion.FacturacionDataSetTableAdapters.ClienteTableAdapter();
            this.fillByIDClienteToolStrip = new System.Windows.Forms.ToolStrip();
            this.iDClienteToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.iDClienteToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByIDClienteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByNombresToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombresToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombresToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByNombresToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByApellidosToolStrip = new System.Windows.Forms.ToolStrip();
            this.apellidosToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.apellidosToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByApellidosToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatagridproductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            this.fillByIDClienteToolStrip.SuspendLayout();
            this.fillByNombresToolStrip.SuspendLayout();
            this.fillByApellidosToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Image = global::SistemaFacturacion.Properties.Resources.exit;
            this.btncancelar.Location = new System.Drawing.Point(787, 556);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(77, 66);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnaceptar.Image = global::SistemaFacturacion.Properties.Resources.aceptar2;
            this.btnaceptar.Location = new System.Drawing.Point(702, 556);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(79, 66);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // dgvdatagridproductos
            // 
            this.dgvdatagridproductos.AllowUserToAddRows = false;
            this.dgvdatagridproductos.AllowUserToDeleteRows = false;
            this.dgvdatagridproductos.AllowUserToOrderColumns = true;
            this.dgvdatagridproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvdatagridproductos.AutoGenerateColumns = false;
            this.dgvdatagridproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdatagridproductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDClienteDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.fechaNacimientoDataGridViewTextBoxColumn,
            this.cupoDataGridViewTextBoxColumn});
            this.dgvdatagridproductos.DataSource = this.clienteBindingSource;
            this.dgvdatagridproductos.Location = new System.Drawing.Point(3, 78);
            this.dgvdatagridproductos.Name = "dgvdatagridproductos";
            this.dgvdatagridproductos.ReadOnly = true;
            this.dgvdatagridproductos.Size = new System.Drawing.Size(851, 472);
            this.dgvdatagridproductos.TabIndex = 7;
            // 
            // iDClienteDataGridViewTextBoxColumn
            // 
            this.iDClienteDataGridViewTextBoxColumn.DataPropertyName = "IDCliente";
            this.iDClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.iDClienteDataGridViewTextBoxColumn.Name = "iDClienteDataGridViewTextBoxColumn";
            this.iDClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaNacimientoDataGridViewTextBoxColumn
            // 
            this.fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName = "FechaNacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.HeaderText = "Fecha Nacimiento";
            this.fechaNacimientoDataGridViewTextBoxColumn.Name = "fechaNacimientoDataGridViewTextBoxColumn";
            this.fechaNacimientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cupoDataGridViewTextBoxColumn
            // 
            this.cupoDataGridViewTextBoxColumn.DataPropertyName = "Cupo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.cupoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.cupoDataGridViewTextBoxColumn.HeaderText = "Cupo";
            this.cupoDataGridViewTextBoxColumn.Name = "cupoDataGridViewTextBoxColumn";
            this.cupoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.facturacionDataSetBindingSource;
            // 
            // facturacionDataSetBindingSource
            // 
            this.facturacionDataSetBindingSource.DataSource = this.facturacionDataSet;
            this.facturacionDataSetBindingSource.Position = 0;
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // fillByIDClienteToolStrip
            // 
            this.fillByIDClienteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDClienteToolStripLabel,
            this.iDClienteToolStripTextBox,
            this.fillByIDClienteToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.fillByIDClienteToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByIDClienteToolStrip.Name = "fillByIDClienteToolStrip";
            this.fillByIDClienteToolStrip.Size = new System.Drawing.Size(866, 25);
            this.fillByIDClienteToolStrip.TabIndex = 8;
            this.fillByIDClienteToolStrip.Text = "fillByIDClienteToolStrip";
            // 
            // iDClienteToolStripLabel
            // 
            this.iDClienteToolStripLabel.Name = "iDClienteToolStripLabel";
            this.iDClienteToolStripLabel.Size = new System.Drawing.Size(58, 22);
            this.iDClienteToolStripLabel.Text = "IDCliente:";
            // 
            // iDClienteToolStripTextBox
            // 
            this.iDClienteToolStripTextBox.Name = "iDClienteToolStripTextBox";
            this.iDClienteToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByIDClienteToolStripButton
            // 
            this.fillByIDClienteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByIDClienteToolStripButton.Name = "fillByIDClienteToolStripButton";
            this.fillByIDClienteToolStripButton.Size = new System.Drawing.Size(100, 22);
            this.fillByIDClienteToolStripButton.Text = "Filtrar por cliente";
            this.fillByIDClienteToolStripButton.Click += new System.EventHandler(this.fillByIDClienteToolStripButton_Click);
            // 
            // fillByNombresToolStrip
            // 
            this.fillByNombresToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombresToolStripLabel,
            this.nombresToolStripTextBox,
            this.fillByNombresToolStripButton});
            this.fillByNombresToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByNombresToolStrip.Name = "fillByNombresToolStrip";
            this.fillByNombresToolStrip.Size = new System.Drawing.Size(866, 25);
            this.fillByNombresToolStrip.TabIndex = 9;
            this.fillByNombresToolStrip.Text = "fillByNombresToolStrip";
            // 
            // nombresToolStripLabel
            // 
            this.nombresToolStripLabel.Name = "nombresToolStripLabel";
            this.nombresToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.nombresToolStripLabel.Text = "Nombres:";
            // 
            // nombresToolStripTextBox
            // 
            this.nombresToolStripTextBox.Name = "nombresToolStripTextBox";
            this.nombresToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByNombresToolStripButton
            // 
            this.fillByNombresToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByNombresToolStripButton.Name = "fillByNombresToolStripButton";
            this.fillByNombresToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillByNombresToolStripButton.Text = "Filtrar por Nombres";
            this.fillByNombresToolStripButton.Click += new System.EventHandler(this.fillByNombresToolStripButton_Click);
            // 
            // fillByApellidosToolStrip
            // 
            this.fillByApellidosToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apellidosToolStripLabel,
            this.apellidosToolStripTextBox,
            this.fillByApellidosToolStripButton});
            this.fillByApellidosToolStrip.Location = new System.Drawing.Point(0, 50);
            this.fillByApellidosToolStrip.Name = "fillByApellidosToolStrip";
            this.fillByApellidosToolStrip.Size = new System.Drawing.Size(866, 25);
            this.fillByApellidosToolStrip.TabIndex = 10;
            this.fillByApellidosToolStrip.Text = "fillByApellidosToolStrip";
            // 
            // apellidosToolStripLabel
            // 
            this.apellidosToolStripLabel.Name = "apellidosToolStripLabel";
            this.apellidosToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.apellidosToolStripLabel.Text = "Apellidos:";
            // 
            // apellidosToolStripTextBox
            // 
            this.apellidosToolStripTextBox.Name = "apellidosToolStripTextBox";
            this.apellidosToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByApellidosToolStripButton
            // 
            this.fillByApellidosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByApellidosToolStripButton.Name = "fillByApellidosToolStripButton";
            this.fillByApellidosToolStripButton.Size = new System.Drawing.Size(114, 22);
            this.fillByApellidosToolStripButton.Text = "Filtrar por Apellidos";
            this.fillByApellidosToolStripButton.Click += new System.EventHandler(this.fillByApellidosToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(76, 22);
            this.toolStripButton1.Text = "QuitarFiltros";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FormBusquedaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 634);
            this.Controls.Add(this.fillByApellidosToolStrip);
            this.Controls.Add(this.fillByNombresToolStrip);
            this.Controls.Add(this.fillByIDClienteToolStrip);
            this.Controls.Add(this.dgvdatagridproductos);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnaceptar);
            this.Name = "FormBusquedaClientes";
            this.Text = "Busqueda Cliente";
            this.Load += new System.EventHandler(this.FormBusquedaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdatagridproductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            this.fillByIDClienteToolStrip.ResumeLayout(false);
            this.fillByIDClienteToolStrip.PerformLayout();
            this.fillByNombresToolStrip.ResumeLayout(false);
            this.fillByNombresToolStrip.PerformLayout();
            this.fillByApellidosToolStrip.ResumeLayout(false);
            this.fillByApellidosToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridView dgvdatagridproductos;
        private System.Windows.Forms.BindingSource facturacionDataSetBindingSource;
        private FacturacionDataSet facturacionDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private FacturacionDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByIDClienteToolStrip;
        private System.Windows.Forms.ToolStripLabel iDClienteToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox iDClienteToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByIDClienteToolStripButton;
        private System.Windows.Forms.ToolStrip fillByNombresToolStrip;
        private System.Windows.Forms.ToolStripLabel nombresToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombresToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByNombresToolStripButton;
        private System.Windows.Forms.ToolStrip fillByApellidosToolStrip;
        private System.Windows.Forms.ToolStripLabel apellidosToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox apellidosToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByApellidosToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}