using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public interface IDATOS <T>
    {
        List<T> Listar();
        bool Nuevo(T item);
        bool Actualizar(T item);
        bool Eliminar(T item);

    }
}
