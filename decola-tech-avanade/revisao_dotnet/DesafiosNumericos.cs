using system;

namespace revisao_dotnet
{
    class DesafiosNumericos
    {
        static void Main(string[] args)
    {

        do
            {
                 Console.WriteLine("Informe a opção desejada: ");
                 int opcao = Convert.ToInt32(Console.ReadLine());
                 int soma = 0;
                
                switch (opcao)
                {
                    case 1: Console.WriteLine("1.Álcool");
                        break; 
                    case 2: Console.WriteLine("2.Gasolina");
                        break;
                    case 3: Console.WriteLine("3.Diesel");
                        break;
                    case 4: Console.WriteLine("4.Fim");
                        break;
                    default: Console.WriteLine("Informe um código valido");
                        continue;
                }
            }
       
         while (opcao != 4);

    

    }
    }
}