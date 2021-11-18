using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3A1JULIO25.CODE.DTO
{
    class LojasRedeDTO
    {
        //Properiedades privadas
        private int _id;
        private string _nome_produto;
        private string _preco;

        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string Nome_Produto { get => _nome_produto; set => _nome_produto = value; }
        public string Preco { get => _preco; set => _preco = value; }
    }
}
