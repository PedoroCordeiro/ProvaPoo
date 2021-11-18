using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PEDROCORDEIRO3A1.Code.DAL;
using PEDROCORDEIRO3A1.Code.DTO;

namespace PEDROCORDEIRO3A1.Code.BLL
{
    class GameBLL
    {
        Conexao x = new Conexao();

        public void Insert(GameDTO game)
        {
            string insert = $"insert into game values(null, '{game.Nome}', '{game.Genero}', '{game.Valor}')";
            x.Executar(insert);
        }

        public void Update(GameDTO game)
        {
            string update = $@"update game set nome = '{game.Nome}',
                                genero ='{game.Genero}',
                                valor ='{game.Valor}' where codigo ='{game.Codigo}';";
            x.Executar(update);
        }

        public void Delete(GameDTO game)
        {
            string delete = $"delete from game where codigo = {game.Codigo}";
            x.Executar(delete);
        }

        public DataTable Read()
        {
            string read = "select * from game";
            return x.Consultar(read);
        }
    }
}
