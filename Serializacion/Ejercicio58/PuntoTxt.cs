using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicio58
{
    public class PuntoTxt : Archivo, IArchivo<string>
    {
        protected override bool ValidarArchivo(string ruta)
        {
            try
            {
                if ((base.ValidarArchivo(ruta)) && (Path.GetExtension(ruta) == ".txt"))
                    return true;
                throw new ArchivoIncorrectoException("El archivo no es un .txt");
            }
            catch (FileNotFoundException exc)
            {
                throw new ArchivoIncorrectoException("El archivo no es correcto", exc);
            }
        }

        public bool Guardar(string ruta, string obj)
        {
            StreamWriter streamWriter = null;
            try
            {
                this.ValidarArchivo(ruta);
                streamWriter = new StreamWriter(ruta);
                streamWriter.Write(obj);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
            finally
            {
                if (!(streamWriter is null))
                    streamWriter.Close();
            }
        }

        public bool Guardar(string ruta)
        {
            return true;
        }

        public string Leer(string ruta)
        {
            throw new NotImplementedException();
        }
    }
}
