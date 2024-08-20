using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    /// <summary>
    /// Classe estatica (Não neccesita de instancia) de conexão de banco de dados
    /// </summary>
    public static class Banco // Classe de conexão de banco de dados
    {
        /// <summary>
        /// Método Abrir da classe Banco é utilizado para representar comandos SQL no
        /// Servidor informado, cujos dados foram informados na string de conexão(strconn)
        /// </summary>
        /// <returns>Entrega um objeto de comandos SQL, que serão executados na conexão</returns>
        public static MySqlCommand Abrir() // Metodo Conexão
        {
            // dados da conexão
            string strconn = @"server=127.0.0.1;database=syspecdb;user=root;password=";
            MySqlConnection cn = new MySqlConnection(strconn);
            MySqlCommand cmd = new();
            try //metodo de tramento de excessção
            {
                cn.Open();
                cmd.Connection = cn;

            }
            catch (Exception)
            {

                throw;
            }
            return cmd;
        }


    }
}