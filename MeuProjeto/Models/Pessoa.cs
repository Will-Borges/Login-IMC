using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeuProjeto.Models
{
    public class Pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

    }
}