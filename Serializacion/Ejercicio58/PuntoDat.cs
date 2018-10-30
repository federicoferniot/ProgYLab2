using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio58
{
    public class PuntoDat : Archivo, IArchivo<PuntoDat>
    {
        private string contenido;

        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }

        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                if ((base.ValidarArchivo(ruta)) && (Path.GetExtension(ruta) == ".dat"))
                    return true;
                throw new ArchivoIncorrectoException("El archivo no es un .dat");
            }
            catch(FileNotFoundException exc)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", exc);
            }
        }

        public bool Guardar(string ruta, PuntoDat obj)
        {
            throw new NotImplementedException();
        }

        public PuntoDat Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
