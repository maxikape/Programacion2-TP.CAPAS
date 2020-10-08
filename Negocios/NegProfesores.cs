using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Entitades;
using Negocios;
using Datos;

namespace Negocios
{
    public class NegProfesores
    {
        #region Atributos

        DatosProfesores objDatosProfes = new DatosProfesores();

        #endregion

        #region Propiedades

        #endregion

        #region Constructores

        #endregion

        #region Métodos
        public int abmProfesores(string accion, Profesor objProfesional)
        {
            return objDatosProfes.abmProfesionales(accion, objProfesional);
        }
        public DataSet listadoProfesionales(string cual)
        {
            return objDatosProfes.listadoProfesionales(cual);
        }
        #endregion
    }
}