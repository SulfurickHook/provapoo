using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//Importação da camada de negócio e da camada de acesso a dados
using _3A1JULIO25.CODE.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using _3A1JULIO25.CODE.DAL; //nomeProjeto.nomeDaPasta.nomeDaPasta

namespace _3A1JULIO25.CODE.BLL
{
    class LoginBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBanco conexao = new AcessoBanco();
        string tabela = "usuario";

        public bool RealizarLogin(LoginDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
