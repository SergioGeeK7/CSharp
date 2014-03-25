namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.txtbruto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubstle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtneto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsalud = new System.Windows.Forms.TextBox();
            this.txtpension = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtparaf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdedfondoemp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rdbadmon = new System.Windows.Forms.RadioButton();
            this.rbdprod = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txtfondoemp = new System.Windows.Forms.TextBox();
            this.txthorasextdomnoche = new System.Windows.Forms.TextBox();
            this.txthorasextordnoche = new System.Windows.Forms.TextBox();
            this.txthorasextdomdia = new System.Windows.Forms.TextBox();
            this.txthorasextorddia = new System.Windows.Forms.TextBox();
            this.chkorddia = new System.Windows.Forms.CheckBox();
            this.chkdomdia = new System.Windows.Forms.CheckBox();
            this.chkordnoche = new System.Windows.Forms.CheckBox();
            this.chkdomnoche = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txthorasbasdomdia = new System.Windows.Forms.TextBox();
            this.txthorasbasdia = new System.Windows.Forms.TextBox();
            this.txthorasbasdomnoche = new System.Windows.Forms.TextBox();
            this.txthorasbasnoche = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbdevengado = new System.Windows.Forms.GroupBox();
            this.gbdeducciones = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbdevengado.SuspendLayout();
            this.gbdeducciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(137, 26);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(186, 487);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 2;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(573, 487);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(75, 23);
            this.btnterminar.TabIndex = 3;
            this.btnterminar.Text = "Terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // btnprocesar
            // 
            this.btnprocesar.Location = new System.Drawing.Point(347, 300);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(112, 23);
            this.btnprocesar.TabIndex = 4;
            this.btnprocesar.Text = "Procesar";
            this.btnprocesar.UseVisualStyleBackColor = true;
            this.btnprocesar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // txtbruto
            // 
            this.txtbruto.Location = new System.Drawing.Point(123, 20);
            this.txtbruto.Name = "txtbruto";
            this.txtbruto.ReadOnly = true;
            this.txtbruto.Size = new System.Drawing.Size(100, 20);
            this.txtbruto.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bruto";
            // 
            // txtsubstle
            // 
            this.txtsubstle.Location = new System.Drawing.Point(123, 55);
            this.txtsubstle.Name = "txtsubstle";
            this.txtsubstle.ReadOnly = true;
            this.txtsubstle.Size = new System.Drawing.Size(100, 20);
            this.txtsubstle.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Subs. Tle";
            // 
            // txtneto
            // 
            this.txtneto.Location = new System.Drawing.Point(123, 92);
            this.txtneto.Name = "txtneto";
            this.txtneto.ReadOnly = true;
            this.txtneto.Size = new System.Drawing.Size(100, 20);
            this.txtneto.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Neto";
            // 
            // txtsalud
            // 
            this.txtsalud.Location = new System.Drawing.Point(121, 19);
            this.txtsalud.Name = "txtsalud";
            this.txtsalud.ReadOnly = true;
            this.txtsalud.Size = new System.Drawing.Size(100, 20);
            this.txtsalud.TabIndex = 12;
            // 
            // txtpension
            // 
            this.txtpension.Location = new System.Drawing.Point(121, 45);
            this.txtpension.Name = "txtpension";
            this.txtpension.ReadOnly = true;
            this.txtpension.Size = new System.Drawing.Size(100, 20);
            this.txtpension.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pension";
            // 
            // txtparaf
            // 
            this.txtparaf.Location = new System.Drawing.Point(121, 71);
            this.txtparaf.Name = "txtparaf";
            this.txtparaf.ReadOnly = true;
            this.txtparaf.Size = new System.Drawing.Size(100, 20);
            this.txtparaf.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Parafiscales";
            // 
            // txtdedfondoemp
            // 
            this.txtdedfondoemp.Location = new System.Drawing.Point(121, 100);
            this.txtdedfondoemp.Name = "txtdedfondoemp";
            this.txtdedfondoemp.ReadOnly = true;
            this.txtdedfondoemp.Size = new System.Drawing.Size(100, 20);
            this.txtdedfondoemp.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fondo Emp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Salud";
            // 
            // rdbadmon
            // 
            this.rdbadmon.AutoSize = true;
            this.rdbadmon.Checked = true;
            this.rdbadmon.Location = new System.Drawing.Point(18, 14);
            this.rdbadmon.Name = "rdbadmon";
            this.rdbadmon.Size = new System.Drawing.Size(58, 17);
            this.rdbadmon.TabIndex = 21;
            this.rdbadmon.TabStop = true;
            this.rdbadmon.Text = "Admon";
            this.rdbadmon.UseVisualStyleBackColor = true;
            this.rdbadmon.CheckedChanged += new System.EventHandler(this.rdbadmon_CheckedChanged);
            // 
            // rbdprod
            // 
            this.rbdprod.AutoSize = true;
            this.rbdprod.Location = new System.Drawing.Point(109, 14);
            this.rbdprod.Name = "rbdprod";
            this.rbdprod.Size = new System.Drawing.Size(79, 17);
            this.rbdprod.TabIndex = 22;
            this.rbdprod.Text = "Produccion";
            this.rbdprod.UseVisualStyleBackColor = true;
            this.rbdprod.CheckedChanged += new System.EventHandler(this.rbdprod_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fondo Emp";
            // 
            // txtfondoemp
            // 
            this.txtfondoemp.Location = new System.Drawing.Point(397, 76);
            this.txtfondoemp.Name = "txtfondoemp";
            this.txtfondoemp.Size = new System.Drawing.Size(100, 20);
            this.txtfondoemp.TabIndex = 24;
            this.txtfondoemp.Text = "0";
            // 
            // txthorasextdomnoche
            // 
            this.txthorasextdomnoche.Location = new System.Drawing.Point(218, 90);
            this.txthorasextdomnoche.Name = "txthorasextdomnoche";
            this.txthorasextdomnoche.Size = new System.Drawing.Size(100, 20);
            this.txthorasextdomnoche.TabIndex = 30;
            this.txthorasextdomnoche.Visible = false;
            // 
            // txthorasextordnoche
            // 
            this.txthorasextordnoche.Location = new System.Drawing.Point(218, 47);
            this.txthorasextordnoche.Name = "txthorasextordnoche";
            this.txthorasextordnoche.Size = new System.Drawing.Size(100, 20);
            this.txthorasextordnoche.TabIndex = 28;
            this.txthorasextordnoche.Visible = false;
            // 
            // txthorasextdomdia
            // 
            this.txthorasextdomdia.Location = new System.Drawing.Point(90, 89);
            this.txthorasextdomdia.Name = "txthorasextdomdia";
            this.txthorasextdomdia.Size = new System.Drawing.Size(100, 20);
            this.txthorasextdomdia.TabIndex = 34;
            this.txthorasextdomdia.Visible = false;
            // 
            // txthorasextorddia
            // 
            this.txthorasextorddia.Location = new System.Drawing.Point(90, 46);
            this.txthorasextorddia.Name = "txthorasextorddia";
            this.txthorasextorddia.Size = new System.Drawing.Size(100, 20);
            this.txthorasextorddia.TabIndex = 32;
            this.txthorasextorddia.Visible = false;
            // 
            // chkorddia
            // 
            this.chkorddia.AutoSize = true;
            this.chkorddia.Location = new System.Drawing.Point(70, 52);
            this.chkorddia.Name = "chkorddia";
            this.chkorddia.Size = new System.Drawing.Size(15, 14);
            this.chkorddia.TabIndex = 35;
            this.chkorddia.UseVisualStyleBackColor = true;
            this.chkorddia.CheckedChanged += new System.EventHandler(this.chkorddia_CheckedChanged);
            // 
            // chkdomdia
            // 
            this.chkdomdia.AutoSize = true;
            this.chkdomdia.Location = new System.Drawing.Point(70, 92);
            this.chkdomdia.Name = "chkdomdia";
            this.chkdomdia.Size = new System.Drawing.Size(15, 14);
            this.chkdomdia.TabIndex = 36;
            this.chkdomdia.UseVisualStyleBackColor = true;
            this.chkdomdia.CheckedChanged += new System.EventHandler(this.chkdomdia_CheckedChanged);
            // 
            // chkordnoche
            // 
            this.chkordnoche.AutoSize = true;
            this.chkordnoche.Location = new System.Drawing.Point(198, 53);
            this.chkordnoche.Name = "chkordnoche";
            this.chkordnoche.Size = new System.Drawing.Size(15, 14);
            this.chkordnoche.TabIndex = 37;
            this.chkordnoche.UseVisualStyleBackColor = true;
            this.chkordnoche.CheckedChanged += new System.EventHandler(this.chkordnoche_CheckedChanged);
            // 
            // chkdomnoche
            // 
            this.chkdomnoche.AutoSize = true;
            this.chkdomnoche.Location = new System.Drawing.Point(198, 93);
            this.chkdomnoche.Name = "chkdomnoche";
            this.chkdomnoche.Size = new System.Drawing.Size(15, 14);
            this.chkdomnoche.TabIndex = 38;
            this.chkdomnoche.UseVisualStyleBackColor = true;
            this.chkdomnoche.CheckedChanged += new System.EventHandler(this.chkdomnoche_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbadmon);
            this.groupBox1.Controls.Add(this.rbdprod);
            this.groupBox1.Location = new System.Drawing.Point(58, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 51);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seccion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkdomnoche);
            this.groupBox2.Controls.Add(this.chkordnoche);
            this.groupBox2.Controls.Add(this.chkdomdia);
            this.groupBox2.Controls.Add(this.chkorddia);
            this.groupBox2.Controls.Add(this.txthorasextdomdia);
            this.groupBox2.Controls.Add(this.txthorasextorddia);
            this.groupBox2.Controls.Add(this.txthorasextdomnoche);
            this.groupBox2.Controls.Add(this.txthorasextordnoche);
            this.groupBox2.Location = new System.Drawing.Point(396, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 118);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "Dom/Fest";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 57;
            this.label16.Text = "Ordinarias";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(87, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 44;
            this.label19.Text = "Diurnas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nocturnas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 56;
            this.label14.Text = "Dom/Fest";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Ordinarias";
            // 
            // txthorasbasdomdia
            // 
            this.txthorasbasdomdia.Location = new System.Drawing.Point(83, 82);
            this.txthorasbasdomdia.Name = "txthorasbasdomdia";
            this.txthorasbasdomdia.Size = new System.Drawing.Size(100, 20);
            this.txthorasbasdomdia.TabIndex = 50;
            // 
            // txthorasbasdia
            // 
            this.txthorasbasdia.Location = new System.Drawing.Point(83, 42);
            this.txthorasbasdia.Name = "txthorasbasdia";
            this.txthorasbasdia.Size = new System.Drawing.Size(100, 20);
            this.txthorasbasdia.TabIndex = 49;
            // 
            // txthorasbasdomnoche
            // 
            this.txthorasbasdomnoche.Location = new System.Drawing.Point(201, 83);
            this.txthorasbasdomnoche.Name = "txthorasbasdomnoche";
            this.txthorasbasdomnoche.Size = new System.Drawing.Size(100, 20);
            this.txthorasbasdomnoche.TabIndex = 48;
            // 
            // txthorasbasnoche
            // 
            this.txthorasbasnoche.Location = new System.Drawing.Point(201, 42);
            this.txthorasbasnoche.Name = "txthorasbasnoche";
            this.txthorasbasnoche.Size = new System.Drawing.Size(100, 20);
            this.txthorasbasnoche.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(201, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 57;
            this.label15.Text = "Nocturnas";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(80, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 58;
            this.label18.Text = "Diurnas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txthorasbasdomdia);
            this.groupBox3.Controls.Add(this.txthorasbasdia);
            this.groupBox3.Controls.Add(this.txthorasbasdomnoche);
            this.groupBox3.Controls.Add(this.txthorasbasnoche);
            this.groupBox3.Location = new System.Drawing.Point(39, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 118);
            this.groupBox3.TabIndex = 59;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Basicas";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(39, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(817, 169);
            this.groupBox4.TabIndex = 60;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horas Trabajadas";
            // 
            // gbdevengado
            // 
            this.gbdevengado.Controls.Add(this.txtneto);
            this.gbdevengado.Controls.Add(this.label4);
            this.gbdevengado.Controls.Add(this.txtsubstle);
            this.gbdevengado.Controls.Add(this.label3);
            this.gbdevengado.Controls.Add(this.txtbruto);
            this.gbdevengado.Controls.Add(this.label2);
            this.gbdevengado.Location = new System.Drawing.Point(58, 331);
            this.gbdevengado.Name = "gbdevengado";
            this.gbdevengado.Size = new System.Drawing.Size(270, 150);
            this.gbdevengado.TabIndex = 61;
            this.gbdevengado.TabStop = false;
            this.gbdevengado.Text = "Devengado";
            this.gbdevengado.Visible = false;
            // 
            // gbdeducciones
            // 
            this.gbdeducciones.Controls.Add(this.label9);
            this.gbdeducciones.Controls.Add(this.txtdedfondoemp);
            this.gbdeducciones.Controls.Add(this.label8);
            this.gbdeducciones.Controls.Add(this.txtparaf);
            this.gbdeducciones.Controls.Add(this.label7);
            this.gbdeducciones.Controls.Add(this.txtpension);
            this.gbdeducciones.Controls.Add(this.label6);
            this.gbdeducciones.Controls.Add(this.txtsalud);
            this.gbdeducciones.Location = new System.Drawing.Point(460, 331);
            this.gbdeducciones.Name = "gbdeducciones";
            this.gbdeducciones.Size = new System.Drawing.Size(269, 150);
            this.gbdeducciones.TabIndex = 62;
            this.gbdeducciones.TabStop = false;
            this.gbdeducciones.Text = "Deducciones";
            this.gbdeducciones.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 543);
            this.Controls.Add(this.gbdeducciones);
            this.Controls.Add(this.gbdevengado);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtfondoemp);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnprocesar);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.gbdevengado.ResumeLayout(false);
            this.gbdevengado.PerformLayout();
            this.gbdeducciones.ResumeLayout(false);
            this.gbdeducciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.TextBox txtbruto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubstle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtneto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsalud;
        private System.Windows.Forms.TextBox txtpension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtparaf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdedfondoemp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdbadmon;
        private System.Windows.Forms.RadioButton rbdprod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfondoemp;
        private System.Windows.Forms.TextBox txthorasextdomnoche;
        private System.Windows.Forms.TextBox txthorasextordnoche;
        private System.Windows.Forms.TextBox txthorasextdomdia;
        private System.Windows.Forms.TextBox txthorasextorddia;
        private System.Windows.Forms.CheckBox chkorddia;
        private System.Windows.Forms.CheckBox chkdomdia;
        private System.Windows.Forms.CheckBox chkordnoche;
        private System.Windows.Forms.CheckBox chkdomnoche;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txthorasbasdomdia;
        private System.Windows.Forms.TextBox txthorasbasdia;
        private System.Windows.Forms.TextBox txthorasbasdomnoche;
        private System.Windows.Forms.TextBox txthorasbasnoche;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbdevengado;
        private System.Windows.Forms.GroupBox gbdeducciones;
    }
}

