using System;

namespace CalculoDeIMC_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Índice de Massa Corporal (IMC)");

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite sua idade: ");
            string idade = Console.ReadLine();
            Console.Write("Digite sua altura utilizando: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu peso utilizando: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            float CalculoIMC = (float)Math.Round((peso / (altura * altura)), 2);

            if (CalculoIMC >= 0 && CalculoIMC < 18.5)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC} Abaixo do peso \nNome: {nome}\nIdade: {idade} anos");
            }
            if (CalculoIMC >= 18.5 && CalculoIMC <= 24.9)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC} - Normal \nNome: {nome}\nIdade: {idade} anos");
            }
            else if (CalculoIMC >= 25 && CalculoIMC <= 29.9)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC} - Sobrepeso \nNome: {nome}\nIdade: {idade} anos");
            }
            else if (CalculoIMC >= 30.0 && CalculoIMC <= 34.9)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC} - Obesidade Grau I \nNome: {nome}\nIdade: {idade} anos");
            }
            if (CalculoIMC >= 35.0 && CalculoIMC <= 39.9)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC} - Obesidade Grau II \nNome: {nome}\nIdade: {idade} anos");
            }
            else if (CalculoIMC >= 40)
            {
                Console.WriteLine($"Seu IMC é: {CalculoIMC} - Obesidade Grau III \nNome: {nome}\nIdade: {idade} anos");
            }
        }
    }
}