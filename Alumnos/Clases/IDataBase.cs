using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    interface IDataBase<T>
    {
        void Guardar(T obj);
        void Modificar(T obj);
        T Traer();
    }
}
