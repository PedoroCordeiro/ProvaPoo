using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEDROCORDEIRO3A1.Code.DTO
{
    class LoginDTO
    {
        private int _codigo;
        private string _email;
        private string _senha;
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Email { get => _email; set => _email = value; }
        public string Senha { get => _senha; set => _senha = value; }
    }
}
