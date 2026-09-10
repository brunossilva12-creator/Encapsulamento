namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Bruno";

            Console.WriteLine(p.Nome);



            Console.ReadKey();
        }
    }
}
