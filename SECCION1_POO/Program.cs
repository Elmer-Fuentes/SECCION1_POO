namespace SECCION1_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            banco o = new banco();
            Console.WriteLine(o.GetSaldo);
            Console.WriteLine(o.GetSaldo = 300);
        }
    }

    public class banco
    {
        private decimal saldo = 100;



        public decimal GetSaldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

    }
    }
