using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class MetodosExtension
    {
        public static string ToSQL(this DateTime fecha)
        {
            return String.Format("{0}{1}{2}", fecha.Year, fecha.Month, fecha.Day);
        }
    }
}
