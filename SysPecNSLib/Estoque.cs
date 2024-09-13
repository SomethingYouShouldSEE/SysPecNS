using System.Data;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        



    }
}
