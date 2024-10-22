namespace Ejercicio02.Models
{
    public class clsPersona
    {
        public int idPersona { get; set; }

        public string nombre { get; set; }

        public string apellidos { get; set; }

        public DateTime fechaNac { get; set; }

        public string direccion { get; set; }

        public string telefono { get; set; }

        public int edad
        {
            get
            {
                int age = DateTime.Now.Year - fechaNac.Year;

                if (DateTime.Now < fechaNac.AddYears(age))
                {
                    age--;
                }

                return age;
            }
        }

    }
}
