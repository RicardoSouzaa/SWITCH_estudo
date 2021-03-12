using System;

namespace SWITCH_estudo
{
    class Program
    {
        enum trasnporte { aviao, carro, onibus };
        static void Main(string[] args)
        {
            double tempo;
            char escolha;


            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Viagem de Londrina para Curitiba (Tempo de viagem)");
            Console.WriteLine("Escolha o meio de transpote  \n(a) Avião  \n(c) Carro \n(o)  Ônibus");
            escolha = char.Parse(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 45;
                    break;
                case 'c':
                case 'C':
                    tempo = 180; // 3 horas
                    break;
                case 'o':
                case 'O':
                    tempo = 330; // 5 horas e 30 min
                    break;
                default:
                    tempo = -1;
                    Console.WriteLine("o transporte escolhido não existe, escola novamente");
                    break;
            }
            if ( tempo > 0 && escolha == 'a' || escolha == 'A')
            {
                Console.WriteLine($"O transporte escolhido foi {trasnporte.aviao} e o tempo de viagem será de {tempo} minutos");
            }
            else if (tempo > 0 && escolha == 'c' || escolha == 'C')
            {
                Console.WriteLine($"O transporte escolhido foi {trasnporte.carro} e o tempo de viagem será de {tempo} minutos ou {tempo / 60} horas");
            }
            else if (tempo > 0 && escolha == 'o' || escolha == 'O')
            {
                Console.WriteLine($"O transporte escolhido foi {trasnporte.onibus} e o tempo de viagem será de {tempo} minutos ou {tempo / 60} horas");
            }
            else 
            {
                Main(null);
            }
            Console.Read();

        }
    }
}
