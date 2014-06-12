using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using LibConexionBD;
using LibLlenarCombos;
using LibLlenarGrids;
using LibLlenarRBList;

namespace Q
{
    public class Curso
    {

        private int codigo;

        private string titulo;
        private int numeroHoras;

        private decimal valor;
        private string nombreApp;
        private string mensaje;
        private int codEmpleado;
        private List<int> temas;

        public Curso(string nombreApp)
        {
            this.nombreApp = nombreApp;
        }


        public int Codigo
        {
            get { return codigo; }
        }



        public string Titulo
        {
            get { return titulo; }
        }

        public int NumeroHoras
        {
            get { return numeroHoras; }
        }



        public decimal Valor
        {
            get { return valor; }
        }

        public string Mensaje
        {
            get { return mensaje; }
        }

        public int CodEmpleado
        {
            get { return codEmpleado; }
        }

        public List<int> Temas
        {
            get { return temas; }
            set { temas = value; }
        }


        public bool getTemas(CheckBoxList cbl)
        {


            try
            {
                if (cbl == null)
                {
                    mensaje = "cbl nulo";
                    return false;
                }


                clsConexionBD conexion = new clsConexionBD(nombreApp);
                conexion.SQL = "EXEC GetTemas";
                if (!conexion.LlenarDataSet(false))
                {
                    mensaje = conexion.Error;
                    conexion.CerrarCnx();
                    conexion = null;
                    return false;
                }
                cbl.DataSource = conexion.DataSet_Lleno.Tables[0];
                cbl.DataValueField = "id";
                cbl.DataTextField = "titulo";
                cbl.DataBind();
                conexion.CerrarCnx();
                return true;



            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;

            }

        }



        public bool GetCurso(int id)
        {


            clsConexionBD obj = new clsConexionBD(nombreApp);

            //SELECT * FROM cursos WHERE id=''

            //string sql = "SELECT C.*,idtema FROM cursos C INNER JOIN Materiatemas ON codcurso = C.codigo WHERE codigo="+id;
            string sql = "EXEC GetCurso " + id;
            obj.SQL = sql;

            if (!obj.Consultar(false))
            {
                mensaje = obj.Error;
                return false;
            }


            if (!obj.DataReader_Lleno.HasRows)
            {
                mensaje = "No se encontro Ningun Registro: " + codigo;
                obj.DataReader_Lleno.Close();
                obj = null;
                return false;
            }

            obj.DataReader_Lleno.Read();
            this.codigo = obj.DataReader_Lleno.GetInt32(0);
            titulo= obj.DataReader_Lleno.GetString(1);
            numeroHoras= obj.DataReader_Lleno.GetInt32(2);
            valor= obj.DataReader_Lleno.GetDecimal(3);
            codEmpleado= obj.DataReader_Lleno.GetInt32(4);

            // ARRAY LIST
            Temas = new List<int>();
            Temas.Add( obj.DataReader_Lleno.GetInt32(5) );

            while ( obj.DataReader_Lleno.Read()  )
            {
              
               Temas.Add(obj.DataReader_Lleno.GetInt32(5));
       
            }

            
            obj.DataReader_Lleno.Close();
            obj = null;
            


            return true;
        }


        public bool UpdateTemas(CheckBoxList temas,int codEmpleado,int codcurso)
        {

            try
            {
                string sql;

                foreach (ListItem tema in temas.Items)
                {
                    if (tema.Selected)
                    {
                       // sql = "INSERT INTO Materiatemas VALUES ("+codcurso+","+tema.Value+","+codEmpleado+")";
                        sql = "EXEC UpdateTemas " + codcurso + "," + tema.Value + "," + codEmpleado;
                        if (!Grabar(sql)) return false;
                    }
                }
                return true;

            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }


        }




        public bool UpdateCurso(int codigo, string titulo, int numeroHoras, decimal valor, int codEmpleado)
        {
            try
            {
                // EXEC USP_Estudiante_Modificar
                //string sql = "UPDATE matriculas SET codigo='', fecha='', titulo='', numeroHoras='',valor='' , codEmpleado='' WHERE codigo='' and fecha='' ";

              //  string sql = "UPDATE cursos SET titulo='" + titulo + "', numeroHoras='" + numeroHoras + "',valor='" + valor + "' , codEmpleado='" + codEmpleado + "' WHERE codigo=" + codigo + "; DELETE FROM Materiatemas WHERE codcurso="+codigo;
                string sql = "EXEC UpdateCurso " + codigo + ", " + valor + ", '" + titulo + "' ," + numeroHoras + "," + codEmpleado;
                return Grabar(sql);
            }
            catch (Exception ex)
            {

                mensaje = ex.Message;
                return false;
            }
        }

        private bool Grabar(string sql)
        {
            try
            {
                clsConexionBD obj = new clsConexionBD(nombreApp);
                obj.SQL = sql;
                if (!obj.ConsultarValorUnico(false))
                {
                    mensaje = obj.Error;
                    //  cedula = obj.Valor_Unico.ToString().Trim(); 
                    obj = null;
                    return false;
                }
                mensaje = "Operacion Realizada Sactisfactoriamente";
                obj = null;
                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;

            }
        }



        public bool InsertCurso(int codigo, string titulo, int numeroHoras, decimal valor, int codEmpleado)
        {
            try
            {
                // int Act = (blnActivo) ? 1 : 0;
                // EXEC USP_Esudiante_Grabar
                // VAlUES (1,'02/02/13','python',4,100000,1);

                //  string sql = "INSERT INTO cursos VAlUES (" + codigo + ",'" + titulo + "'," + numeroHoras + "," + valor + "," + codEmpleado + ");";

                string sql = "EXEC InsertCurso " + codigo + ", " + valor + ", '" + titulo + "' ," + numeroHoras + "," + codEmpleado;
                return Grabar(sql);


            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;

            }

        }


        public bool FillGridCursos(GridView grid)
        {
            try
            {
                if (grid == null)
                {
                    mensaje = "Grid es Nulo";
                    return false;
                }
                //  strSQL = "EXEC USP_Matricula_LlenarGrid '" + strCarnet + "', " + intPeriodo + ";";
                // segun el carnet y periodo llenaba las materias.... 

                string strSQL = "EXEC GridCursos";
                clsLlenarGrids obj = new clsLlenarGrids(nombreApp);
                obj.SQL = strSQL;
                if (!obj.LlenarGrid_Web(grid))
                {
                    mensaje = obj.Error;
                    obj = null;
                    return false;
                }
                obj = null;
                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;

            }


        }





    }
}