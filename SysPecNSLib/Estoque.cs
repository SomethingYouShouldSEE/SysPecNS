using System.Data;
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
        public decimal? Quantidade { get; set; }
        public DateTime? Data_Movimento { get; set; }
        public Pedido? Barra { get; set; }

        public Estoque(int id, decimal? quantidade, DateTime? data_Movimento)
        {
            Id = id;
            Quantidade = quantidade;
            Data_Movimento = data_Movimento;
        }
        public Estoque(decimal? quantidade, DateTime? data_Movimento)
        {
            Quantidade = quantidade;
            Data_Movimento = data_Movimento;
        }


        public void Estoque_Insert(decimal quant)
        {
            
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into estoques (id,quantidade,data_ultimo_movimento) values (0,{quant},default);";
            cmd.ExecuteNonQuery();

            //cmd.Connection.Close();
        }
        public static List<Estoque> ObterList()
        {
            List<Estoque> list = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from estoques;";
            var dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                list.Add(new(
                dr.GetInt32(0),
                dr.GetDecimal(1),
                dr.GetDateTime(2)));              
            }


            //cmd.Connection.Close();
            return list;
        }

        public void Estoque_Up_Quant(int id,decimal quant)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update estoques set quantidade = {quant},data_ultimo_movimento = default where {id};";
            cmd.ExecuteNonQuery();
            

            cmd.Connection.Close();

        }
         

    }
}
