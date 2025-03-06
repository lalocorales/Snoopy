using System.Collections.Generic;
using Snoopy.Model;

namespace Snoopy.Controller
{
    public interface IControllerSnoopy
    {
        List<SnoopyModel> ObtenerPersonajes();
    }
}
