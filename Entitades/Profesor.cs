using System;
using System.Collections.Generic;
using System.Text;

namespace Entitades
{
    public class Profesor : Persona
    {
        #region Atributos
        //private Int32 codProf;
        private string materia;
        private string legajo;
        #endregion

        #region Propiedades
        public string Materia
        {
            get { return materia; }
            set { materia = value; }
        }
        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        //public Int32 CodProf
        //{
        //    get { return CodProf; }
        //    set { CodProf = value; }
        //}
        #endregion

        #region Constructores
        public Profesor()
        {
        }

        public Profesor(string Nom, long DNI, DateTime FecNac, char Sex, string Mat, string Leg)
        {
            Nombre = Nom;
            Dni = DNI;
            FechNac = FecNac;
            Sexo = Sex;
            Materia = Mat;
            Legajo = Leg;
            //CodProf = Cod;
        }
        #endregion


       
    }

}


