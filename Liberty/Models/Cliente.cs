using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liberty.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public DadosCliente DadosCliente { get; set; }
    }

    public class DadosCliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public Veiculo Veiculo { get; set; }
    }

    public class Veiculo
    {
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
    }
}
