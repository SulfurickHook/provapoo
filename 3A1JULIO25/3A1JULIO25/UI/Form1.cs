using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Importação da camada de negócio
using _3A1JULIO25.CODE.BLL;
using _3A1JULIO25.CODE.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace _3A1JULIO25.UI
{
    public partial class Form1 : Form
    {

        //Criação dos objetos que acessam a camada de negócio
        LojasRedeBLL medbll = new LojasRedeBLL();
        LojasRedeDTO meddto = new LojasRedeDTO();

        public Form1()
        {
            InitializeComponent();
        }

     

        private void btninserir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Nome_Produto = txtnome_produto.Text;
            meddto.Preco = txtpreco.Text;


            if (txtnome_produto.Text != "" || txtpreco.Text != "")
            {
                //Envio do dto preenchido para o método inserir
                medbll.Inserir(meddto);

                //Mensagem de sucesso
                MessageBox.Show("Cadastrado com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Limpeza dos componentes
                txtid.Clear();
                txtnome_produto.Clear();
                txtpreco.Clear();

            }
            else
            {
                //Mensagem de erro
                MessageBox.Show("Erro, preencha todos os campos!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvlojasrede.DataSource = medbll.Listar();
        }

        private void dgvlojasrede_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quando o usuario clicar em um registro da lista, os dados serão preenchidos
            txtid.Text = dgvlojasrede.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome_produto.Text = dgvlojasrede.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtpreco.Text = dgvlojasrede.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtid.Text);
            meddto.Nome_Produto = (txtnome_produto.Text);
            meddto.Preco = (txtpreco.Text);

            //Envio do dto preenchido para método editar
            medbll.Editar(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Alterado com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtid.Clear();
            txtnome_produto.Clear();
            txtpreco.Clear();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            //Preenchimento do objeto
            meddto.Id = int.Parse(txtid.Text);

            //Envio do dto preenchido para o método editar
            medbll.Excluir(meddto);

            //Mensagem de sucesso
            MessageBox.Show("Excluido com sucesso!", "Lojas Rede", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Atualização do GridView
            medbll.Listar();

            //Limpeza dos componentes
            txtid.Clear();
            txtnome_produto.Clear();
            txtpreco.Clear();
        }
    }
}
