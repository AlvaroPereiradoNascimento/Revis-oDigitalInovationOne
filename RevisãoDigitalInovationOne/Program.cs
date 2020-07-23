using System;

namespace RevisãoDigitalInovationOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ObterOpcaoUsuario();

            String OpcaoUsuario = Console.ReadLine();

            while (OpcaoUsuario.ToUpper() != "X")
            {
                switch (OpcaoUsuario)
                {
                    case "1":
                        //TODo: adicionar aluno.
                        break;
                    case "2":
                        //TODO: listar alunos.
                        break;
                    case "3":
                        //TODO:calucular media geral.
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
