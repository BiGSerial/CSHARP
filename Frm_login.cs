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
                Frm_menu form = new Frm_menu();
                this.Hide();      //esconde o formulario de login
                form.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha Inválidos", "Erro ao Entrar no Sistema");
            }

        }
    }

   

}
