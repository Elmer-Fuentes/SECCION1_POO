namespace SECCION1_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Persona2 persona2 = new Persona2("Alice", 30);
            persona2.saltar();
            Persona1 obj = new Persona1("Juan", 25);
            obj.Saludar();

            sumar o = new sumar(10, 5);
            o.suma();
        }

    }
    public class Persona1
    {
        // Atributos
        private string nombre;
        private int edad;
        // Constructor
        public Persona1(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        // Métodos
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {nombre} y tengo {edad} años.");
        }
    }


    public class Persona2
    {
        private string nombre2;
        private int edad2;

        public Persona2(string nombre2, int Edad2)
        {
            this.nombre2 = nombre2;
            this.edad2 = Edad2;
        }

        public void saltar()
        {

            Console.WriteLine($"Hola soy {nombre2} and tengo {edad2} años.");
        }
    }



    public class sumar
    {
        private int n1 = 0;
        private int n2 = 0;

        public sumar(int n1, int n2)
        { 
            this.n1 = n1;
            this.n2 = n2; 
        }


        public void suma()
        {
        int resultado = n1 + n2;
            Console.WriteLine($"La suma de {n1} y {n2} es: {resultado}");
        }

    }
}
