using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libPractica1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        #region "variables globales"

        string strcod;
        int intseccion=1;
        double dblvrhora; // valor hora ordinaria
        double dblfondoemp;
        double dblhorasbasdia, dblhorasbasnoche, dblhorasbasdomdia, dblhorasbasdomnoche;
        double dblhorasextorddia, dblhorasextordnoche, dblhorasextdomdia, dblhorasextdomnoche;


        #endregion



        #region "Metodos locales"

        private void Limpiar()
        {

            this.txtcodigo.Text = string.Empty;
            this.rdbadmon.Checked = true;
            this.txtfondoemp.Text = "0";
            this.txthorasbasdia.Text = string.Empty;
            this.txthorasbasnoche.Text = string.Empty;
            this.txthorasbasdomnoche.Text = string.Empty;
            this.txthorasbasdomdia.Text = string.Empty;

            this.chkorddia.Checked = false;
            this.chkordnoche.Checked = false;
            this.chkdomdia.Checked = false;
            this.chkdomnoche.Checked = false;
            this.gbdevengado.Visible = false;
            this.gbdeducciones.Visible = false;
            this.txtcodigo.Focus();

        }

        private void LimpiarDatosResultado()
        {
            this.txtbruto.Text = string.Empty;
            this.txtsubstle.Text = string.Empty;
            this.txtsalud.Text = string.Empty;
            this.txtpension.Text = string.Empty;
            this.txtparaf.Text = string.Empty;
            this.txtdedfondoemp.Text = string.Empty;
            this.txtneto.Text = string.Empty;


        }

        


          private bool CapturarDatos() //captura y validacion de los datos
            {
                try
                {
                    //codigo (Obligatorio)
                    strcod = this.txtcodigo.Text.Trim(); // quita los espacios de el string
                    if (string.IsNullOrEmpty(strcod))
                    {
                        MessageBox.Show("El codigo no es valido");
                        this.txtcodigo.Focus();
                        return false;
                     }

                    //fondo empleados
                    dblfondoemp = 0;
                    if (this.txtfondoemp.Text.Trim() != "0")
                        dblfondoemp = Convert.ToDouble(this.txtfondoemp.Text);


                    //horas oridinarias diurnas (Obligatoria)
                  //  if (string.IsNullOrEmpty(this.txthorasbasdia.Text.Trim()))
                  //  {
                    //    MessageBox.Show("Numero de horas Ordinaraias diurnas no valido");
                    //    this.txthorasbasdia.Focus();
                  //      return false;
                //    }

                    dblhorasbasdia = 0;

                    if (!string.IsNullOrEmpty(this.txthorasbasdia.Text.Trim()))
                    {
                        // ingresa si hay un valor en txthorasbasdia
                        dblhorasbasdia = Convert.ToDouble(this.txthorasbasdia.Text);
                    }
                    
                    
                    //horas oridinarias nocturnas
                    dblhorasbasnoche = 0;

                    if (!string.IsNullOrEmpty(this.txthorasbasnoche.Text.Trim()))
                        dblhorasbasnoche = Convert.ToDouble(this.txthorasbasnoche.Text);

                    //horas oridinaraio Dominicales/Festivo diurnas
                    dblhorasbasdomdia = 0;
                    if(! string.IsNullOrEmpty(this.txthorasbasdomdia.Text.Trim()))
                        dblhorasbasdia =  Convert.ToDouble(this.txthorasbasdomdia.Text);
                    //horas oridinarias Diminicles/festivas nocturnas
                    dblhorasbasnoche = 0;
                    if(! string.IsNullOrEmpty(this.txthorasbasdomnoche.Text.Trim() ))
                        dblhorasbasdomnoche = Convert.ToDouble(this.txthorasbasdomnoche.Text);

                    //horas estras oridianarias diurnas
                    dblhorasextorddia = 0;
                    if(this.chkorddia.Checked)
                        if(! string.IsNullOrEmpty(this.txthorasextorddia.Text.Trim() ))
                            dblhorasextdomdia = Convert.ToDouble(this.txthorasextorddia.Text);
                    //horas extras oridnarias nocturnas
                    dblhorasextordnoche = 0;
                    if(this.chkordnoche.Checked)
                        if(! string.IsNullOrEmpty(this.txthorasextordnoche.Text.Trim() ))
                            dblhorasextordnoche = Convert.ToDouble(this.txthorasextordnoche.Text);
                    //horas estras diminicales festivas/ diurnas
                    dblhorasextorddia = 0;
                    if(this.chkdomdia.Checked)
                        if(! string.IsNullOrEmpty(this.txthorasextdomdia.Text.Trim()))
                            dblhorasextdomdia = Convert.ToDouble(this.txthorasextdomdia.Text);
                    //horas extras dominicles/festivas nocturanas
                    dblhorasextdomnoche = 0;
                    if(this.chkdomnoche.Checked)
                        if(! string.IsNullOrEmpty(this.txthorasextdomnoche.Text.Trim() ))
                            dblhorasextdomnoche = Convert.ToDouble(this.txthorasextdomnoche.Text);
                    return true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error \n\r" + ex.Message);
                    return false;
                }
                
            }


        #endregion


        // Eventos de los objetos del form

          private void btnprocesar_Click(object sender, EventArgs e)
        {
            if (!CapturarDatos())
                return;


            clsPractica1 obj = new clsPractica1();
            // metodos set ¬¬ propiedades C# set
            obj.Seccion = intseccion;  
            obj.FondoEmpleado = dblfondoemp;
            obj.Horasbas_diurnas = dblhorasbasdia;
            obj.Horasbas_nocturnas = dblhorasbasnoche;
            obj.Horasbas_domfest_diurnas = dblhorasbasdomdia;
            obj.Horasbas_domfest_nocturnas = dblhorasbasdomnoche;

            obj.Horasextdomfest_diurnas = dblhorasextorddia;
            obj.Horasextdomfest_norcturnas = dblhorasextordnoche;
            obj.Horasextdomfest_diurnas = dblhorasextdomdia;
            obj.Horasextdomfest_norcturnas = dblhorasextdomnoche;

            if (!obj.Calcular())
            {
                MessageBox.Show(obj.Error);
                obj = null;
                return;
            }
            this.txtbruto.Text = obj.Salariobruto.ToString();
            this.txtsubstle.Text = obj.Subsidio_tte.ToString();
            this.txtneto.Text = obj.Salarioneto.ToString();

            this.txtsalud.Text = obj.Salud.ToString();
            this.txtpension.Text = obj.Pension.ToString();
            this.txtparaf.Text = obj.Parafiscales.ToString();
            this.txtdedfondoemp.Text = obj.FondoEmpleado.ToString();
            this.txtneto.Text = obj.Salarioneto.ToString();
            this.gbdevengado.Visible = true;
            this.gbdeducciones.Visible = true;















        }

          private void btnlimpiar_Click(object sender, EventArgs e)
          {
              Limpiar();
          }

          private void btnterminar_Click(object sender, EventArgs e)
          {
              this.Close();
          }

          private void rdbadmon_CheckedChanged(object sender, EventArgs e)
          {
              intseccion = 1;
              this.txtfondoemp.Focus();

          }

          private void rbdprod_CheckedChanged(object sender, EventArgs e)
          {
              intseccion = 2;
              this.txtfondoemp.Focus();
          }

          private void chkorddia_CheckedChanged(object sender, EventArgs e)
          {
              if (chkorddia.Checked)
              {

                  txthorasextorddia.Visible = true;
                  txthorasextorddia.Focus();
              }
              else
              {
                  txthorasextorddia.Visible = false;
              
              }


              this.txthorasextorddia.Text = string.Empty;
          }

          private void chkordnoche_CheckedChanged(object sender, EventArgs e)
          {

              if (chkordnoche.Checked)
              {

                  txthorasextordnoche.Visible = true;
                  txthorasextordnoche.Focus();
              }
              else
              {
                  txthorasextordnoche.Visible = false;

              }


              this.txthorasextordnoche.Text = string.Empty;


          }

          private void chkdomdia_CheckedChanged(object sender, EventArgs e)
          {

              if (chkdomdia.Checked)
              {

                  txthorasextdomdia.Visible = true;
                  txthorasextdomdia.Focus();
              }
              else
              {
                  txthorasextdomdia.Visible = false;

              }


              this.txthorasextdomdia.Text = string.Empty;


          }

          private void chkdomnoche_CheckedChanged(object sender, EventArgs e)
          {

              if (chkdomnoche.Checked)
              {

                  txthorasextdomnoche.Visible = true;
                  txthorasextdomnoche.Focus();
              }
              else
              {
                  txthorasextdomnoche.Visible = false;

              }


              this.txthorasextdomnoche.Text = string.Empty;



          }
    }
}
