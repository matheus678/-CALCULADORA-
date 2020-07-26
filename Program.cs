using System;

namespace ProjetoPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis do programa
            // A variável "n_escolhido" faz eferência ao numero que o usuário escolheu para a operção

            double um=0;
            double dois=0;
            double fim=0; 
            double n=0;

            string resolucao;
            string n_escolhido; 
            

            bool vlvalido=false;

            Console.WriteLine(" ~~~~~ calculadora prática ~~~~~ ");

            Console.Write(" Resolva os problemas da su vida com a mais nova Calculadora Prática! ");;

            Console.WriteLine("Pressione qualquer tecla para continuar.\n ");

            Console.ReadKey();

            string digitacao = "";

            while(digitacao != ".")

            double vl;
            double operacao1;

            {
    
             Console.Write("Escolha entre: (+) para soma (-) para subtração (*) para multiplicação (/) para divisão");
             operacao1 = Console.ReadLine();

             switch (operacao1)

            }

             Console.Write("Digite o primeiro valor.....:  ");

             vlusuario = Console.ReadLine();

             vlvalido = double.TryParse(vlusuario, out n);

             if (vlvalido)

            {

             primeiron = Math.Round(double.Parse(vlusuario), 5);

            }

            {
             Console.Write("Digite o segundo valor.....: ");

             n_escolhido = Console.ReadLine();

             if (vlvalido)

            }

            }

             dois = Math.Round(double.Parse(n_escolhido), 5);

            }

            switch (operacao1)

            case "+":

            fim = um + dois;

            Console.WriteLine($"{um} + {dois} = {fim}\n");

            break;
             
            case "-":

            fim = um - dois ;

            Console.WriteLine($"{um} - {dois} = {fim}\n");

            break;

            case "*":

            fim = um * dois ;

            Console.WriteLine($"{um} * {dois} = {fim}\n");

            break;

            case "/":

            fim = um / dois;

            Console.WriteLine($"{um} / {dois} = {fim}\n");

            break;

            }
        }
    }
}