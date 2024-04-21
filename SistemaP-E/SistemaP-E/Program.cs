using ClaseP;
namespace SistemaP_E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personas persona1 = new Personas("Jose", 2005, "Santo Domingo");

            Console.WriteLine("Información de la persona:");
            persona1.MostrarInformacion();

            int edadEnAnios = persona1.CalcularEdadEnAnios();
            Console.WriteLine($"Edad en años: {edadEnAnios}");

            Estudantes estudiante1 = new Estudantes("Jose", 2005, "Santo Domingo", "Ingeniería Informática", "2021-2033", "ITLA");

            Console.WriteLine("Información completa del estudiante:");
            estudiante1.MostrarInformacionCompleta();
        }
    }
}
