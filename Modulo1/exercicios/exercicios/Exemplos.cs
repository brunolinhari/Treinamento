using System;
using System.Collections.Generic;
using System.Text;

namespace exercicios
{
    public class Exemplos
    {
        public void FatorialNumeroQuatro()
        {
            int fatorial = 4*3*2*1;
            Console.WriteLine($"Fatorial quatro: 4 x 3 x 2 x 1 = {fatorial}");
        }

        public int FatorialNumeroCinco()
        {
            return 5*4*3*2*1;
        }
        public int FatorialNumero(int valor)
        {
            //int cont = valor;
            int resultado = valor;
            for (int i = valor - 1; i > 0; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        }
        public void MaiorValor(int Valor1, int Valor2)
        {
            if (Valor1 > Valor2)
            {
                Console.WriteLine($"O maior valor é: {Valor1}");
            }
            else if (Valor1 < Valor2)
            {
                Console.WriteLine($"O maior valor é: {Valor2}");
            }
            else
            {
                Console.WriteLine("Os Valores são iguais");
            }
        }
        public void ParImpar(int Numero) 
        {
            decimal Valor;
            Valor = Numero % 2;
            if (Valor == 0)
            {
                Console.WriteLine("O numero é Par");
            }
            else
            {
                Console.WriteLine("O número é Impar");
            }
        }
        public decimal Calculadora(decimal Valor1, decimal Valor2, char operador)
        {
            decimal Resultado;
            if (operador == '+')
            {
                Resultado = Valor1 + Valor2;
            }
            else if (operador == '-')
            {
                Resultado = Valor1 - Valor2;
            }
            else if (operador == '/')
            {
                Resultado = Valor1 / Valor2;
            }
            else
            {
                Resultado = Valor1 * Valor2;    
            }
            return Resultado;
        }

        public void Tabuada(int Valor)
        {
            int Resultado;
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{Valor} X {i} = {Valor * i}");
            }
        }
        public decimal Conversao(decimal Valor, char Tipo)
        {
            switch (Tipo)
            {
                case 'C':
                    return ((Valor * 9) / 5) + 32;
                case 'F':
                    return ((Valor - 32) * 5) / 9;
                default:
                    return 0;
            }
        }
    }
}
