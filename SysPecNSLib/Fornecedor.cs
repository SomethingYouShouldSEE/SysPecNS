using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

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
        public int FornPro { get; set; }
        public int Proid { get; set; }

        public Fornecedor()
        {

        }

        public Fornecedor(int id, string razaosocial, string fantasia, char cnpj, string contato, string telefone, string email)
        {
            Id = id;
            RazaoSocial = razaosocial;  // All in, Get by ID
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(string razaosocial, string fantasia, char cnpj, string contato, string telefone, string email)
        {
            RazaoSocial = razaosocial; // Update
            Fantasia = fantasia;
            CNPJ = cnpj;
            Contato = contato;
            Telefone = telefone;
            Email = email;
        }

        public Fornecedor(int id, int fornpro, int proid)
        {
            Id = id; // chamar FornPro ID
            FornPro = fornpro;
            Proid = proid;
        }

        public Fornecedor(int fornpro, int proid)
        {
            FornPro = fornpro;
            Proid = proid;
        }



        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_fornecedor_insert";
            cmd.Parameters.AddWithValue("spfornecedor_id", Id);
            cmd.Parameters.AddWithValue("sprazao_social", RazaoSocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", CNPJ);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            Id = Convert.ToInt32(cmd.ExecuteScalar());

        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_produto_update";
            cmd.Parameters.AddWithValue("spfornecedor_id", Id);
            cmd.Parameters.AddWithValue("sprazao_social", RazaoSocial);
            cmd.Parameters.AddWithValue("spfantasia", Fantasia);
            cmd.Parameters.AddWithValue("spcnpj", CNPJ);
            cmd.Parameters.AddWithValue("spcontato", Contato);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.ExecuteNonQuery();
        }


        public static Fornecedor ObterPorId(int id)
        {
            Fornecedor fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from fornedor where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetChar(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6)
                    );
            }
            return fornecedor;

        }

        public static List<Fornecedor> ObterLista()
        {
            List<Fornecedor> fornecedor = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from forcedor order by fantasia";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                fornecedor.Add(new(
                dr.GetInt32(0),
                dr.GetString(1),
                dr.GetString(2),
                dr.GetChar(3),
                dr.GetString(4),
                dr.GetString(5),
                dr.GetString(6)));
            }
            return fornecedor;
        }
        public static Fornecedor Tests()
        {
            var cmd = Banco.Abrir();
            Fornecedor fornecedor = new();
            cmd.CommandText = "select * from produtofornecedor ";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                fornecedor = new(
                dr.GetInt32(0),
                dr.GetInt32(1));
            }                

            return fornecedor;
        }

    }   
}