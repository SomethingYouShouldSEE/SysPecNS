﻿using System.Data;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SysPecNSLib
{
    public class Estoque
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }
        public DateTime Data_Movimento { get; set; }
        public Pedido Barra { get; set; }

        public Estoque(int id, double quantidade, DateTime data_Movimento)
        {
            Id = id;
            Quantidade = quantidade;
            Data_Movimento = data_Movimento;
        }
        public Estoque(double quantidade, DateTime data_Movimento)
        {
            Quantidade = quantidade;
            Data_Movimento = data_Movimento;
        }


        public void Estoque_Up(int id, decimal quant, DateTime data_mov)
        {
            
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into estoques (id,quantidade,data_ultimo_movimento) values ({id},{quant},{data_mov});";
            cmd.ExecuteNonQuery();
        }
        public static List<Estoque> ObterList()
        {
            List<Estoque> list = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from estoque;";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                dr.GetInt32(0);
                dr.GetDecimal(1);
                dr.GetDateTime(2);
            }


            cmd.Connection.Close();
            return list;
        }



    }
}
