using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
    public class Contato
    {
        public string nome {  get; set; }
        public string telefone { get; set; }
        public string tipo { get; set; }

        public Contato(string nome, string telefone, string tipo) 
        { 
            this.nome = nome;
            this.telefone = telefone;
            this.tipo = tipo;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
