using System;


namespace Ex2POO
{
    public class Aluno
    {
        public string nome;

        public string curso;

        public string rg;

        public bool bolsista;

        public int idade;

        public double mediaFinal;

        public double valorMensalidade;

        public void VerMediaFinal(double media) {
            Console.WriteLine($"A média do aluno é: {media}");
        }

        public void VerMensalidade(bool temBolsa, double mensalidade) {
            if (temBolsa == true)
            {
                Console.WriteLine("Esse aluno é bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");
                Console.WriteLine($"Mensalidade com desconto: {0.7 * mensalidade}");
            }else{
                Console.WriteLine("Esse aluno não é bolsista");
                Console.WriteLine($"Mensalidade: {mensalidade}");
            }
        }
       
    }
}