namespace SistemaFacturacion.Formularios
{
    partial class FormConsultaArticulos
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
            this.dgbproductos = new System.Windows.Forms.DataGridView();
            this.txtdepartamento = new System.Windows.Forms.Label();
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.cmbiva = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbproductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbproductos
            // 
            this.dgbproductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgbproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbproductos.Location = new System.Drawing.Point(-1, 43);
            this.dgbproductos.Name = "dgbproductos";
            this.dgbproductos.Size = new System.Drawing.Size(676, 399);
            this.dgbproductos.TabIndex = 4;
            this.dgbproductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgbproductos_CellContentClick);
            // 
            // txtdepartamento
            // 
            this.txtdepartamento.AutoSize = true;
            this.txtdepartamento.Location = new System.Drawing.Point(12, 19);
            this.txtdepartamento.Name = "txtdepartamento";
            this.txtdepartamento.Size = new System.Drawing.Size(74, 13);
            this.txtdepartamento.TabIndex = 0;
            this.txtdepartamento.Text = "Departamento";
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.FormattingEnabled = true;
            this.cmbdepartamento.Location = new System.Drawing.Point(103, 16);
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(245, 21);
            this.cmbdepartamento.TabIndex = 1;
            this.cmbdepartamento.SelectedIndexChanged += new System.EventHandler(this.cmbdepartamento_SelectedIndexChanged);
            // 
            // cmbiva
            // 
            this.cmbiva.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbiva.FormattingEnabled = true;
            this.cmbiva.Location = new System.Drawing.Point(384, 16);
            this.cmbiva.Name = "cmbiva";
            this.cmbiva.Size = new System.Drawing.Size(279, 21);
            this.cmbiva.TabIndex = 3;
            this.cmbiva.SelectedIndexChanged += new System.EventHandler(this.cmbiva_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IVA";
            // 
            // FormConsultaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 440);
            this.Controls.Add(this.cmbiva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbdepartamento);
            this.Controls.Add(this.txtdepartamento);
            this.Controls.Add(this.dgbproductos);
            this.Name = "FormConsultaArticulos";
            this.Text = "Consulta Articulos";
            this.Load += new System.EventHandler(this.FormConsultaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbproductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbproductos;
        private System.Windows.Forms.Label txtdepartamento;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.ComboBox cmbiva;
        private System.Windows.Forms.Label label1;
    }
}