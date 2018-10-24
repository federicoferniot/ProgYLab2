using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IGuardar<T, V>
    {
        bool Guardar(T obj);
        V Leer();
    }
}
