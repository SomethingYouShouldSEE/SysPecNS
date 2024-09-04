using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string RazaoSocial{ get; set; }
        public string Fantasia { get; set; }
        public char CNPJ { get; set; }
        public string? Contato { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(int id, string razaosocial, string fantasia, char cnpj, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaosocial;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(string razaosocial, string fantasia, char cnpj, string contato, string telefone, string email)
        {
            RazaoSocial = razaosocial;
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        
    }   
}
