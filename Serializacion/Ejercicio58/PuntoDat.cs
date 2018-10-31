using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio58
{
    [Serializable]
    public class PuntoDat : Archivo, IArchivo<PuntoDat>
    {
        public string contenido;

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
            FileStream fileStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            try
            {
                fileStream = new FileStream(ruta, FileMode.Create);
                binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, obj);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                if (!(fileStream is null))
                    fileStream.Close();
            }
        }

        public PuntoDat Leer(string ruta)
        {
            FileStream fileStream = null;
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            PuntoDat puntoDat;
            try
            {
                this.ValidarArchivo(ruta);
                fileStream = new FileStream(ruta, FileMode.Open);
                puntoDat = (PuntoDat)binaryFormatter.Deserialize(fileStream);

            }
            catch
            {
                puntoDat = null;

            }
            finally
            {
                if (!(fileStream is null))
                    fileStream.Close();
            }
            return puntoDat;
        }
    }
}
