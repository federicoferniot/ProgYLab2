using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Clases
{
    public class AlumnoDB : IDataBase<Alumno>
    {
        private const string connectionStr = "Data Source=lab2pc11\\sqlexpress;Initial Catalog=EjercicioClase;Integrated Security=True";
        public void Guardar(Alumno obj)
        {
            String consulta;
            SqlConnection conexion;
            SqlCommand comando;
            consulta = String.Format("INSERT INTO Alumnos (Nombre, Apellido, Dni, Nacimiento, Direccion) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')",
                obj.Nombre, obj.Apellido, obj.DNI, obj.Nacimiento.ToSQL(), obj.Direccion);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            conexion = new SqlConnection(connectionStr);
            comando.CommandText = consulta;
            comando.Connection = conexion;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void Modificar(Alumno obj)
        {
            throw new NotImplementedException();
        }

        public Alumno Traer()
        {
            throw new NotImplementedException();
        }
    }
}
