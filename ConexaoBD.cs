using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicativo_CRUD
{
    internal class ConexaoBD
    {
        //atributos
        private string host = "localhost";
        private string database = "basedados_pacientes";
        private string user = "root";
        private string password = "faesa";
        private int port = 3306;
        private MySqlConnection con;
        private MySqlCommand cmd;

        //construtor: serve para iniciar os atributos no momento de instanciar a classe
        public ConexaoBD()
        {
            conectar();
        }

        //método que faz a conexão com o Banco de Dados passando as configurações
        public void conectar()
        {
            string strCon = @"server=" + this.host + "; database=" + this.database +
"; user=" + this.user + "; password=" + this.password + "; port=" + this.port + ";";
            this.con = new MySqlConnection(strCon);
            this.cmd = this.con.CreateCommand();
            this.con.Open();
        }
        //método para fechar conexão com o Banco de Dados
        public void close()
        {
            this.con.Close();
        }
        //Executa os comandos SQL
        public void nonQuery(string sql)
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        //Executa os comandos SQL de consulta
        public MySqlDataReader Query(string sql)
        {
            this.cmd.CommandText = sql;
            return this.cmd.ExecuteReader();
        }

    }
}
