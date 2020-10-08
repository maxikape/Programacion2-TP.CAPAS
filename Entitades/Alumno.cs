﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entitades
{
    public class Alumno : Persona
    {
        #region Atributos
        private string carrera;
        private string legajo;
        #endregion

        #region Propiedades
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        #endregion

        #region Constructores
        public Alumno()
        {
        }

        public Alumno(string Nom, long DNI, DateTime FecNac, char Sex, string Carr, string Leg)
        {
            Nombre = Nom;
            Dni = DNI;
            FechNac = FecNac;
            Sexo = Sex;
            Carrera = Carr;
            Legajo = Leg;
        }
        #endregion


        #region Métodos
        #endregion
    }
}


