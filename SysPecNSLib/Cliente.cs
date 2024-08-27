using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime? DataNasc { get; set; }

        public Cliente() 
        {

        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime datanasc)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime datanasc)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            Email = email;
            DataNasc = datanasc;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_cliente_insert";
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spcpf", CPF);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);
        }
    }
}
