﻿using System;

namespace Interfaces
{
    public class GuardarTexto<T, V> : IGuardar<T, V>
    {
        public bool Guardar(T obj)
        {
            return true;
        }

        public V Leer()
        {
            return (V)Convert.ChangeType("Texto Leído", typeof(V));
        }
    }
}
