using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repositorio.Controller;
using Repositorio.Models;

namespace AppNhibernateCrud
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool logado = false;

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void login()
        {

            UsuariosController dao = new UsuariosController();
            IList<Usuarios> list = dao.Listar();
            logado = false;
            string user = textBoxuser.Text;
            string password = textBoxpass.Text;

            int cont = 0;
            foreach (var l in list)
            {
                if (l.username.ToString().Equals(user) && l.password.ToString().Equals(password))
                {
                    cont++;
                }
            }

            if (cont > 0)
            {
                logado = true;
                this.Dispose();
            }
            else {
                logado = false;
                MessageBox.Show("Erro ao logar.");
            }
        }

      


        private void buttoncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonlogar_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
