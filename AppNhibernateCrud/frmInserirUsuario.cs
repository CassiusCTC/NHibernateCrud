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
using Repositorio.DAO;
using Repositorio.Models;

namespace AppNhibernateCrud
{
    public partial class frmInserirUsuario : Form
    {
        public frmInserirUsuario()
        {
            InitializeComponent();



        }
        /*private void button_insert_Click(object sender, EventArgs e)
        {
            Usuarios model = new Usuarios();
            UsuariosController dao = new UsuariosController();
           
            model.nome = textBox_name.Text;
            model.email =textBox_email.Text;
            model.username =textBox_usern.Text;
            model.password =textBox_pass.Text;
            model.estado = comboBox1.SelectedValue.ToString();
            if (!String.IsNullOrEmpty(model.nome) &&
                !String.IsNullOrEmpty(model.email) &&
                !String.IsNullOrEmpty(model.username) &&
                    !String.IsNullOrEmpty(model.password) &&
                    !String.IsNullOrEmpty(model.estado))
            {
                try
                {
                    errorv.Clear();
                    dao.add(model);
                    MessageBox.Show("Inserido com Sucesso.");
                 
                }
                catch (Exception ex)
                {
                    errorv.Clear();
                    MessageBox.Show("Erro ao inserir: " + ex.Message);
                   

                }
            }
            else {

                if (String.IsNullOrEmpty(model.nome)) {
                    errorv.SetError(textBox_name, "Informe o nome.");
                }
                if (String.IsNullOrEmpty(model.email))
                {
                    errorv.SetError(textBox_email, "Informe o email.");
                }
                if (String.IsNullOrEmpty(model.username))
                {
                    errorv.SetError(textBox_usern, "Informe o username.");
                }
                if (String.IsNullOrEmpty(model.password))
                {
                    errorv.SetError(textBox_pass, "Informe o password.");
                }
                if (String.IsNullOrEmpty(model.estado))
                {
                    errorv.SetError(comboBox1, "Informe o estado.");
                }

            }
          

        }*/

        private void frmInserirUsuario_Load(object sender, EventArgs e)
        {
            carregarcCombo();
            //carregarlistView();
            

        }

        private void carregarcCombo() {

            ArrayList arr = new ArrayList();
            arr.Add(new DadosComboBox("MG", 1));
            arr.Add(new DadosComboBox("SP", 2));
            arr.Add(new DadosComboBox("AM", 2));
            arr.Add(new DadosComboBox("SE", 2));
            arr.Add(new DadosComboBox("CE", 2));
            arr.Add(new DadosComboBox("AP", 2));
            arr.Add(new DadosComboBox("DF", 2));
            arr.Add(new DadosComboBox("PA", 2));
            comboBox1.DataSource = arr;
            comboBox1.DisplayMember = "nome";
            comboBox1.ValueMember = "valor";
        }

        private void toolStripButtonGravarProd_Click(object sender, EventArgs e)
        {
            Usuarios model = new Usuarios();
            UsuariosController dao = new UsuariosController();

            model.nome = textBox_name.Text;
            model.email = textBox_email.Text;
            model.username = textBox_usern.Text;
            model.password = textBox_pass.Text;
            model.estado = comboBox1.SelectedValue.ToString();
            if (!String.IsNullOrEmpty(model.nome) &&
                !String.IsNullOrEmpty(model.email) &&
                !String.IsNullOrEmpty(model.username) &&
                    !String.IsNullOrEmpty(model.password) &&
                    !String.IsNullOrEmpty(model.estado))
            {
                try
                {
                    errorv.Clear();
                    dao.add(model);
                    MessageBox.Show("Inserido com Sucesso.");

                }
                catch (Exception ex)
                {
                    errorv.Clear();
                    MessageBox.Show("Erro ao inserir: " + ex.Message);


                }
            }
            else {

                if (String.IsNullOrEmpty(model.nome))
                {
                    errorv.SetError(textBox_name, "Informe o nome.");
                }
                if (String.IsNullOrEmpty(model.email))
                {
                    errorv.SetError(textBox_email, "Informe o email.");
                }
                if (String.IsNullOrEmpty(model.username))
                {
                    errorv.SetError(textBox_usern, "Informe o username.");
                }
                if (String.IsNullOrEmpty(model.password))
                {
                    errorv.SetError(textBox_pass, "Informe o password.");
                }
                if (String.IsNullOrEmpty(model.estado))
                {
                    errorv.SetError(comboBox1, "Informe o estado.");
                }

            }



        }
    }
}
