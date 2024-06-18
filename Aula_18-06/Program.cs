using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_18_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador1 _joga1 = new Jogador1();
            Jogador1 _joga2 = new Jogador1();
            Console.WriteLine("jogador 1");

            var random = new Random();
            _joga1.Valor1 = random.Next(1, 6);
            Console.WriteLine(_joga1.Valor1);
            
            _joga1.Valor2 = random.Next(1, 6);
            Console.WriteLine(_joga1.Valor2);

            _joga1.Valor3 = random.Next(1, 6);
            Console.WriteLine(_joga1.Valor3);

            Console.WriteLine("jogador 2");
            _joga2.Valor1 = random.Next(1, 6);
            Console.WriteLine(_joga2.Valor1);

            _joga2.Valor2 = random.Next(1, 6);
            Console.WriteLine(_joga2.Valor2);
            
            _joga2.Valor3 = random.Next(1, 6);
            Console.WriteLine(_joga2.Valor3);

            if (_joga1.Media1() > _joga2.Media1())
            {
                Console.WriteLine("JOGADOR 1 VENCEDOR!!");
            }
            else if(_joga1.Media1() < _joga2.Media1())
            {
                Console.WriteLine("JOGADOR 2 VENCEDOR!!");
            }
            else { Console.WriteLine("!!DEU EMPATE!!"); }
            Console.ReadKey();

        }
    }
}
