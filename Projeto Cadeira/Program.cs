using System;


namespace Projeto_Cadeira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá bem vindo!");
            Console.WriteLine("Digite 1 para listar nossas opçoes de cadeiras ");
            Console.WriteLine("Se deseja sair, digite 0");
            int opUser = int.Parse(Console.ReadLine());

            Cadeira Escritorio = new Cadeira("Escritorio", "Preta", "5 Rodas", "5 Anos");
            Cadeira Gamer = new Cadeira("Gamer", "Azul", "6 Rodas", "3 Anos");
            Cadeira UniWhite = new Cadeira("Uni White", "Cinza", "5 Rodas", "4 Anos");
            Cadeira RollerWhite = new Cadeira("Roller White", "Branca", "5 Rodas", "5 Anos");

            Console.WriteLine(Escritorio.ToString());
            Console.WriteLine(Gamer.ToString());
            Console.WriteLine(UniWhite.ToString());
            Console.WriteLine(RollerWhite.ToString());
            Console.WriteLine("\nAplicativo finalizado\n");
        }
    }
}
