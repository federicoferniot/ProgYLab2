using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;


namespace Entidades
{
    public class SerializarXML<T> : IArchivo<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            XmlTextWriter writer=null;
            XmlSerializer ser;
            try
            {
                writer = new XmlTextWriter(rutaArchivo, Encoding.UTF8);
                ser = new XmlSerializer(typeof(T));
                ser.Serialize(writer, objeto);
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException(e.Message, e);
            }
            finally
            {
                if (!(writer is null))
                    writer.Close();
            }
            return true;
        }

        public T Leer(string rutaArchivo)
        {
            T datoAuxiliar;
            XmlTextReader reader=null;
            XmlSerializer ser;
            try
            {
                reader = new XmlTextReader(rutaArchivo);
                ser = new XmlSerializer(typeof(T));
                datoAuxiliar = (T)ser.Deserialize(reader); 
            }
            catch(Exception e)
            {
                throw new ErrorArchivoException(e.Message, e);
            }
            finally
            {
                if (!(reader is null))
                    reader.Close();
            }
            return datoAuxiliar;
        }
    }
}
