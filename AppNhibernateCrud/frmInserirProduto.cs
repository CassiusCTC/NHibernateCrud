using System;
using System.Collections;
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
    public partial class frmInserirProduto : Form
    {
        public frmInserirProduto()
        {
            InitializeComponent();
            textBoxQnatidade.MaxLength = 15;
            textBoxDescricao.MaxLength = 250;
            //carregarcCombo();

        }

        private void frmInserirProduto_Load(object sender, EventArgs e)
        {
            carregarcCombo();
        }

        private void textBoxQnatidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //faz com que o txtbox so aceite numeros
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void carregarcCombo()
        {
            TiposController dao = new TiposController();
            ArrayList arr = new ArrayList();
            IList<Tipos> list = dao.Listar();
            foreach (var l in list)
            {
                arr.Add(new DadosComboBox(l.tipo.ToString(), l.id));

            }
            comboBox1.DataSource = arr;
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "valor";
        }

        private void toolStripButtonGravarProd_Click(object sender, EventArgs e)
        {
            Produtos model = new Produtos();
            ProdutosController dao = new ProdutosController();

            model.nomeprod = textBoxNProduto.Text;
            model.qnt = Convert.ToInt32(textBoxQnatidade.Text);
            model.tipo_id = comboBox1.SelectedIndex;
            model.usuarios_id = 2;
            model.descricao = textBoxDescricao.Text;
            model.data = DateTime.Now;
            if (!String.IsNullOrEmpty(model.nomeprod) &&
                model.qnt != null &&
                !String.IsNullOrEmpty(model.descricao) &&
                    model.tipo_id != null)
            {
                try
                {
                    errorP.Clear();
                    dao.add(model);
                    MessageBox.Show("Inserido com Sucesso.");

                }
                catch (Exception ex)
                {
                    errorP.Clear();
                    MessageBox.Show("Erro ao inserir: " + ex.Message);


                }
            }
            else {

                if (String.IsNullOrEmpty(model.nomeprod))
                {
                    errorP.SetError(textBoxNProduto, "Informe o nome do produto.");
                }
                if (model.qnt == null)
                {
                    errorP.SetError(textBoxQnatidade, "Informe a quantidade valor inteiro.");
                }
                if (model.tipo_id == null)
                {
                    errorP.SetError(comboBox1, "Informe a Classisficação do produto.");
                }

                if (String.IsNullOrEmpty(model.descricao))
                {
                    errorP.SetError(textBoxDescricao, "Informe Quantidade.");
                }
            }



            /*public void CreateMyMultilineTextBox()
    {
    // Create an instance of a TextBox control.
    TextBox textBox1 = new TextBox();

    // Set the Multiline property to true.
    textBox1.Multiline = true;
    // Add vertical scroll bars to the TextBox control.
    textBox1.ScrollBars = ScrollBars.Vertical;
    // Allow the TAB key to be entered in the TextBox control.
    textBox1.AcceptsReturn = true;
    // Allow the TAB key to be entered in the TextBox control.
    textBox1.AcceptsTab = true;
    // Set WordWrap to true to allow text to wrap to the next line.
    textBox1.WordWrap = true;
    // Set the default text of the control.
    textBox1.Text = "Welcome!";
    }*/
        }

        private void toolStripButtonVoltarProd_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
