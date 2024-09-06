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

        public void Deletar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_delete";
            cmd.ExecuteNonQuery();
        }

        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_endereco_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spcep", CEP);
            cmd.Parameters.AddWithValue("splogradouro", Logradouro);
            cmd.Parameters.AddWithValue("spnumero", Numero);
            cmd.Parameters.AddWithValue("spcomplemento", Complemento);
            cmd.Parameters.AddWithValue("spbairro", Bairro);
            cmd.Parameters.AddWithValue("spcidade", Cidade);
            cmd.Parameters.AddWithValue("spuf", UF);
            cmd.Parameters.AddWithValue("sptipo_endereco", Tipo_Endereco);
            cmd.ExecuteNonQuery();
        }

        public static Endereco ObterPorId(int id)
        {
            Endereco endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = $"select * from endereco where id = {id}";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco = new(
                    dr.GetInt32(0),
                    dr.GetInt32(1),
                    dr.GetChar(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetChar(8),
                    dr.GetChar(9)
                    );
            }
            return endereco;
        }
        public static List<Endereco> ObterLista()
        {
            List<Endereco> endereco = new();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from endereco order by cidade";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                endereco.Add(new(
                     dr.GetInt32(0),
                     dr.GetInt32(1),
                     dr.GetChar(2),
                     dr.GetString(3),
                     dr.GetString(4),
                     dr.GetString(5),
                     dr.GetString(6),
                     dr.GetString(7),
                     dr.GetChar(8),
                     dr.GetChar(9))
                     );
            }
            return endereco;
        }

    }
}
