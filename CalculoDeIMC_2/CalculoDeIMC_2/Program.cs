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
            Console.Write("Digite sua altura: ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            float Resultado = (float)Math.Round((peso / (altura * altura)), 2);

            if (Resultado >= 0 && Resultado < 18.5)
            {
                Console.WriteLine($"Seu IMC é: {Resultado} Abaixo do peso \nNome: {nome}\nIdade: {idade} anos");
            }
            if (Resultado >= 18.5 && Resultado <= 24.9)
            {
                Console.WriteLine($"Seu IMC é: {Resultado} Normal \nNome: {nome}\nIdade: {idade} anos");
            }
            else if (Resultado >= 25 && Resultado <= 29.9)
            {
                Console.WriteLine($"Seu IMC é: {Resultado} Sobrepeso \nNome: {nome}\nIdade: {idade} anos");
            }
            else if (Resultado >= 30.0 && Resultado <= 34.9)
            {
                Console.WriteLine($"Seu IMC é: {Resultado} Obesidade Grau I \nNome: {nome}\nIdade: {idade} anos");
            }
            if (Resultado >= 35.0 && Resultado <= 39.9)
            {
                Console.WriteLine($"Seu IMC é: {Resultado} Obesidade Grau II \nNome: {nome}\nIdade: {idade} anos");
            }
            else if (Resultado >= 40)
            {
                Console.WriteLine($"Seu IMC é: {Resultado} Obesidade Grau III \nNome: {nome}\nIdade: {idade} anos");
            }
        }
    }
}