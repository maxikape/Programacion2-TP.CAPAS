using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using Entitades;
using System.Data;

namespace Datos
{
    public class DatosProfesor : DatosConexionBD
    {
        #region Atributos

        #endregion

        #region Propiedades

        #endregion

        #region Constructores

        #endregion

        #region Métodos

        public int abmProfesor(string accion, Profesor objProfesor)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = "insert into Profesor values (" + objProfesor.Legajo +
                ",'" + objProfesor.Nombre + "');";
            if (accion == "Modificar")
                orden = "update Profesor set Nombre='" + objProfesor.Nombre + "' where CodProf ="
                 + objProfesor.Legajo + ";";

            // falta la orden de borrar
            OleDbCommand cmd = new OleDbCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de Profesor", e);
            }
            finally
            {
                Cerrarconexion();
            cmd.Dispose();
            }
            return resultado;
        }

        //***Metdodo devuelve listado de profesores que estan carggados en la tabla
        public DataSet listadoProfesores(string cual)
            {
                string orden = string.Empty;
                if (cual != "Todos")
                    orden = "select * from Profesionales where CodProf = " + int.Parse(cual) + ";";
                else
                    orden = "select * from Profesionales;";
                OleDbCommand cmd = new OleDbCommand(orden, conexion);
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter();
                try
                {
                    Abrirconexion();
                    cmd.ExecuteNonQuery();

                    da.SelectCommand = cmd;
                    da.Fill(ds);
                }
                catch (Exception e)
                {
                    throw new Exception("Error al listar profesionales", e);
                }
                finally
                {
                    Cerrarconexion();
                    cmd.Dispose();
                }
                return ds;
            }
    }
}


        #endregion
    
