using System;

namespace Ex2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.Write("Insira o nome do curso: ");
            aluno1.curso = Console.ReadLine();

            Console.Write("Insira a idade do aluno: ");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o RG do Aluno: ");
            aluno1.rg = Console.ReadLine();

            Console.Write("O aluno é bolsista? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s")
            {
                aluno1.bolsista = true;
            }else if (resposta.ToLower() == "n") {
                aluno1.bolsista = false;
            }

            


        }
    }
}
