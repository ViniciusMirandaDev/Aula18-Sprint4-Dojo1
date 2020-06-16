using System;

namespace Aula18_Sprint4_Dojo1
{
    public class Jogador
    {
        public string Nome {get; set;}
        public int Idade { get; set; }
        public string Posicao { get; set; }
        public string Nacionalidade { get; set; }
        public float Altura  { get; set; }
        public float Peso { get; set; }
        public DateTime Nascimento { get; set; }

        public int CalcularIdade(){

            int AnoAtual = Int32.Parse(DateTime.Now.ToString().Split('/')[2].Split(" ")[0]);
            int AnoNascimento = Int32.Parse(Nascimento.ToString().Split('/')[2].Split(" ")[0]);

            Idade = AnoAtual - AnoNascimento;
            return Idade;
        }

        public string VerificarAposentadoria(){

            CalcularIdade();
            string Retorno = "";
            if(Idade >= 35 && Posicao == "Atacante"){
                Retorno="O jogador pode se aposentar.";
            }else if(Idade >= 38 && Posicao == "Meio campo"){
                Retorno="O meio campista pode se aposentar.";
            }else if(Idade >= 40 && Posicao =="Goleiro"){
                Retorno="O goleiro pode se aposentar.";
            }
            return Retorno;
        }
        public void MostrarDados(){
            System.Console.WriteLine($"Nome: {Nome}, Posição: {Posicao}, Nascimento: {Nascimento}");
        }
    }
}