﻿using System.Data;
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
        public DateTime TimeStamp { get; set; }
        public bool? Ativo { get; set; }
        public int Endereco { get; set; }
        public Cliente() 
        {
            Id = 0;
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email,DateTime timestamp, DateTime? datanasc, bool ativo, int endereco)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            TimeStamp = timestamp;
            DataNasc = datanasc;
            Ativo = ativo;
            Endereco = endereco;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime timestamp, DateTime? datanasc, bool ativo, int endereco)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            TimeStamp = timestamp;
            DataNasc = datanasc;
            Ativo = ativo;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime datanasc, bool ativo, int endereco)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            DataNasc = datanasc;
            Ativo = ativo;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email, DateTime? datanasc)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            DataNasc = datanasc;
        }

        public Cliente(string? nome, string? cpf, string? telefone, string? email)
        {
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
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

            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Id = dr.GetInt32(0);
            }
        }

        public Cliente(int id, string? nome, string? cpf, string? telefone, string? email, DateTime timestamp, DateTime? datanasc, bool ativo)
        {
            Id = id;
            Nome = nome;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
            TimeStamp = timestamp;
            DataNasc = datanasc;
            Ativo = ativo;
        }

        public static Cliente ObeterPorId(int id)
        {
            Cliente cliente = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from clientes where id = {id}";
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                cliente = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetDateTime(5),
                    dr.GetDateTime(6),
                    dr.GetBoolean(7)
                    );
            }

            return cliente;
        }

        public static List<Cliente> ObterLista(string? nome = "")
        {
            List<Cliente> lista = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
           // if(nome == "")
           // {
           //     cmd.CommandText = "select * from clientes order by nome";
           // }
           // else
           //  {
           //     cmd.CommandText = $"select * from clientes where like '%{nome}%'";
           // }

            cmd.CommandText = "select * from clientes order by nome limit 10";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(
                    new(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetString(4),
                        dr.GetDateTime(5),
                        dr.GetDateTime(6),
                        dr.GetBoolean(7)
                        )
                    );
            }

            return lista;
        }


        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_clinte_update";
            cmd.Parameters.AddWithValue("spid", Id);
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("sptelefone", Telefone);
            cmd.Parameters.AddWithValue("spdatanasc", DataNasc);

            cmd.ExecuteNonQuery();
        }

        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
        }

        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update clientes set ativo = 1 where = {id}";
            cmd.ExecuteNonQuery();
        }
    }


    
}
