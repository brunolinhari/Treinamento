using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World1!");
            Console.WriteLine("Hello World2!");


            string nome;
            bool inativo;
            int numero;
            long numero_1;
            decimal valor = 10.52842M;
            DateTime hoje = DateTime.Now;
            string hoje_Formatado = hoje.ToString("dd/MM/yyyy");
            DateTime data = new DateTime(2019, 09, 01);
            char tipo;

            int[] array_int = new int[5];
            string[] array_string = new string[5];

            array_string[0] = "A";
            array_string[1] = "B";
            array_string[2] = "C";
            array_string[3] = "D";
            array_string[4] = "E";

            Console.WriteLine(">>" + hoje_Formatado);
            Console.WriteLine($">> {hoje_Formatado}");
            Console.WriteLine($">> {valor.ToString("#0.00")}");

            /*Console.Write("Digite deu nome: ");
            nome = Console.ReadLine();*/
            
            //if (nome != "BRUNO")
            /*if (nome.ToUpper() == "BRUNO")
            {
                Console.WriteLine("Nome é igual a BRUNO");
            }
            else
            {
                Console.Write("Nome é diferente de BRUNO");
                Console.WriteLine($"O nome é igual a: {nome.PadRight(10,'-')}");
            }*/

            Exemplos exemplo = new Exemplos();
            exemplo.FatorialNumeroQuatro();
            Console.WriteLine($"O fatorial de 5 é: {exemplo.FatorialNumeroCinco()}");

            int nFatorial;
            Console.Write("Digite um numero: ");
            nFatorial = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"O fatorial de {nFatorial} é: {exemplo.FatorialNumero(nFatorial)}");

            int Primeiro = Convert.ToInt32(Console.ReadLine());
            int Segundo  = Convert.ToInt32(Console.ReadLine());
            exemplo.MaiorValor(Primeiro, Segundo);

            exemplo.Tabuada(5);
        }
    }
}
