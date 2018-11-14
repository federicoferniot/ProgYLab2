using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public class Dao : IArchivo<Votacion>
    {
        public bool Guardar(string rutaArchivo, Votacion objeto)
        {
            String connectionStr = "Data Source=LAB2PC11\\SQLEXPRESS;Initial Catalog=votacion-sp-2018;Integrated Security=True";
            String consulta = String.Format("INSERT INTO Votaciones (nombreLey, afirmativos, negativos, abstenciones, nombreAlumno) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                            objeto.NombreLey, objeto.Afirmativos, objeto.Negativos, objeto.Abstenciones, "FFerniot");
            SqlConnection conexion=null;
            SqlCommand comando;
            try
            {
                conexion = new SqlConnection(connectionStr);
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = consulta;
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                throw (e);
            }
            finally
            {
                if (!(conexion is null))
                    conexion.Close();
            }
            return true;
        }

        public Votacion Leer(string rutaArchivo)
        {
            throw new NotImplementedException();
        }
    }
}
