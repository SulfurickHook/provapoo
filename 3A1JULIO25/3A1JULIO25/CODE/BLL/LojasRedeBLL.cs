using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importação da camada de negócio e da camada de acesso a dados
using _3A1JULIO25.CODE.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using _3A1JULIO25.CODE.DAL;
using System.Data;

namespace _3A1JULIO25.CODE.BLL
{
    class LojasRedeBLL
    {
         //Objeto para acesso ao banco de dados
        AcessoBanco conexao = new AcessoBanco();
        string tabela = "produto";

        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(LojasRedeDTO medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Nome_Produto}','{medDto.Preco}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()      //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(LojasRedeDTO meddDto) 
        {
            string alterar = $"update {tabela} set nome_produto = '{meddDto.Nome_Produto}', preco = '{meddDto.Preco}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(LojasRedeDTO medDto) 
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
    }
}
