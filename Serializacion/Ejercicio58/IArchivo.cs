﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio58
{
    public interface IArchivo<T>
    {
        bool Guardar(string ruta, T obj);
        T Leer(string ruta);
    }
}
