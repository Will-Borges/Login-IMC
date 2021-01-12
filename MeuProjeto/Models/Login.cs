using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeuProjeto.Models;

namespace MeuProjeto.Models
{
    public class Login
    {
        //public string usuario { get; set; }
        //public string senha { get; set; }

    public bool Logar(string usuario, string senha)
        { 

            if (VerificaNullos(usuario, senha))
            using (var context = new DBContext())
            {
                foreach (var pessoa in context.Pessoas)
                {
                    if (usuario == pessoa.Usuario & senha == pessoa.Senha)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool VerificaNullos(string usuario, string senha)
        {
            if (usuario == null)
            {
                //@ModelState.AddModelError("", "O usuário está vazio");
                return false;
                
            }

            if (senha == null)
            {               
                //AddModelError("", "A senha está vazia");
                return false;
            }

            return true;
        }
    }
}