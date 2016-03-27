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
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            carregarlistView();
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
            //dateTimePicker1.Value = DateTime.Today;
        }

        public void carregarlistView() {

            IList<Produtos> list= new ProdutosController().Listar();
            Tipos tipo = new Tipos();
            Usuarios user = new Usuarios();
            ListViewItem objtList;
            foreach (var l in list)
            {
                objtList = new ListViewItem();
                tipo = new TiposController().retornaItemId(l.tipo_id);
                user = new UsuariosController().retornaItemId(l.usuarios_id);
              
               if (tipo!=null && user!=null) { 
                        objtList.Text = l.id.ToString();                     
                        objtList.SubItems.Add(l.nomeprod.ToString());
                        objtList.SubItems.Add(tipo.tipo);
                        objtList.SubItems.Add(l.descricao.ToString());
                        objtList.SubItems.Add(l.qnt.ToString());                 
                        objtList.SubItems.Add(user.nome);
                        objtList.SubItems.Add(l.data.ToShortDateString());
                        //adiciona no listview
                        listViewprod.Items.Add(objtList);
              }
                
                

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButtonAddProd_Click(object sender, EventArgs e)
        {
            frmInserirProduto f = new frmInserirProduto();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewprod.Items.Clear();
            carregarlistView();
        }
    }
}
