﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class clsPractica1
    {
        #region "Atributos"

        private int intseccion;
        private double dblfondoemp;
        private double dblhorasbasdia, horasbasnoche;
        private double horasbasdomdia,horasbasdomnoche;
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
        
        #endregion


        #region "Constructor"
        

        public clsPractica1()
        {
        
            
        intseccion=0;
        dblvrhora = 0;    // valor de la hora ordinaria
        dblfondoemp=0;
        dblhorasbasdia = 0; horasbasnoche = 0;
        horasbasdomdia = 0; horasbasdomnoche = 0;
        dblhorasextorddia = 0; dblhorasextordnoche = 0;
        dblhorasextdomdia = 0; dblhorasextdomnoche = 0;
        dblbruto = 0; dblsubstte = 0;
        dblsalud = 0; dblpension = 0; dblparaf = 0;
        dblneto = 0;

        dblporcretsalud = 0.04;
        dblporcretpension = 0.04;
        dblporcretparaf = 0.02;

        dblporcincordnoche = 1.35;
        dblporcincorddomdia = 1.75; dblporcincorddomnoche = 2.1;
        dblporcincextorddia = 1.25; dblporcincextordnoche = 1.75;
        dblporcincextdomdia = 2.0; dblporcincextdomnoche = 2.5;

        dblsmlv = 616000.0;
        dblvrsubstte = 72000.0;
        dblvrhoraadm = 10000.0; dblvrhoraprod = 8350.0;
        strerror = string.Empty;
        
        }

        #endregion





        #region "Propiedades"

        public int Seccion 
        { set {intseccion=value;} }

        public double Seccion
        {
            set { dblfondoemp = value; } 
            get { return dblfondoemp; } 
        
        }

        // horas basicas
        public double horasbas_diurnas
        {
            set { dblhorasbasdia = value; }
        }

        public double horasbas_nocturnas
        {
            set { horasbasnoche = value; }
        }

        public double horasbas_domfest_diurnas
        {
            set { horasbasdomdia = value; }
        }

        public double horasbas_domfest_nocturnas
        {
            set { horasbasdomnoche = value; }
        }

        // horas extra

        public double horsextord_diurnas { set { dblhorasextorddia = value; } }

        public double horasextdomfest_diurnas { set { dblhorasextdomdia= value; } }

        public double horasextdomfest_norcturnas { set { dblhorasextdomnoche = value; } }

        public double salariobruto { get { return dblbruto ; } }

        public double subsidio_tte { get { return dblsubstte; } }

        public double subsidio_tte { get { return dblsalud; } }

        public double pension { get { return dblpension; } }

        public double parafiscales { get { return dblparaf; } }

        public double salarioneto { get { return dblneto; } }

        public string error { get { return strerror; } }

        #endregion






    }
}
