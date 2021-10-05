using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public Cliente (string nome, string cpf, string rg, string logradouro, string cep,
            string cidade, string estado)
        {

            Nome = ValidarStringVazia(nome);
            CPF = ValidarStringVazia(cpf);
            RG = ValidarStringVazia(rg);
            Logradouro = ValidarStringVazia(logradouro);
            CEP = ValidarStringVazia(cep);
            Cidade = ValidarStringVazia(cidade);
            Estado = ValidarStringVazia(estado);

        }
    
        private static string ValidarStringVazia(string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? throw new Exception("Propriedade deverá ser preenchida") : texto;
        }

        public string Nome { get; private set; }
        public string CPF{ get; private set; }
        public string RG { get; private set; }
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

    }
}
