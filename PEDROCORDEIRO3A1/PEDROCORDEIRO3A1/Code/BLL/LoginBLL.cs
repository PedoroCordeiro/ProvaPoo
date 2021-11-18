using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PEDROCORDEIRO3A1.Code.DTO;
using PEDROCORDEIRO3A1.Code.DAL;

namespace PEDROCORDEIRO3A1.Code.BLL
{
    class LoginBLL
    {
        Conexao x = new Conexao();
        public bool Logar(LoginDTO log){
            string script = $"select * from login where email ='{log.Email}' and senha ='{log.Senha}'";
            DataTable dados = x.Consultar(script);
            if (dados.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
