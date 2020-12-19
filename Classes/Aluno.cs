using System;

namespace Sistema_Alunos.Classes
{
    public class Aluno
    {
       public string nome;

       public string curso;

       public string rg;

       public int idade;

       public bool bolsista;

       public float mediaFinal;

       public double valorDaMensalidade;

       public void VerMediaFinal(double media){

           Console.WriteLine($"A média do aluno é: {media}");
       }

       public void VerMensalidade(bool bolsista, double mensalidade){

           if (bolsista == true)
           {
               Console.WriteLine("Este aluno é bolsista");
               Console.WriteLine($"A mensalida de sem desconto é {mensalidade}");

               Console.WriteLine($"A mensalida de com desconto é {0.7*mensalidade}");
           }else{
               Console.WriteLine("Este aluno não é bolsista");
               Console.WriteLine(mensalidade);
           }


       }


    }
}