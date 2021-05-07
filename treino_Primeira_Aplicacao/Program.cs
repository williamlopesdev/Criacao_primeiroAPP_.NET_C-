//Os desenvolvedores da Tailwind Traders sabem que estão prestes a dedicar recursos extensivos ao desenvolvimento de aplicativos para a plataforma .NET. Esses aplicativos exibirão aos usuários dados que podem ser lidos por pessoas, incluindo datas, horas e números. O .NET tem as funcionalidades para fazer isso, mas os desenvolvedores sabem que alguém já resolveu esse problema. Eles precisam de uma estrutura. Após algumas pesquisas, eles encontraram o Humanizer no registro de pacotes do NuGet. Ele parece ser amplamente usado e promete atender a todas as necessidades do .NET para manipular e exibir cadeias de caracteres, enumerações, datas, horas, tempos de duração, números e quantidades. A essa altura, os desenvolvedores querem apenas que você instale o Humanizer, escreva algumas manipulações de dados e as execute para ver se o Humanizer cumpre a promessa.


using System;
using Humanizer;

namespace treino_Primeira_Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantities:");
            HumanizeQuantities();

            Console.WriteLine("\nDate/Time Manipulation:");
            HumanizeDates();
        }

        static void HumanizeQuantities()
        {
            Console.WriteLine("case".ToQuantity(0));
            Console.WriteLine("case".ToQuantity(1));
            Console.WriteLine("case".ToQuantity(5));
        }

        static void HumanizeDates()
        {
            Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
            Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());
            Console.WriteLine(TimeSpan.FromDays(1).Humanize());
            Console.WriteLine(TimeSpan.FromDays(16).Humanize());
        }
    }
}

//Parabéns. Você instalou o Humanizer com sucesso como uma dependência e escreveu lógica para o código do aplicativo a fim de tornar os dados mais legíveis por pessoas. O Humanizer parece cumprir sua promessa e a Tailwind Traders provavelmente ficará feliz com essa avaliação.