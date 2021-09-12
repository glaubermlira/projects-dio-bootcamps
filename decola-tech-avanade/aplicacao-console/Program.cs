using System;

namespace aplicacao_console
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageVotar = 14;
            if (ageVotar >= 16)
            {
                Console.WriteLine("Já pode votar");                
            }
            else 
            {
                Console.WriteLine("Ainda não é possível votar"); 

            }
        }
    }
}
