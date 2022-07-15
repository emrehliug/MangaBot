using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    internal class UsuarioModel
    {
        private int usuarioID;
        private string nome;
        private string senha;
        private string email;

        public int UsuarioID
        {
            get
            {
                return usuarioID;
            }
            set
            {
                usuarioID = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
