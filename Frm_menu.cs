using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientesApp2
{
    public partial class Frm_menu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Frm_menu()
        {
            InitializeComponent();
        }

        private void AbrirFormNoPanel<Forms>() where Forms : Form, new ()
        {
            Form formulario;
            formulario = pnl_principal.Controls.OfType<Forms>().FirstOrDefault();
            {
                if (formulario == null)
                {
                    formulario = new Forms();
                    formulario.TopLevel = false;
                    formulario.FormBorderStyle = FormBorderStyle.None;
                    formulario.Dock = DockStyle.Fill;
                    pnl_principal.Controls.Add(formulario);
                    pnl_principal.Tag = formulario;
                    formulario.Show();
                    formulario.BringToFront();
                }
                else
                {
                    if (formulario.WindowState == FormWindowState.Minimized)
                    {
                        formulario.WindowState = FormWindowState.Normal;
                    }
                    formulario.BringToFront();
                }

            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_minimizar.Visible = true;
            btn_maximizar.Visible = false;
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_minimizar.Visible = false;
            btn_maximizar.Visible = true;
        }

        private void pnl_top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_paciente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Frm_paciente>();
        }

        private void btn_relatorio_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Frm_relatorio>();
        }
    }
}
