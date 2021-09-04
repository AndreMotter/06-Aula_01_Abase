using System;

namespace Atividade_18_anos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade:");
            recebeidade();
        }

        static void recebeidade()
        {
            int idade = Convert.ToInt32(Console.ReadLine());
            string resposta = calculaIF(idade);
            Console.WriteLine(resposta);
        }

        static string calculaIF(int idade)

        {
            if (idade >= 17 && idade < 30)
            { 
                return "Adulto";
            }
            else if (idade >= 30 && idade < 50)
            {
                return "Maia idade";
            }
            else if (idade >= 50 && idade < 70)
            {
                return "Idoso";
            }
            else if (idade < 18)
            {
                return "Jovem";
            }
            else
            {
                return "Está fazendo hora extra";
            }
            
        }
    }
}
