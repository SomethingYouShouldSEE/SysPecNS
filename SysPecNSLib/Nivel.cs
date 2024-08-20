using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SysPecNSLib
{
    public class Nivel
    {
        // --Atributos (campo)--
        


        // --Propriedades--
        // --Metodos de acesso (set e get)--
               
        public int Id {  get; set; }
        public string? Nome { get; set; }
        public string? Sigla { get; set; }



        // --Metodos Construtores--
        public Nivel() { }

        public Nivel(string nome, string sigla) // --SobreCarga de Métodos
        { 
            Nome = nome;
        }

        public Nivel(int id, string? nome, string? sigla)
        {
            Id = id;
            Nome = nome;
            Sigla = sigla;
        }

        // --Métodos (Requisitos)--
        /// <summary>
        /// Método de inserir registro de nivel no banco de dados
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = $"inset into niveis (id, nome, sigla) values ('{Nome}', '{Sigla}')";
            cmd.ExecuteNonQuery();
        }

        public static Nivel ObterPorId(int id)
        {
            Nivel nivel = new();
            // Consulta no banco e retorna o Nivel
            return nivel;
        }

        public static List<Nivel> ObterLista()
        {
            List<Nivel> lista = new();
            // consultar para retornar a lista de niveis
            return lista;
        }

        public bool Atualizar()
        {
            return true;
        }
        public void Excluir(int id)
        {

        }
    }
}
