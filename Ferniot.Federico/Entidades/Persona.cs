﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string documento;
        private string nombre;

        #region Propiedades

        public string Apellido
        {
            get { return this.apellido; }
        }

        public string  Documento
        {
            get { return this.documento; }
            set
            {
                if(this.ValidarDocumentacion(value))
                    this.documento = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        #endregion

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.Documento = documento;
        }

        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Apellido: {0}\n", this.apellido);
            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Documento: {0}\n", this.documento);

            return sb.ToString();
        }

        protected abstract bool ValidarDocumentacion(string documento);

    }
}
