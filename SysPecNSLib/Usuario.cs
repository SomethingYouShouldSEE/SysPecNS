using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SysPecNSLib
{
    public class Usuario
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public Nivel Nivel { get; set; }
        public bool Ativo { get; set; }

        public Usuario()
        { // Caso não busque nada
            Nivel = new(); // Mesmo que Nulo ainda se cria valor vazio
        }
        public Usuario(int id, string? nome, string? email, string senha, Nivel nivel, bool ativo) //sobrecarga de metodos
        { // Caso busque com ID
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public Usuario(string? nome, string? email, string senha, Nivel nivel)
        { //Caso busque sem ID
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
        }

        public Usuario(string? nome, string? email, string senha, Nivel nivel, bool ativo)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Ativo = ativo;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_usuario_insert";
            cmd.Parameters.AddWithValue("spnome", Nome); //Paremetros da procedure do banco de dados
            cmd.Parameters.AddWithValue("spemail", Email);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id); // Id da classe Nivel
            var dr = cmd.ExecuteReader();
            while (dr.Read()) // bool, 
            {
                Id = dr.GetInt32(0);
            }

        }

        /// <summary>
        /// Obter por Id é um medotod estatico que retorna um objeto usuario complete baseado no id informado
        /// </summary>
        /// <param name="id">Id do usuario buscado</param>
        /// <returns>Objeto Usuario com todos os campos</returns>
        public static Usuario ObeterPorId(int id)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where id = {id}";
            var dr = cmd.ExecuteReader(); 
            if(dr.Read())
            {
                usuario = new(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    Nivel.ObterPorId(dr.GetInt32(4)), //Pega obter por id da classe Nivel
                    dr.GetBoolean(5));

            }

            return usuario;
        }
        public static List<Usuario> ObterLista(string? nome = "") //Entrega Lista | ([string? nome = ""]) - Opcional se não haver valor ira usar sem
        {
            List<Usuario> lista = new();
            var comandosSQL = Banco.Abrir();
            comandosSQL.CommandType = CommandType.Text;
            if (nome =="")
            {
                comandosSQL.CommandText = "select * from usuarios order by nome";
            }
            else
            {
                comandosSQL.CommandText = $"select * from usuarios where like '%{nome}%'";
            }

            comandosSQL.CommandText = "select * from usuarios order by nome limit 10"; //Limita até dez no banco e conforme for necessario adiciona mais dez conforme o 'while'
            var dr = comandosSQL.ExecuteReader(); //Armazena o acima e executa
            while (dr.Read())
            {
                lista.Add(  //Lista só aceita algo da mesma classe
                    new(    //Cria outra instacia para pegar dados de outros
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                        )
                    );
            }

            return lista;
        }
        public static Usuario EfetuarLogin(string email, string senha)
        {
            Usuario usuario = new();
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from usuarios where email = '{email}' and senha = md5('{senha}')"; // Email e Senha tera aspas simples em ambos
            var dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                usuario = new(dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        Nivel.ObterPorId(dr.GetInt32(4)),
                        dr.GetBoolean(5)
                        );
            }

            return usuario;
        }
        public void Atualizar()
        {
            //usuario: nome, senha, nível
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.StoredProcedure; // Pega uma procedure dentro do banco de dados
            cmd.CommandText = "sp_usuario_altera"; // Nome da procedure
            //cmd.Parameters.Add("spid", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = Id; | Mesma que debaixo mais coloca valor no Id
            cmd.Parameters.AddWithValue("spid", Id); // Adiciona parametro para Id para usar where no Banco para alterar aonde spid for Id

            // Direction Usado para dizer se é output ou input (entrada, saida)
            cmd.Parameters.AddWithValue("spnome", Nome);
            cmd.Parameters.AddWithValue("spnivel", Nivel.Id);
            cmd.Parameters.AddWithValue("spsenha", Senha);
            cmd.ExecuteNonQuery(); // Dita o que foi alterado 

            cmd.Connection.Close(); // Fecha a conneção aberta em cmd.Banco.Abrir 
        }
        public static void Arquivar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set ativo = 0 where id = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
        public void Restaurar(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"update usuarios set ativo = 1 where = {id}";
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }
    }
}
