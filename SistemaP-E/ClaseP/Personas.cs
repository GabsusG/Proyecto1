namespace ClaseP
{
    public class Personas
    {
        
        public string Nombre { get; }
        public int Edad { get; }
        public string Ciudad { get; }

        
        public Personas(string nombre, int edad, string ciudad)
        {
            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
        }

        
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Año de nacimiento: {Edad}");
            Console.WriteLine($"Ciudad: {Ciudad}");
        }

        
        public int CalcularEdadEnAnios()
        {
            
            int añoActual = DateTime.Now.Year;
         
            int edadEnAnios = añoActual - Edad;
            return edadEnAnios;
        }
    }
}
