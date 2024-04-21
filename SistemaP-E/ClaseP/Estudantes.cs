using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseP
{
    public class Estudantes : Personas
    {
        public string Carrera { get; }
        public string Matricula { get; }
        public string Universidad { get; }


        public Estudantes(string nombre, int edad, string ciudad, string carrera, string matricula, string universidad)
            : base(nombre, edad, ciudad)
        {
            Carrera = carrera;
            Matricula = matricula;
            Universidad = universidad;
        }
        public void MostrarInformacionCompleta()
        {

            MostrarInformacion();
            Console.WriteLine($"Carrera: {Carrera}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Universidad: {Universidad}");
        }
    }
}
 