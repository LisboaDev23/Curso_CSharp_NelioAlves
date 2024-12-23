using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvPoo.Entities
{
    public class Pessoa
    {
        public Pessoa() { }
        public Pessoa(string Nome, int Idade, char Sexo)
        {
            this.Nome = Nome;
            this.Idade = Idade;
            this.Sexo = Sexo;
        }
        public string Nome {  get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
    }
}
