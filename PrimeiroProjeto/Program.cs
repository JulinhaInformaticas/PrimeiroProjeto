namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int soma;
            int sub;
            int mult;
            int div;


            Console.WriteLine("escolha um número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("escolha outro número, divisivel pelo anterior");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("soma = {0}", soma );
            sub = n1 - n2;
            Console.WriteLine("subtração = {0}", sub);
            div = n1 / n2;
            Console.WriteLine("divisão = {0}", div);
            mult = n1 * n2;
            Console.WriteLine("multiplicação = {0}", mult);

        }
    }
}

