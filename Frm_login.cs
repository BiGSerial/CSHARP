using Aplicativo_CRUD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientesApp2
{
    public partial class Frm_login : Form
    {
        FazerLogin entrada = new FazerLogin();
        public Frm_login()
        {
            InitializeComponent();
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            entrada.login = box_in_user.Text;
            entrada.senha =box_in_psw.Text;

            if (entrada.verificarLogin() == "aceito")
            {
                frm_menu form = new frm_menu();
                this.Hide();      //esconde o formulario de login
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos", "Erro ao Entrar no Sistema");
            }

        }
    }

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
                System.Windows.Forms.MessageBox.Show("ERRO ao fazer a verificação na base da dados");
            }
            this.banco.close();
            return "negado";
        }
    }


}
