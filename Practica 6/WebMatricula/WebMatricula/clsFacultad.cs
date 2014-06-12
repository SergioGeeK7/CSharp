﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibLlenarCombos;
using LibLlenarGrids;

namespace WebMatricula
{
    public class clsFacultad
    {
        private string strApp;
        private string strSQL;
        private string strError;

        public clsFacultad(string NombreApp)
        {
            strApp = NombreApp;
            strSQL = String.Empty;
            strError = String.Empty;

        }

        public string Error
        {
            get { return strError; }
      
        }

        public bool LlenarGrid(GridView Grid)
         {
            try 
	        {	  
                if(Grid == null)
                {
                    strError = "Grid Nulo";
                    return false;
                }
                clsLlenarGrids obj = new clsLlenarGrids(strApp);
                obj.SQL = "EXEC USP_Facultad_BuscarGeneral";
                if(!obj.LlenarGrid_Web(Grid))
                {
                    strError = obj.Error;
                    obj = null;
                    return false;
                }
                obj = null;
                return true;
		
	        }
	        catch (Exception ex)
	        {
		        strError = ex.Message;
                return false;
		    
	       }
        }

        public bool LlenarCombo(DropDownList Combo)
        { 
            try 
	        {	        
		         if(Combo == null)
                {
                    strError = "Combo Nulo";
                    return false;
                }
                clsLlenarCombos obj = new clsLlenarCombos(strApp);
                obj.SQL = "EXEC USP_Facultad_BuscarGeneral";
                obj.CampoID = "Codigo";
                obj.CampoTexto = "Nombre";
                if(!obj.LlenarCombo_Web(Combo))
                {
                    strError = obj.Error;
                    obj = null;
                    return false;
                }
                obj = null;
                return true;

	        }
	        catch (Exception ex)
	        {
		
	         	strError = ex.Message;
                return false;
	        }
        }

        
    }
}