using System.Collections.Generic;
using Snoopy.Model;

namespace Snoopy.Controller
{
    public interface IControllerSnoopy
    {
        List<SnoopyModel> ObtenerPersonajes();

        void InsertarPersonaje(SnoopyModel personaje);

        void ActualizarPersonaje(SnoopyModel personaje);

        void EliminarPersonaje(int id);
    }
}
