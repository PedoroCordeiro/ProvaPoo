using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PEDROCORDEIRO3A1.Code.DAL
{
    class Conexao
    {
        MySqlConnection x;
        public void Conectar()
        {
            try
            {
                string banco = "Persist Security Info = false; " +
                    "server = localhost; " +
                    "database = savassigames; " +
                    "uid = root; pwd=";
                x = new MySqlConnection(banco);
                x.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Algo de errado ocorreu com a conexão ao banco.\n" + ex.Message);
            }
        }
        public void Executar(string script)
        {
            Conectar();
            MySqlCommand comando = new MySqlCommand(script, x);
            comando.ExecuteNonQuery();
        }
        public DataTable Consultar(string script)
        {
            Conectar();
            MySqlDataAdapter dats = new MySqlDataAdapter(script, x);
            DataTable dado = new DataTable();
            dats.Fill(dado);
            return dado;
        }
    }
}
