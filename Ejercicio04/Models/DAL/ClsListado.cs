using Ejercicio04.Models.ENT;

namespace Ejercicio04.Models.DAL
{
    public class ClsListado
    {
        private static List<ClsDepartamento> departamentos = new List<ClsDepartamento>
    {
        new ClsDepartamento("Recursos Humanos"),
        new ClsDepartamento("IT"),
        new ClsDepartamento("Marketing")
    };

        private static List<ClsPersona> personas = new List<ClsPersona>
    {
        new ClsPersona { nombre = "Juan", apellidos = "Pérez", idDepartamento = 1 },
        new ClsPersona { nombre = "Ana", apellidos = "García", idDepartamento = 2 },
        new ClsPersona { nombre = "Luis", apellidos = "Martínez", idDepartamento = 3 }
    };

        public static ClsPersona ObtenerPersonaAleatoria()
        {
            Random rnd = new Random();
            int index = rnd.Next(personas.Count);
            return personas[index];
        }

        public static List<ClsDepartamento> ObtenerDepartamentos()
        {
            return departamentos;
        }
    }


}
