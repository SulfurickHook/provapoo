using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3A1JULIO25.CODE.BLL;
using _3A1JULIO25.CODE.DTO;

namespace _3A1JULIO25.UI
{
    public partial class Login : Form
    {
        LoginBLL loginBBL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public Login()
        {
            InitializeComponent();
        }

        private void btninserir_Click(object sender, EventArgs e)
        {
            //Capturar dados da tela
            loginDTO.Email = txtemail.Text;
            loginDTO.Senha = txtsenha.Text;


            //Chamada do método para verificar o acesso: 
            if (loginBBL.RealizarLogin(loginDTO) == true)
            {

                Form1 frm_rede = new Form1();
                frm_rede.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
