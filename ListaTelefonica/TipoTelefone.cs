using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaTelefonica
{
    public class TipoTelefone
    {
        public int idTipo {  get; set; }
        public string nome { get; set; }

        public TipoTelefone(int idTipo, string nome) 
        { 
            this.idTipo = idTipo;
            this.nome = nome;
        }

        public override string ToString()
        {
            return this.nome;
        }
    }
}
