using System;
using System.Globalization;
using System.Threading;

namespace RevisãoDigitalInovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] Alunos = new Aluno[10];
            int Contador = 0;
            ObterOpcaoUsuario();

            String OpcaoUsuario = Console.ReadLine();

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        //TODo: adicionar aluno.
                        Console.WriteLine("Informe o nome do aluno");
                        Aluno Aluno = new Aluno();
                        Aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a  nota do aluno");
                        if(Decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            Aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor deve ser Decimal");
                        }

                        Alunos[Contador] = Aluno;
                        Contador++;
                        Console.Clear();
                        break;
                    case "2":
                        //TODO: listar alunos.
                        foreach (Aluno a in Alunos){
                            if(!string.IsNullOrEmpty(a.Nome) )
                            {
                                Console.WriteLine($"Aluno - {a.Nome}  Nota - {a.Nota}");
                            }
                               
                        }
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;
                    case "3":
                        //TODO:calucular media geral.
                        decimal NotaTotal = 0;
                        int alunos = 0;
                        foreach (Aluno a in Alunos)
                        {
                            if (!string.IsNullOrEmpty(a.Nome))
                            {
                                NotaTotal += a.Nota;
                                alunos++;
                            }
                        }
                        string media = String.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:N}", (NotaTotal / alunos));
                        Console.WriteLine($" Média geral é : {media}");
                        Thread.Sleep(5000);
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Opção inválida");
                }


                ObterOpcaoUsuario();

                OpcaoUsuario = Console.ReadLine();
            }

            Console.WriteLine("Sistema finalizado!!");

        }

        private static void ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - sair");
            Console.WriteLine();
        }

    }
}
