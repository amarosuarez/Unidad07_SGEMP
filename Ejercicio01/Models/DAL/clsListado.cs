namespace Ejercicio01.Models.DAL
{
    public class clsListado
    {
        /// <summary>
        /// Función que devuelve una lista de personas
        /// </summary>
        /// <returns>Listado de personas</returns>
        public List<clsPersona> obtenerListadoPersonas()
        {
            List<clsPersona> listaPersonas = new List<clsPersona>()
            {
                new clsPersona { idPersona = 1, nombre = "Ana", apellidos = "Pérez López", fechaNac = new DateTime(1990, 5, 12), direccion = "Calle Mayor 1", telefono = "600123456" },
                new clsPersona { idPersona = 2, nombre = "Luis", apellidos = "Gómez García", fechaNac = new DateTime(1985, 3, 25), direccion = "Calle Sol 22", telefono = "600654321" },
                new clsPersona { idPersona = 3, nombre = "María", apellidos = "Fernández Díaz", fechaNac = new DateTime(1993, 8, 9), direccion = "Avenida del Parque 10", telefono = "600987654" },
                new clsPersona { idPersona = 4, nombre = "Jorge", apellidos = "Sánchez Martín", fechaNac = new DateTime(1978, 12, 19), direccion = "Calle Luna 8", telefono = "600321098" },
                new clsPersona { idPersona = 5, nombre = "Carmen", apellidos = "Jiménez Torres", fechaNac = new DateTime(1987, 7, 5), direccion = "Calle Rayo 33", telefono = "600456789" }
            };

            return listaPersonas;
        }
    }
}
