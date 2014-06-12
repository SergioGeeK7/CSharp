using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibConexionBD;
using LibLlenarCombos;
using System.Web.UI.WebControls;
using LibLlenarGrids;

namespace Q
{
    public class CursosMatriculados
    {

        private string nombreApp;
        private string mensaje;
        private int cedula;
        private int codigoCur;
        private int idPeriodo;
        private int idJornada;
        private int idPago;
        private decimal estado;
        private int codEmpleado;
        private Object answer;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public int CodigoCur
        {
            get { return codigoCur; }
            set { codigoCur = value; }
        }

        public int IdPeriodo
        {
            get { return idPeriodo; }
            set { idPeriodo = value; }
        }

        public int IdJornada
        {
            get { return idJornada; }
            set { idJornada = value; }
        }

        public int IdPago
        {
            get { return idPago; }
            set { idPago = value; }
        }

        public decimal Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public int CodEmpleado
        {
            get { return codEmpleado; }
            set { codEmpleado = value; }
        }


        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }

        public CursosMatriculados(string nombreapp)
        {
            this.nombreApp = nombreapp;
        }



        public bool LlenarComboCurso(DropDownList Combo)
        {
            try
            {
                if (Combo == null)
                {
                    mensaje = "Combo Nulo";
                    return false;
                }
                clsLlenarCombos obj = new clsLlenarCombos(nombreApp);
                obj.SQL = "exec LlenaComboCurso";
                obj.CampoID = "codigo";
                obj.CampoTexto = "titulo";
                if (!obj.LlenarCombo_Web(Combo))
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


        public bool LlenarComboPeriodo(DropDownList Combo)
        {
            try
            {
                if (Combo == null)
                {
                    mensaje = "Combo Nulo";
                    return false;
                }
                clsLlenarCombos obj = new clsLlenarCombos(nombreApp);
                obj.SQL = "EXEC LlenaComboPeriodo";
                obj.CampoID = "id";
                obj.CampoTexto = "nombre";
                if (!obj.LlenarCombo_Web(Combo))
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


        public bool LlenarComboJornada(DropDownList Combo, int id)
        {
            try
            {
                if (Combo == null)
                {
                    mensaje = "Combo Nulo";
                    return false;
                }
                clsLlenarCombos obj = new clsLlenarCombos(nombreApp);
                // llena jornadas, o jornada especifica de una materia
                obj.SQL = "EXEC LlenaComboJornada " + id;
                obj.CampoID = "idjornada";
                obj.CampoTexto = "nombre";
                if (!obj.LlenarCombo_Web(Combo))
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



        public bool LlenarComboFormaPagos(DropDownList Combo)
        {
            try
            {
                if (Combo == null)
                {
                    mensaje = "Combo Nulo";
                    return false;
                }
                clsLlenarCombos obj = new clsLlenarCombos(nombreApp);
                obj.SQL = "EXEC LlenaComboFormaPagos";
                obj.CampoID = "id";
                obj.CampoTexto = "nombre";
                if (!obj.LlenarCombo_Web(Combo))
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


        public bool getMatricula(int cedula,int codcurso)
        {
            clsConexionBD obj = new clsConexionBD(nombreApp);

            //SELECT * FROM cursos WHERE id=''

            string sql = "EXEC GetMatricula "+cedula+", "+codcurso;
            obj.SQL = sql;

            if (!obj.Consultar(false))
            {
                mensaje = obj.Error;
                return false;
            }


            if (!obj.DataReader_Lleno.HasRows)
            {
                mensaje = "No se encontro Ningun Registro: " + cedula;
                obj.DataReader_Lleno.Close();
                obj = null;
                return false;
            }

            obj.DataReader_Lleno.Read();
            this.cedula = obj.DataReader_Lleno.GetInt32(0);
            this.codigoCur = obj.DataReader_Lleno.GetInt32(1);
            this.idPeriodo = obj.DataReader_Lleno.GetInt32(2);
            this.idJornada = obj.DataReader_Lleno.GetInt32(3);
            this.idPago = obj.DataReader_Lleno.GetInt32(4);
            this.estado = obj.DataReader_Lleno.GetDecimal(5);
            this.codEmpleado = obj.DataReader_Lleno.GetInt32(6);

            // ARRAY LIST

            obj.DataReader_Lleno.Close();
            obj = null;



            return true;
        }



        public bool UpdateMatricula(int ced,int codigocur,int idperiodo,int idjornada,int idpago,decimal estado,int codEmpleado)
        {
            try
            {
                // EXEC USP_Estudiante_Modificar
                //string sql = "UPDATE matriculas SET codigo='', fecha='', titulo='', numeroHoras='',valor='' , codEmpleado='' WHERE codigo='' and fecha='' ";

                // validar si no hay prerequicito antes !!!!
                if (!ValidaRequicito(codigocur, ced)) return false;
                string sql =
                          "EXEC UpdateMatricula "+ced+", "+codigocur+", "+idperiodo+" ,"+idjornada+","+idpago+","
                          +estado+","+codEmpleado;

                

                return Grabar(sql);
            }
            catch (Exception ex)
            {

                mensaje = ex.Message;
                return false;
            }
        }



        public bool InsertMatricula(int ced, int codigocur, int idperiodo, int idjornada, int idpago, int codEmpleado)
        {
            try
            {
                
                //string sql = "UPDATE matriculas SET codigo='', fecha='', titulo='', numeroHoras='',valor='' , codEmpleado='' WHERE codigo='' and fecha='' ";

                // validar si no hay prerequicito antes !!!!
                if (!ValidaRequicito(codigocur, ced)) return false;

                Curso curso = new Curso(nombreApp);
                
                if (!curso.GetCurso(codigocur))
                {
                    mensaje = curso.Mensaje;
                    return false;
                }
                
                decimal estado = curso.Valor;

                string sql =
                             "EXEC InsertMatricula " + ced + ", " + codigocur + ", " + idperiodo + " ," + idjornada + "," + idpago + ","
                             + estado + "," + codEmpleado;



                return Grabar(sql);
            }
            catch (Exception ex)
            {

                mensaje = ex.Message;
                return false;
            }
        }


        private bool ValidaRequicito(int codigocur,int cedula)
        {

            string sql = "exec Valida_Requicito "+codigocur+", "+cedula;
            Grabar(sql);

            if (answer.ToString() == "1")  return true; // fine
           
                
            mensaje = answer.ToString();
            return false;

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
                    answer = obj.Valor_Unico; 
                    obj = null;
                    return false;
                }
                //  codigo = Convert.ToInt32(obj.Valor_Unico.ToString().Trim());
                answer = obj.Valor_Unico; 
                obj = null;
                mensaje = "Operacion Realizada Sactisfactoriamente";
                return true;
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;

            }
        }


        public bool FillGridMatriculas(GridView grid)
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

                string strSQL = "EXEC GridMatriculas";
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