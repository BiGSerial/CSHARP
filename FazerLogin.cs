using Aplicativo_CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesApp2
{
    internal class FazerLogin
    {
        public string login { get; set; }
        public string senha { get; set; }

        public ConexaoBD banco = new ConexaoBD();

        public string verificarLogin()
        {
            this.banco.conectar();
            try
            {
                MySqlDataReader reader = this.banco.Query("SELECT * FROM login WHERE usuario='" + this.login + "' AND senha='" + this.senha + "'");

                if (reader.Read())
                {
                    return "aceito";
                }
                else
                {
                    return "negado";
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("ERRO ao fazer a verificação na base da dados "+ ex);
            }
            this.banco.close();
            return "negado";
        }

    }
}
