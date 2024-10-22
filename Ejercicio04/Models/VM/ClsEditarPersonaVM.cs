using Ejercicio04.Models.DAL;
using Ejercicio04.Models.ENT;

namespace Ejercicio04.Models.VM
{
    public class ClsEditarPersonaVM : ClsPersona
    {
        public List<ClsDepartamento> departamentos { get; }

        public ClsEditarPersonaVM()
        {
            departamentos = ClsListado.ObtenerDepartamento();
        }

    }
}
