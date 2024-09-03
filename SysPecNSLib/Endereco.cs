using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysPecNSLib
{
    internal class Endereco
    {
        public int Id { get; set; }
        public int Cli_Id { get; set; }
        public char CEP { get; set; }
        public string? Logradouro { get; set; }
        public string Numero { get; set; }
        public string? Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public char UF { get; set; }
        public char Tipo_Endereco { get; set; }


        public Endereco()
        {

        }
        public Endereco(int id, int cli_id, char cep, string? logradouro, string numero, string? complemento, string bairro, string cidade, char uf, char tipo_endereco)
        {
            Id = id;
            Cli_Id = cli_id;
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_Endereco = tipo_endereco;
        }

        public Endereco(int cli_id, char cep, string? logradouro, string numero, string? complemento, string bairro, string cidade, char uf, char tipo_endereco)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            Tipo_Endereco = tipo_endereco;
        }

        public Endereco(int cli_id, char cep, string? logradouro, string numero, string? complemento, string bairro, string cidade, char uf)
        {
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_insert";
            cmd.Parameters.AddWithValue("spcliente_id", Cli_Id);
            cmd.Parameters.AddWithValue("spcep", CEP);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);
            var dr = cmd.ExecuteReader();
            while (dr.Read()) // bool, 
            {
                Cli_Id = dr.GetInt32(0);
            }



        }

    }
}
