using System;

namespace atividade
{
    class Program
    {
        static void Main(string[] args)
        {
          Aluno[] alunos = new Aluno[5];
          int indiceAluno = 0;
          string opcaoUsuario = MenuOpcoes();

           while (opcaoUsuario.ToUpper() != "X")
           {
               switch (opcaoUsuario)
               {
                   case "1":
                   Console.WriteLine("Informe o nome do aluno:");
                   Aluno aluno = new Aluno();
                   aluno.Nome = Console.ReadLine();

                   Console.WriteLine("Informe a nota do aluno:");
                   
                   if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                   {
                        aluno.Nota =  nota;    
                   } 
                   else
                   {
                         throw new ArgumentException("O valoro da nota deve ser decimal");    
                   }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;                   

                   break;

                   case "2":
                   break;

                   case "3":
                   break;

                   default:
                   throw new ArgumentOutOfRangeException();
               }
                opcaoUsuario = MenuOpcoes(); 
           }
        }

        private static string MenuOpcoes()
        {
                Console.WriteLine();
                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - Inserir novo aluno");
                Console.WriteLine("2 - Listar alunos");
                Console.WriteLine("3 - Calcular média geral");
                Console.WriteLine("Informe 'X' para SAIR");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine();
                Console.WriteLine();
                return  opcaoUsuario;
        }

    }
}
