﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libPractica1
{
    public class clsPractica1
    {
        #region "Atributos private variables"

        private int intseccion;
        private double dblfondoemp;
        private double dblhorasbasdia, dblhorasbasnoche;
        private double dblhorasbasdomdia, dblhorasbasdomnoche;
        private double dblhorasextorddia, dblhorasextordnoche;
        private double dblhorasextdomdia, dblhorasextdomnoche;

        private double dblbruto, dblsubstte, dblsalud, dblpension, dblparaf, dblneto;
        private string strerror;

        private double dblvrhora; //Valor de la hora ordinaria
        private double dblporcretsalud, dblporcretpension, dblporcretparaf;

        private double dblporcincordnoche;
        private double dblporcincorddomdia, dblporcincorddomnoche;

        private double dblporcincextorddia, dblporcincextordnoche;
        private double dblporcincextdomdia, dblporcincextdomnoche;

        private double dblsmlv;
        private double dblvrsubstte;
        private double dblvrhoraadm, dblvrhoraprod;


        // missing variables
        // private double dblhorasbasnoche;
        // private double dblhorasbasdomnoche;
        // private double dblhorasbasdomdia;
        #endregion


        #region "Constructor"


        public clsPractica1()
        {


            intseccion = 0;
            dblvrhora = 0;    // valor de la hora ordinaria
            dblfondoemp = 0;
            dblhorasbasdia = 0; dblhorasbasnoche = 0;
            dblhorasbasdomdia = 0; dblhorasbasdomnoche = 0;
            dblhorasextorddia = 0; dblhorasextordnoche = 0;
            dblhorasextdomdia = 0; dblhorasextdomnoche = 0;
            dblbruto = 0; dblsubstte = 0;
            dblsalud = 0; dblpension = 0; dblparaf = 0;
            dblneto = 0;

            dblporcretsalud = 0.04;
            dblporcretpension = 0.04;
            dblporcretparaf = 0.05;

            dblporcincordnoche = 1.35;
            dblporcincorddomdia = 1.75; dblporcincorddomnoche = 2.1;
            dblporcincextorddia = 1.25; dblporcincextordnoche = 2.0;
            dblporcincextdomdia = 1.75; dblporcincextdomnoche = 2.5;

            dblsmlv = 616000.0; // como es double siempre se le agrega el .0 ya que en una operacion se comeria los decimales
            dblvrsubstte = 72000.0;
            dblvrhoraadm = 10000.0; dblvrhoraprod = 8350.0;
            strerror = string.Empty;

        }

        #endregion

        // no todo atributo esta asociado a una propieadad



        #region "Propiedades public metodos"

        public int Seccion
        { set { intseccion = value; } }

        public double FondoEmpleado
        {
            set { dblfondoemp = value; }
            get { return dblfondoemp; }

        }

        // horas basicas
        public double Horasbas_diurnas
        {
            set { dblhorasbasdia = value; }
        }

        public double Horasbas_nocturnas
        {
            set { dblhorasbasnoche = value; }
        }

        public double Horasbas_domfest_diurnas
        {
            set { dblhorasbasdomdia = value; }
        }

        public double Horasbas_domfest_nocturnas
        {
            set { dblhorasbasdomnoche = value; }
        }

        // horas extra

        public double Horsextord_diurnas { set { dblhorasextorddia = value; } }

        public double Horasextdomfest_diurnas { set { dblhorasextdomdia = value; } }

        public double Horasextdomfest_norcturnas { set { dblhorasextdomnoche = value; } }

        public double Salariobruto { get { return dblbruto; } }

        public double Subsidio_tte { get { return dblsubstte; } }

        public double Salud { get { return dblsalud; } }

        public double Pension { get { return dblpension; } }

        public double Parafiscales { get { return dblparaf; } }

        public double Salarioneto { get { return dblneto; } }

        public string Error { get { return strerror; } }

        #endregion


        #region "Metodos privados"

        private bool Validar()
        {

            if (intseccion != 1 && intseccion != 2)
            {
                strerror = "seccion no valida";
                return false;
            }

            if (dblfondoemp < 0)
            {
                strerror = "valor de fondo de empleados no valido";
                return false;
            }


            // ordinarias
            if (dblhorasbasdia < 0)
            {
                strerror = "cantidad de horas basicas diurnas no valida";
                return false;

            }

            //
            if (dblhorasbasnoche < 0)
            {
                strerror = "cantidad de horas basicas nocturnas no valida";
                return false;

            }

            if (dblhorasbasdomdia < 0)
            {
                strerror = "cantidad de horas dominicales o festivas valida";
                return false;

            }

            if (dblhorasbasdomnoche < 0)
            {
                strerror = "cantidad de horas basicas dominicales o festivas no valida";
                return false;

            }

            if (dblhorasextorddia < 0)
            {
                strerror = "cantidad de horas extra ordinarias diurnas no valida";
                return false;

            }

            if (dblhorasextordnoche < 0)
            {
                strerror = "cantidad de horas extra nocturnas no valida";
                return false;

            }

            if (dblhorasextdomdia < 0)
            {
                strerror = "cantidad de horas extra dominicales o festivas no valida";
                return false;

            }

            if (dblhorasextdomnoche < 0)
            {
                strerror = "cantidad de horas extra dominicales no valida";
                return false;

            }





            return true;
        }




        public bool Calcular()
        {

            try
            {
                if (!Validar())
                {
                    return false;
                }


                if (intseccion == 1) // Administrativa
                {
                    dblvrhora = dblvrhoraadm;

                }
                else
                {

                    dblvrhora = dblvrhoraprod;
                }

                dblbruto = (dblhorasbasdia * dblvrhora) + (dblhorasbasnoche * dblvrhora * dblporcincordnoche) +
                (dblhorasbasdomdia * dblvrhora * dblporcincorddomdia) + (dblhorasbasdomnoche * dblvrhora * dblporcincorddomnoche) +
                (dblhorasextorddia * dblvrhora * dblporcincextorddia) + (dblhorasextordnoche * dblvrhora * dblporcincextordnoche) +
                (dblhorasextdomdia * dblvrhora * dblporcincextdomdia) + (dblhorasextdomnoche * dblvrhora * dblporcincextdomnoche);


                // subsidio de transporte

                if (dblbruto <= (2.0 * dblsmlv)) // no hay que poner cero porque ya esta inicializado en ello... si no entra ps
                {
                    dblsubstte = dblvrsubstte;
                }

                // deducibles
                dblsalud = dblbruto * dblporcretsalud;
                dblpension = dblbruto * dblporcretpension;
                dblparaf = dblbruto * dblporcretparaf;



                dblneto = (dblbruto + dblsubstte) - (dblsalud + dblpension + dblparaf + dblfondoemp);



                return true;
            }
            catch (Exception ex)
            {
                strerror = ex.Message;
                return false;

            }


        }





        #endregion



    }
}
