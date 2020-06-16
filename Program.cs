using System;

namespace Aula18_Sprint4_Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador ribamar = new Jogador();
            ribamar.Nome ="Ribamar";
            ribamar.Altura = 1.80f;
            ribamar.Peso = 80f;
            ribamar.Nacionalidade="Brasil";
            ribamar.Nascimento= DateTime.Parse("22/02.1910");
            ribamar.Posicao= "Meio campo";

            System.Console.WriteLine(ribamar.CalcularIdade());
            System.Console.WriteLine(ribamar.VerificarAposentadoria());

        }
    }
}
