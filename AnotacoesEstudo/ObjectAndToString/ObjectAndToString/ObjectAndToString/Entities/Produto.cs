using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectAndToString.Entities
{
    public class Produto
    {
        public Produto() { }

        public Produto(string Nome, double Preco, int QtdEstoque)
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.QtdEstoque = QtdEstoque;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int QtdEstoque { get; set; }


        //sobrescrita de método, somente colocar primeiramente o override e o vs irá dar o autocomplete
        public override string ToString()
        {
            return Nome + ", $" + Preco + ", " + QtdEstoque;
        }
    }
}
