using System;

namespace revisao_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1.Inserir novo aluno;");
            Console.WriteLine("2.Listar novo aluno;");
            Console.WriteLine("3.Calcular média geral;");
            Console.WriteLine("x - Sair do programa;");
            Console.WriteLine();

            string opcaoUser = Console.ReadLine();

            while (opcaoUser.ToUpper != "X")
            {
                switch (opcaoUser)
                {
                    case "1": 
                        Console.WriteLine("Informe o nome do aluno: ");
                        var aluno = new aluno();
                        aluno.nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.nota = nota;
                        }
                        else
                        {
                            throw new ArgumentException ("Valor da nota deve ser decimal.");
                        }
                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2": 
                        foreach (var item in alunos)
                        {
                            if(!string.IsNullOrEmpty(item.name))
                            {
                                Console.WriteLine($"ALUNO: {item.name} - NOTA: {item.nota}");
                            }
                        }
                        break;
                    case "3": 
                        decimal notaTotal = 0;
                        var nrAlunos = 0;

                        for (int i = 0; i < nrAlunos.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(nrAlunos[i].nome))
                            {
                                notaTotal += nrAlunos[i].nota;
                            }
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"MEDIA GERAL: {mediaGeral}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                        break;
                }
                
            }

            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1.Inserir novo aluno;");
            Console.WriteLine("2.Listar novo aluno;");
            Console.WriteLine("3.Calcular média geral;");
            Console.WriteLine("x - Sair do programa;");
            Console.WriteLine();
        }
    }
}
