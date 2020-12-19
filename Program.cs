using System;
using Sistema_Alunos.Classes;

namespace Sistema_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno1.nome = Console.ReadLine();

            Console.WriteLine("Insira o nome do curso:");
            aluno1.curso = Console.ReadLine();

            Console.WriteLine("Insira idade:");
            aluno1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o RG do aluno:");
            aluno1.rg = Console.ReadLine();

            Console.WriteLine("O aluno é bolsista [S/N]");
            string resposta = Console.ReadLine();

            

            if (resposta.ToLower() == "s")
            {
                aluno1.bolsista=true;
            }else{
                aluno1.bolsista=false;
            }

            Console.WriteLine("Insira a média do aluno:");
            aluno1.mediaFinal = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira valor da mensalidade:");
            aluno1.valorDaMensalidade= double.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do aluno: Nome{aluno1.nome} idade {aluno1.idade} RG {aluno1.rg} Curso {aluno1.curso} Bolsista {aluno1.bolsista}");

            aluno1.VerMediaFinal(aluno1.mediaFinal);
            aluno1.VerMensalidade(aluno1.bolsista,aluno1.valorDaMensalidade);
        }
    }
}
