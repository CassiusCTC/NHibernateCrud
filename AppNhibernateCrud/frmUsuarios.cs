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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            carregarlistView();
        }
        private void carregarlistView()
        {

            IList<Usuarios> list = new UsuariosController().Listar();

            ListViewItem objtList;
            foreach (var l in list)
            {
                objtList = new ListViewItem();
                objtList.Text = l.id.ToString();
                objtList.SubItems.Add(l.email.ToString());
                objtList.SubItems.Add(l.username.ToString());
                objtList.SubItems.Add(l.password.ToString());
                objtList.SubItems.Add(l.nome.ToString());
                objtList.SubItems.Add(l.estado.ToString());

                //adiciona no listview
                listuser.Items.Add(objtList);

            }

        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            listuser.Items.Clear();
            carregarlistView();

        }
    }
}
