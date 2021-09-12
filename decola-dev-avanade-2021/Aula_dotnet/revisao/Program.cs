using System;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;

            string opcaoUser = obterOpcaoUser();

            while (opcaoUser.ToUpper() != "EXIT")
            {
                switch (opcaoUser)
                {
                    case "1":
                        //TODO: Adicionar alunos
                        Console.WriteLine("Insira o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Insira sua nota:");                        
                        //CONVERTE VALOR INSERIDO PARA DECIMAL;
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser um decimal.");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    case "2":
                        //TODO: Listar alunos
                        foreach (var alun in alunos)
                        {
                            Console.WriteLine($"ALUNO: {alun.Nome} >>> NOTA: {alun.Nota}");

                            // if (!string.IsNullOrEmpty(alun.Nome))
                            // {
                            //     Console.WriteLine($"ALUNO: {alun.Nome} >>> NOTA: {alun.Nota}");
                            // }
                        }
                        break;
                    case "3":
                        //TODO: Calcular media geral alunos
                        decimal notaTotal = 0;
                        var numeroAlunos = 0;
                        for (int i=0; i < alunos.Length; i++)
                        {                            
                            if (!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numeroAlunos++;
                            }
                        }
                        var mediaGeral = notaTotal / numeroAlunos;
                        ConceitoEnum conceitoGeral;

                        if (mediaGeral < 2)
                        {
                            conceitoGeral = ConceitoEnum.E;
                        }
                        else if (mediaGeral < 4)
                        {
                            conceitoGeral = ConceitoEnum.D;
                        }
                        else if (mediaGeral < 6)
                        {
                            conceitoGeral = ConceitoEnum.C;
                        }
                        else if (mediaGeral < 8)
                        {
                            conceitoGeral = ConceitoEnum.B;
                        }
                        else
                        { 
                            conceitoGeral = ConceitoEnum.A;
                        }
                        Console.WriteLine($"MÉDIA GERAL {mediaGeral} >>> CONCEITO: {conceitoGeral}");

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUser = obterOpcaoUser();
            }   
        }
            private static string obterOpcaoUser()
                    {
                        Console.WriteLine("Informe a opção desejada:");
                        Console.WriteLine("1 >> Inserir novo aluno");
                        Console.WriteLine("2 >> Listar Alunos");
                        Console.WriteLine("3 >> Calcular média geral dos alunos");
                        Console.WriteLine();
                        Console.WriteLine("EXIT >> para sair do programa;");
                        Console.WriteLine();

                        string opcaoUser = Console.ReadLine();
                        return opcaoUser;
                    }

    }
}
